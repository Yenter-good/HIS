using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;

namespace App_Sys
{
    /// <summary>
    /// 流水号编辑
    /// </summary>
    public partial class FormSerialNumberEdit : BaseDialogForm
    {
        /// <summary>
        /// 数据操作类型
        /// </summary>
        public DataOperation dataOperation { private get; set; }
        /// <summary>
        /// 流水号服务
        /// </summary>
        private readonly IInvoiceService _invoiceService;
        /// <summary>
        /// 当前选中的流水号
        /// </summary>
        public SerialNumberEntity SelectedSerialNumber { private get; set; }
        /// <summary>
        /// 添加事件
        /// </summary>
        public event EventHandler<SerialNumberEntity> NewSerialNumber;

        public FormSerialNumberEdit(IInvoiceService invoiceService)
        {
            InitializeComponent();

            this._invoiceService = invoiceService;
        }

        private void FormSerialNumberEdit_Shown(object sender, EventArgs e)
        {

            //初始化类型
            Dictionary<int, string> dicInvoiceType = typeof(InvoiceType).EnumToDictEx<InvoiceType, int>();
            BindingSource bs = new BindingSource();
            bs.DataSource = dicInvoiceType;
            this.cbxType.DisplayMember = "Value";
            this.cbxType.ValueMember = "Key";
            this.cbxType.DataSource = bs;
            this.cbxType.DropDownStyle = ComboBoxStyle.DropDownList;

            //初始化中间格式
            Dictionary<int, string> dicMiddleFormat = typeof(MiddleFormat).EnumToDictEx<MiddleFormat, int>();
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dicMiddleFormat;
            this.cbxMiddleFormat.DisplayMember = "Value";
            this.cbxMiddleFormat.ValueMember = "Key";
            this.cbxMiddleFormat.DataSource = bs1;
            this.cbxMiddleFormat.DropDownStyle = ComboBoxStyle.DropDownList;

            //初始化变化类型
            Dictionary<int, string> dicChangeType = typeof(ChangeType).EnumToDictEx<ChangeType, int>();
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = dicChangeType;
            this.cbxChangeType.DisplayMember = "Value";
            this.cbxChangeType.ValueMember = "Key";
            this.cbxChangeType.DataSource = bs2;
            this.cbxChangeType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxChangeType.Enabled = false;

            if (this.dataOperation == DataOperation.Modify)
            {
                //控件赋值
                this.cbxType.SelectedValue = (int)this.SelectedSerialNumber.Type;
                this.cbxType.Enabled = false;
                this.intTotalLen.Value = this.SelectedSerialNumber.TotalLength;
                this.tbxStartPrefix.Text = this.SelectedSerialNumber.StartPrefix;
                this.cbxMiddleFormat.SelectedValue = (int)this.SelectedSerialNumber.MiddleFormat;
                this.cbxChangeType.SelectedValue = (int)this.SelectedSerialNumber.ChangeType;
                this.swbCacheFlag.Value = this.SelectedSerialNumber.CacheFlag;
            }

            //注册事件
            this.cbxMiddleFormat.SelectedIndexChanged += (x, y) =>
            {
                //变化类型由系统控制
                switch ((MiddleFormat)Convert.ToInt32(this.cbxMiddleFormat.SelectedValue))
                {
                    case MiddleFormat.空:
                        this.cbxChangeType.SelectedValue = (int)ChangeType.一直累加;
                        break;
                    case MiddleFormat.yyMMdd:
                    case MiddleFormat.yyyyMMdd:
                        this.cbxChangeType.SelectedValue = (int)ChangeType.每天初始化;
                        break;
                }
            };
        }

        protected override void OnOK()
        {

            InvoiceType invoiceType = (InvoiceType)Convert.ToInt32(this.cbxType.SelectedValue);
            //判断该类型是否存在
            if (this.dataOperation == DataOperation.New)
            {
                bool exists = this._invoiceService.InvoiceTypeExsist(invoiceType);
                if (exists)
                {
                    this.cbxType.Focus();
                    this.cbxType.ShowTips("此类型已经存在!");
                    return;
                }
            }

            int totalLen = this.intTotalLen.Value;
            if (totalLen == 0)
            {
                this.intTotalLen.Focus();
                this.intTotalLen.ShowTips("请设置流水号的总长度!");
                return;
            }

            string startPrefix = this.tbxStartPrefix.Text.Trim();

            MiddleFormat middleFormat = (MiddleFormat)Convert.ToInt32(this.cbxMiddleFormat.SelectedValue);

            ChangeType changeType = (ChangeType)Convert.ToInt32(this.cbxChangeType.SelectedValue);

            bool cacheFlag = this.swbCacheFlag.Value;

            if (this.dataOperation == DataOperation.New)
            {
                SerialNumberEntity serialNumber = new SerialNumberEntity();
                serialNumber.Type = invoiceType;
                serialNumber.TotalLength = totalLen;
                serialNumber.StartPrefix = startPrefix;
                serialNumber.MiddleFormat = middleFormat;
                serialNumber.ChangeType = changeType;
                serialNumber.CacheFlag = cacheFlag;
                serialNumber.Description = invoiceType.ToString();

                var result = this._invoiceService.Add(serialNumber);
                if (result.Success)
                {
                    HIS.Core.AlertBox.Info("添加成功");
                    this.NewSerialNumber?.Invoke(this, serialNumber);
                    base.OnOK();
                }
                else
                    HIS.Core.MsgBox.OK($"添加失败\r\n{result.Message}");

                return;
            }
            if (this.dataOperation == DataOperation.Modify)
            {
                this.SelectedSerialNumber.TotalLength = totalLen;
                this.SelectedSerialNumber.StartPrefix = startPrefix;
                this.SelectedSerialNumber.MiddleFormat = middleFormat;
                this.SelectedSerialNumber.ChangeType = changeType;
                this.SelectedSerialNumber.CacheFlag = cacheFlag;

                var result = this._invoiceService.Update(this.SelectedSerialNumber);
                if (result.Success)
                {
                    HIS.Core.AlertBox.Info("修改成功");
                    base.OnOK();
                }
                else
                    HIS.Core.MsgBox.OK($"修改失败\r\n{result.Message}");
            }
        }
    }
}
