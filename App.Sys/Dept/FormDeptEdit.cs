using HIS.Core.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Core;
using DevComponents.AdvTree;

namespace App_Sys.Dept
{
    public partial class FormDeptEdit : BaseDialogForm
    {
        private readonly ISysDictQueryService _dicQueryService;
        private readonly IDeptService _deptService;

        public FormDeptEdit(ISysDictQueryService dicQueryService, IDeptService deptService)
        {
            InitializeComponent();
            this._dicQueryService = dicQueryService;
            this._deptService = deptService;
        }

        private void FormDeptEdit_AfterCellEdit(object sender, CellEditEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 选中的科室
        /// </summary>
        public DeptEntity SelectedDept { private get; set; }
        /// <summary>
        /// 所有科室
        /// </summary>
        public List<DeptEntity> AllDept { private get; set; }
        /// <summary>
        /// 操作方式
        /// </summary>
        public DataOperation Operation { get; set; }
        /// <summary>
        /// 增加新的科室
        /// </summary>
        public event EventHandler<DeptEntity> NewDept;

        private void InitData()
        {
            var deptCategory = _dicQueryService.GetDeptCategories();
            this.cbxCategory.DisplayMember = nameof(ItemEntity.Value);
            this.cbxCategory.ValueMember = nameof(ItemEntity.Id);
            this.cbxCategory.DataSource = deptCategory;

            var deptCategoryDetail = this.GetEnumDictEx<DeptCategoryDetail>();
            this.cbxCategoryDetail.DisplayMember = "Value";
            this.cbxCategoryDetail.ValueMember = "Key";
            this.cbxCategoryDetail.DataSource = new BindingSource(deptCategoryDetail, null);

            var entry = AllDept.Select(p => new HIS.ControlLib.DataEntry(p.Id, p.Parent.Id, p.Name, p.SearchCode, p.Name)).ToList();
            this.ftParentDept.DataSource = entry;
        }

        private void InitUI()
        {
            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.tbxAliasName);
            this.AddTabOrderContainer(this.cbxCategory);
            this.AddTabOrderContainer(this.ftParentDept);
            this.AddTabOrderContainer(this.tbxLocation);
            this.EnabledEnterNext = true;

            List<DeptEntity> parentDept;
            if (Operation == DataOperation.Modify)
            {
                List<long> ids = new List<long>();
                new DeptManagerHelper().GetChildIds(AllDept, SelectedDept.Id, ref ids);
                ids.Add(SelectedDept.Id);
                parentDept = AllDept.Where(p => p.Id._NotIn(ids)).ToList();
            }
            else
                parentDept = AllDept;

            if (Operation == DataOperation.Modify)
            {
                this.tbxName.Text = SelectedDept.Name;
                this.tbxCode.Text = SelectedDept.Code;
                this.tbxAliasName.Text = SelectedDept.AliasName;
                this.tbxLocation.Text = SelectedDept.Location;
                this.cbxCategory.SelectedValue = SelectedDept.Category.Id;
                this.ftParentDept.SelectedValue = SelectedDept.Parent.Id;
                this.tbxCode.ReadOnly = true;
            }
            else
            {
                this.lbContinuousInput.Show();
                this.swContinuousInput.Show();
            }

        }

        private void FormDeptEdit_Shown(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);
            InitData();
            InitUI();
            HIS.DSkinControl.QLoading.Close(this);
        }

        private bool Valid()
        {
            if (this.tbxName.Text == "")
            {
                MsgBox.OK("科室名称不能为空");
                return false;
            }
            if (this.cbxCategory.SelectedItem == null)
            {
                MsgBox.OK("科室类型不能为空");
                return false;
            }

            return true;
        }

        protected override void OnOK()
        {
            if (!Valid())
                return;

            if (SelectedDept == null)
                SelectedDept = new DeptEntity();
            SelectedDept.Name = this.tbxName.Text;
            SelectedDept.SearchCode = this.SelectedDept.Name.GetSpell();
            SelectedDept.AliasName = this.tbxAliasName.Text;
            SelectedDept.Category = this.cbxCategory.SelectedItem as ItemEntity;
            SelectedDept.CategoryDetail = (DeptCategoryDetail)this.cbxCategoryDetail.SelectedValue.AsInt(0);
            SelectedDept.Location = this.tbxLocation.Text;
            SelectedDept.Parent = AllDept.Find(p => p.Id == this.ftParentDept.SelectedEntry?.Id);

            if (Operation == DataOperation.Modify)
            {


                var result = _deptService.UpdateDept(SelectedDept);
                if (result.Success)
                {
                    AlertBox.Info("修改成功");
                    base.OnOK();
                }
                else
                    MsgBox.OK("修改失败" + Environment.NewLine + result.Message);
            }
            else
            {
                SelectedDept.Code = this.tbxCode.Text;

                var exist = _deptService.ExistCode(this.tbxCode.Text);
                if (exist)
                {
                    MsgBox.OK("科室编号已经存在");
                    return;
                }

                var result = _deptService.AddDept(SelectedDept);
                if (result.Success)
                {
                    AlertBox.Info("增加成功");
                    NewDept?.Invoke(this, SelectedDept);
                    if (!swContinuousInput.Value)
                        base.OnOK();
                }
                else
                    MsgBox.OK("增加失败" + Environment.NewLine + result.Message);
            }
        }

      
    }
}
