using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Sys.Advice
{
    public partial class FormAdviceEdit : BaseDialogForm
    {

        private ISysDictQueryService _sysDicDetailService;
        private IAdviceService _adviceService;

        public string _editModel = "add";
        public AdviceEntity _entity = null;
        public AdviceType _adviceType = AdviceType.检查;


        public FormAdviceEdit()
        {
            InitializeComponent();
            this._sysDicDetailService = HIS.Core.ServiceLocator.GetService<ISysDictQueryService>();
            this._adviceService = HIS.Core.ServiceLocator.GetService<IAdviceService>();

        }
        private void FormAdviceEdit_Load(object sender, EventArgs e)
        {

            cbxAdviceType.DataSource = new BindingSource(this.GetEnumDictEx<AdviceType>(), null);//医嘱类型
            cbxAdviceType.ValueMember = "Key";
            cbxAdviceType.DisplayMember = "Value";
            cbxAdviceType.SelectedValue = (int)_adviceType;

            List<LongItem> bblxList = _sysDicDetailService.GetSample();//标本类型
            bblxList.Insert(0, new LongItem(-1,"--请选择--"));
            cbxSampleId.DataSource = bblxList;
            cbxSampleId.ValueMember = nameof(SysDicDetailEntity.Id);
            cbxSampleId.DisplayMember = nameof(SysDicDetailEntity.Value);
            cbxSampleId.FilterFields = new string[] { nameof(SysDicDetailEntity.Value) };

            List<LongItem> sglxList = _sysDicDetailService.GetBuret();//试管类型
            sglxList.Insert(0, new LongItem(-1, "--请选择--"));
            cbxBuretId.DataSource = sglxList;
            cbxBuretId.ValueMember = nameof(SysDicDetailEntity.Id); 
            cbxBuretId.DisplayMember = nameof(SysDicDetailEntity.Value);
            cbxBuretId.FilterFields = new string[] { nameof(DeptEntity.Name), nameof(DeptEntity.SearchCode) };
            cbxBuretId.FilterFields = new string[] { nameof(SysDicDetailEntity.Value) };

            List<LongItem> jcbwlxList = _sysDicDetailService.GetPart();//检查部位
            jcbwlxList.Insert(0, new LongItem(-1, "--请选择--"));
            cbxPartId.DataSource = jcbwlxList;
            cbxPartId.ValueMember = nameof(SysDicDetailEntity.Id);
            cbxPartId.DisplayMember = nameof(SysDicDetailEntity.Value);
            cbxPartId.FilterFields = new string[] { nameof(SysDicDetailEntity.Value) };

            List<LongItem> sblxList = _sysDicDetailService.GetModality();//设备类型
            sblxList.Insert(0, new LongItem(-1, "--请选择--"));
            cbxModalityId.DataSource = sblxList;
            cbxModalityId.ValueMember = nameof(SysDicDetailEntity.Id);
            cbxModalityId.DisplayMember = nameof(SysDicDetailEntity.Value);
            cbxModalityId.FilterFields = new string[] { nameof(SysDicDetailEntity.Value) };

            if (_editModel != "add")
            {
                swbContinuous.Visible = false;//隐藏连续新增 按钮
                lblContinuous.Visible = false;
                SetControlValue();//编辑的状态下 将实体赋值到控件上
            }
            else
            {
                string code = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                this.tbxCode.Text = code;
            }

        }

        //清空界面
        private void ClearControlValue()
        {
            this.tbxName.Text = "";
            this.tbxSearchCode.Text = "";
            this.swbMZEnable.Value = true;
            this.swbZYEnable.Value = true;
            this.swbSSEnable.Value = true;
            this.swbYJEnable.Value = true;
            this.cbxSampleId.SelectedItem = null;
            this.cbxBuretId.SelectedItem = null;
            this.cbxPartId.SelectedItem = null;
            this.cbxModalityId.SelectedItem = null;
            this.cbxAdviceType.SelectedValue = (int)_adviceType;
        }

        private void SetControlValue()
        {
            if (_entity == null) return;
            this.tbxName.Text = _entity.Name;
            this.tbxCode.Text = _entity.Code;
            this.tbxCode.ReadOnly = true;
            this.tbxSearchCode.Text = _entity.SearchCode;
            this.swbMZEnable.Value = _entity.OFlag;
            this.swbZYEnable.Value = _entity.IFlag;
            this.swbSSEnable.Value = _entity.SFlag;
            this.swbYJEnable.Value = _entity.MFlag;
            this.cbxSampleId.SelectedItem = _entity.Sample ;
            this.cbxBuretId.SelectedItem = _entity.Buret;
            this.cbxPartId.SelectedItem = _entity.Part;
            this.cbxModalityId.SelectedItem = _entity.Modality;
            this.cbxAdviceType.SelectedValue = (int)_entity.Type;
        }

        //重写OnOK 进行保存操作   
        protected override void OnOK()
        {
            if (tbxName.Text == "")
            {
                this.tbxName.Focus();
                this.tbxName.ShowTips("请输入医嘱名称");
                return;
            }
           
            _entity = _entity == null ? new AdviceEntity() : _entity;
            _entity.Code = tbxCode.Text;
            _entity.Name = tbxName.Text;
            _entity.SearchCode = tbxSearchCode.Text;

            _entity.OFlag = this.swbMZEnable.Value;
            _entity.IFlag = this.swbMZEnable.Value;
            _entity.SFlag = this.swbSSEnable.Value;
            _entity.MFlag = this.swbYJEnable.Value;


            _entity.Type = _adviceType;

            if (this.cbxSampleId.SelectedItem != null)
            {
                _entity.Sample = this.cbxSampleId.SelectedItem as LongItem;
            }
            if (this.cbxBuretId.SelectedItem != null)
            {
                _entity.Buret = this.cbxBuretId.SelectedItem as LongItem;
            }
            if (this.cbxPartId.SelectedItem != null)
            {
                _entity.Part = this.cbxPartId.SelectedItem as LongItem;
            }
            if (this.cbxModalityId.SelectedItem != null)
            {
                _entity.Modality = this.cbxModalityId.SelectedItem as LongItem;
            }

            if (_editModel == "add")
            {
                var result = this._adviceService.InsertAdvice(_entity);
                if (result.Success)
                {
                    AlertBox.Info("新增成功");
                    if (this.swbContinuous.Value)//如果连续新增 启用 则清空界面继续录入
                    {
                        this.ClearControlValue();
                        this.tbxName.Focus();
                        return;
                    }
                    else
                        base.Close();
                }
            }
            else {
                var result = this._adviceService.UpdateAdvice(_entity.Id, _entity);
                if (result.Success)
                {
                    AlertBox.Info("更新成功");
                    base.Close();
                }
            }

        }
      

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            tbxSearchCode.Text = SpellHelper.GetSpells(tbxName.Text);
        }
    }
}
