using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Entities.Drug;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Sys.Drug
{
    public partial class FormTakeStockDetails : BaseDialogForm
    {

        private readonly IWarehouspitalTakeStockService _takeStockService;
        private readonly IPharmacyTakeStockService _smallStockService;

        public TakeStockEntity entity = null;
        public string editModel = "add";
        public int _type = 0;// 0药库盘点   1药房盘点
        public FormTakeStockDetails()
        {
            InitializeComponent();
            this._takeStockService = HIS.Core.ServiceLocator.GetService<IWarehouspitalTakeStockService>();
            this._smallStockService = HIS.Core.ServiceLocator.GetService<IPharmacyTakeStockService>();
        }

        private void FormTakeStockDetails_Load(object sender, EventArgs e)
        {

            dgvDetail.AutoGenerateColumns = false; //去除自动绑定列
            dgvDetail.AllowUserToAddRows = false;  //去除空白行
           
            if (entity == null) {
                AlertBox.Error("数据有误，请联系管理员");
                this.Close();
                return;
            }
            if (entity.AuditStatus == 0)//新增时 可编辑 审核后的详情不可编辑
            {
                this.colQuantity_wpd.ReadOnly = false;
                this.colQuantity_ppd.ReadOnly = false;

                this.groupBox1.Visible = false;

            }
            else
            {
                this.colQuantity_wpd.ReadOnly = true;
                this.colQuantity_ppd.ReadOnly = true;

                this.tbxBegin.Text = entity.BeginAmount.ToString();
                this.tbxEnd.Text = entity.EndAmount.ToString();
            }


            if (_type == 0)
            {
                this.colQuantity_ppd.Visible = false;
                this.colCurrentSmallQuantity_wpd.Visible = false;
            }
            else
            {
                this.colQuantity_wpd.HeaderText = "实盘数";
                this.colCurrentBigQuantity_wpd.HeaderText = "盘点前数量";
            }

            LoadData();
        }

        private void LoadData()
        {
            List<TakeStockDetailEntity> list = null;
            if (_type == 0)
            {
                list = _takeStockService.GetByTakeStockId(entity.Id);
            }
            else
            {
                list = _smallStockService.GetByTakeStockId(entity.Id);
            }
            this.dgvDetail.DataSource = list;
        }

        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TakeStockDetailEntity entity = dgvDetail.CurrentRow.DataBoundItem as TakeStockDetailEntity;
            DataResult<TakeStockDetailEntity> result = null;
            if (entity.ActualBigQuantity < 1) return;
            if (_type == 0)
            {
                result = _takeStockService.UpdateDetailQuantity(entity.Id, entity.ActualBigQuantity);
            }
            else
            {
                result = _smallStockService.UpdateDetailQuantity(entity.Id, entity.ActualBigQuantity,entity.ActualSmallQuantity);
            }
                
            if (!result.Success)
                AlertBox.Error(result.Message);
        }

        private void dgvDetail_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
        
        private void dgvDetail_SpecialKeyDown(object sender, KeyEventArgs e)
        {
            int rowIndex = dgvDetail.CurrentRow.Index;

            if (e.KeyCode == Keys.Down)
            {
                if (dgvDetail.CurrentRow.Index >= dgvDetail.Rows.Count - 1) return;

                dgvDetail.BeginEdit(false);

               
                dgvDetail.CurrentCell = this.dgvDetail.Rows[rowIndex + 1].Cells["colQuantity_wpd"];
                dgvDetail.BeginEdit(true);
            }
            if (e.KeyCode == Keys.Up)
            {
                if (dgvDetail.CurrentRow.Index == 0) return;

                dgvDetail.BeginEdit(false);
                dgvDetail.CurrentCell = this.dgvDetail.Rows[rowIndex - 1].Cells["colQuantity_wpd"];
                dgvDetail.BeginEdit(true);
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (dgvDetail.CurrentRow.Index >= dgvDetail.Rows.Count - 1) return;

                dgvDetail.BeginEdit(false);

                if (_type == 0)//药库盘点 只有一个Cell 要控制
                {
                    dgvDetail.CurrentCell = this.dgvDetail.Rows[rowIndex + 1].Cells["colQuantity_wpd"];
                }
                else //药房盘点 有两个Cell 要控制  如果是在第一个Cell 则 定位到下个个 Cell   否则 定位到下一行
                {
                    if (dgvDetail.CurrentCell == this.dgvDetail.Rows[rowIndex].Cells["colQuantity_wpd"])
                    {
                        dgvDetail.CurrentCell = this.dgvDetail.Rows[rowIndex].Cells["colQuantity_ppd"];//小包装实盘数 Cell
                    }
                    else
                    {
                        dgvDetail.CurrentCell = this.dgvDetail.Rows[rowIndex + 1].Cells["colQuantity_wpd"];//大包装实盘数Cell
                    }

                }
                

                dgvDetail.BeginEdit(true);
            }


           
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                List<TakeStockDetailEntity> subList = null;
                string searchStr = tbxSearch.Text.Trim();

                if (_type == 0)
                {
                    subList = _takeStockService.GetBySearchStr(entity.Id, searchStr);
                }
                else
                {
                    subList = _smallStockService.GetBySearchStr(entity.Id, searchStr);
                }
                 
                dgvDetail.DataSource = subList;
            }
        }
    }
}
