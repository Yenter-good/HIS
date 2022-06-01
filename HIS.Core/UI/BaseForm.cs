using HIS.ControlLib;
using HIS.ControlLib.Popups;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-06-30 18:10:12
/// 功能:
/// </summary>
namespace HIS.Core.UI
{
    public partial class BaseForm : DevComponents.DotNetBar.Office2007Form, IService, IViewContent
    {
        private IIniService _iniService;
        private string _iniPath = AppDomain.CurrentDomain.BaseDirectory + @"config.ini";
        private List<TabOrderContainer> _tabOrders = new List<TabOrderContainer>();

        public BaseForm()
        {
            InitializeComponent();
        }

        #region 控件按序激活

        public void AddTabOrderContainer(Control control)
        {
            _tabOrders.Add(new TabOrderContainer().Add(control));
            control.TabIndex = _tabOrders.Count;
        }
        public void AddTabOrderContainer(TabOrderContainer container)
        {
            _tabOrders.Add(container);
            foreach (var control in container.Controls)
                control.TabIndex = _tabOrders.Count;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter && EnabledEnterNext) || (keyData == Keys.Tab && EnabledTabNext))
            {
                var index = _tabOrders.FindIndex(p => p.Controls.Contains(this.ActiveControl));
                if (index < 0)
                    return base.ProcessCmdKey(ref msg, keyData);
                if (index == this._tabOrders.Count - 1)
                {
                    if (this is BaseDialogForm dialog)
                        dialog.SetButtonInvoke(MessageBoxDefaultButton.Button1);
                    return base.ProcessCmdKey(ref msg, keyData);
                }

                var container = this._tabOrders[index + 1];
                this.ActiveControl = container.Condition == null ? container.Controls[0] : container.Condition.Invoke(this);

                if (this.ActiveControl is ComboBox comboBox)
                    comboBox.DroppedDown = true;
                else if (this.ActiveControl is FindComboBox fcb)
                    fcb.ShowPopup();
                else if (this.ActiveControl is FilterTree ft)
                    ft.ShowPopup();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region 属性

        public bool EnabledEnterNext { get; set; }
        public bool EnabledTabNext { get; set; }

        public ViewData ViewData { get; } = new ViewData();

        public virtual bool ShowDeptList { get; set; } = true;

        public bool SetViewUnitData(long deptId)
        {
            var dept = App.Instance.RuntimeSystemInfo.DeptList.Union(App.Instance.RuntimeSystemInfo.DefaultDeptList).ToList().Find(d => d.Id == deptId);
            if (this.ViewData.Dept == null)
            {
                this.ViewData.Dept = dept;
                return true;
            }
            if (this.ViewData.Dept != dept)
            {
                var cancelEventArgs = new CancelEventArgs();
                this.OnDeptChanging(dept, cancelEventArgs);
                if (cancelEventArgs.Cancel)
                    return false;
                this.ViewData.Dept = dept;
                //变更科室后 当前的用户确保符合当前科室

                this.OnDeptChanged();
            }
            return true;
        }

        public virtual List<DeptEntity> FilterViewDeptList()
        {
            return App.Instance.RuntimeSystemInfo.DeptList;
        }
        /// <summary>
        /// 创建参数
        /// </summary>
        public string CreateParame { get; set; }
        #endregion

        #region 方法
        public new bool Close()
        {
            var cancel = new CancelEventArgs();
            this.OnViewClosing(cancel);
            if (cancel.Cancel)
                return false;

            base.Close();
            return true;
        }

        /// <summary>
        /// 设置子视图
        /// </summary>
        /// <param name="view"></param>
        protected virtual void SetChildView(Control view)
        {
            //if (view is IViewContent/*IChildViewContent*/)
            //{
            var childView = (view as IViewContent);
            if (childView is IViewContent)
            {
                var viewContent = childView as IViewContent;
                if (this.ViewData == null)
                    return;
                foreach (var item in this.ViewData._data)
                {
                    if (!viewContent.ViewData._data.ContainsKey(item.Key))
                        viewContent.ViewData._data[item.Key] = item.Value;
                }
            }
            //}
        }
        #endregion

        #region 虚方法

        /// <summary>
        /// 科室发生变更时
        /// </summary>
        /// <param name="dept"></param>
        /// <param name="args"></param>
        protected virtual void OnDeptChanging(DeptEntity dept, CancelEventArgs args)
        {
        }

        /// <summary>
        /// 科室发送变更后
        /// </summary>
        protected virtual void OnDeptChanged()
        {
        }
        /// <summary>
        /// 当视图企图关闭时
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnViewClosing(CancelEventArgs args)
        {
        }
        #endregion

        #region Ini

        public DataResult WriteIni(string section, string key, string value)
        {
            if (_iniService == null)
                _iniService = ServiceLocator.GetService<IIniService>();
            if (!File.Exists(_iniPath))
            {
                try
                {
                    File.Create(_iniPath).Dispose();
                }
                catch (Exception ex)
                {
                    return DataResult.Fault(ex.Message);
                }
            }

            var result = _iniService.WriteIni(section, key, value, _iniPath);
            return result;
        }

        public DataResult<string> ReadIni(string section, string key, string defaultValue = "")
        {
            if (_iniService == null)
                _iniService = ServiceLocator.GetService<IIniService>();
            if (!File.Exists(_iniPath))
                return DataResult.Fault<string>("未找到配置文件");

            return _iniService.ReadIni(section, key, defaultValue, _iniPath);
        }

        public DataResult DeleteIniKey(string section, string key)
        {
            if (_iniService == null)
                _iniService = ServiceLocator.GetService<IIniService>();
            if (!File.Exists(_iniPath))
                return DataResult.Fault("未找到配置文件");

            return _iniService.DeleteKey(section, key, _iniPath);
        }

        #endregion
    }
    public class TabOrderContainer
    {
        private List<Control> _controls = new List<Control>();
        private Func<BaseForm, Control> _condition;

        public Func<BaseForm, Control> Condition { get => _condition; }
        public List<Control> Controls { get => _controls; }

        public TabOrderContainer Add(Control control)
        {
            _controls.Add(control);
            return this;
        }
        public TabOrderContainer UseCondition(Func<BaseForm, Control> func)
        {
            _condition = func;
            return this;
        }
    }
}
