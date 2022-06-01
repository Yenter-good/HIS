using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core.Entities;

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 子模板
    /// </summary>
    internal partial class UCSubTemplate : UCBaseSubTemplateSampleTree
    {
        public UCSubTemplate()
        {
            InitializeComponent();
        }

        internal override void Init()
        {
            this.InitData();
            this.InitUI();
        }
        private void advTree_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.CurrentSelectedSubTemplateSample != null)
                {
                    this.advTree.DoDragDrop(new DataObject(nameof(SubTemplateSampleEntity),
                        this.CurrentSelectedSubTemplateSample.Content),
                        DragDropEffects.Move);
                }
            }
        }
    }
}
