using HIS.Core;
using HIS.Core.UI;
using HIS.DSkinControl;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.ControlLib;
using HIS.Service.Core;

namespace App_Sys.Dic
{
    public partial class FormAdviceCategoryEdit : BaseDialogForm
    {
        private readonly IAdviceService _adviceService;

        public FormAdviceCategoryEdit(IAdviceService adviceService)
        {
            InitializeComponent();
            this._adviceService = adviceService;
        }

        /// <summary>
        /// 所有分类
        /// </summary>
        public List<AdviceCategoryEntity> AllAdviceCategories { get; set; }
        /// <summary>
        /// 当前选中的分类
        /// </summary>
        public AdviceCategoryEntity SelectedCategory { get; set; }
        /// <summary>
        /// 所有科室
        /// </summary>
        public List<DeptEntity> AllDepts { get; set; }
        /// <summary>
        /// 操作方式
        /// </summary>
        public DataOperation Operation { get; set; }
        /// <summary>
        /// 分类类型
        /// </summary>
        public AdviceCategoryType CategoryType { get; set; }

        public event EventHandler<AdviceCategoryEntity> NewCategory;

        private void InitUI()
        {
            List<DataEntry> parentCategory;

            var deptEntries = AllDepts.Select(p => new DataEntry(p.Id, p.Parent.Id, p.Name, p.SearchCode, p.Name)).ToList();
            this.ftDept.DataSource = deptEntries;

            if (Operation == DataOperation.Modify)
            {
                List<long> childIds = new List<long>();
                new CategoryManagerHelper().GetChildIds(AllAdviceCategories, SelectedCategory.Id, ref childIds);
                childIds.Add(SelectedCategory.Id);
                parentCategory = AllAdviceCategories.Where(p => p.Id._NotIn(childIds)).Select(p => new DataEntry(p.Id, p.Parent.Id, p.Name, p.SearchCode, p.Name)).ToList();

                this.tbxName.Text = SelectedCategory.Name;
                this.ftParentCategory.DataSource = parentCategory;

                this.ftParentCategory.SelectedValue = SelectedCategory.Parent.Id;
                if (SelectedCategory.Dept != null)
                    this.ftDept.SelectedValue = SelectedCategory.Dept.Id;
            }
            else if (Operation == DataOperation.New)
            {
                this.lbContinuousInput.Show();
                this.swContinuousInput.Show();

                parentCategory = AllAdviceCategories.Select(p => new DataEntry(p.Id, p.Parent.Id, p.Name, p.SearchCode, p.Name)).ToList();
                this.ftParentCategory.DataSource = parentCategory;
            }
        }

        private void FormAdviceCategoryEdit_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                InitUI();
            });
        }

        protected override void OnOK()
        {
            if (Operation == DataOperation.Modify)
            {
                SelectedCategory.Name = this.tbxName.Text;
                SelectedCategory.Parent = AllAdviceCategories.Find(p => p.Id == this.ftParentCategory.SelectedEntry?.Id);
                SelectedCategory.Dept = AllDepts.Find(p => p.Id == this.ftDept.SelectedEntry?.Id);

                var result = _adviceService.UpdateAdviceCategory(SelectedCategory);
                if (result.Success)
                    AlertBox.Info("修改成功");
                else
                    MsgBox.OK("修改失败" + Environment.NewLine + result.Message);

                base.OnOK();
            }
            else if (Operation == DataOperation.New)
            {
                SelectedCategory = new AdviceCategoryEntity();
                SelectedCategory.Name = this.tbxName.Text;
                SelectedCategory.Parent = AllAdviceCategories.Find(p => p.Id == this.ftParentCategory.SelectedEntry?.Id) ?? new AdviceCategoryEntity() { Id = 0 };
                SelectedCategory.Dept = AllDepts.Find(p => p.Id == this.ftDept.SelectedEntry?.Id);
                SelectedCategory.CategoryType = CategoryType;

                var result = _adviceService.AddAdviceCategory(SelectedCategory);
                if (result.Success)
                {
                    AlertBox.Info("增加成功");
                    if (this.swContinuousInput.Value)
                    {
                        NewCategory?.Invoke(this, SelectedCategory);
                        InitUI();
                    }
                    else
                        base.OnOK();
                }
                else
                    MsgBox.OK("增加失败" + Environment.NewLine + result.Message);
            }
        }
    }
}
