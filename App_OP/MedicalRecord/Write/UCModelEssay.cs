using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.AdvTree;
using HIS.Service.Core.Entities;

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 范文
    /// </summary>
    internal partial class UCModelEssay : UCBaseTemplateSampleTree
    {
        /// <summary>
        /// 插入范文事件
        /// </summary>
        internal event EventHandler<string> InsertTemplateSample;
        public UCModelEssay()
        {
            InitializeComponent();
        }
        internal override void Init()
        {
            this.InitData();
            this.InitUI();
        }
        private void advTree_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            this.InsertTemplateSample?.Invoke(this, this.CurrentSelectedTemplateSample.Content);
        }
        private void advTree_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.CurrentSelectedTemplateSample != null)
                {
                    this.advTree.DoDragDrop(new DataObject(nameof(TemplateSampleEntity),
                        this.CurrentSelectedTemplateSample.Content),
                        DragDropEffects.Move);
                }
            }
        }
    }
}
