using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP.MedicalRecord
{
    public partial class UCSubTemplateSampleWrite : UCBaseTemplateWrite
    {
        public UCSubTemplateSampleWrite()
        {
            InitializeComponent();
            this.Enabled = false;
            this.cWriter.SetZoomRate(1.25f);
            this.cWriter.DocumentContentChanged += (x, y) => { this.btnSave.Enabled = true; };
            this.cWriter.ContextMenuStrip = null;
        }
    }
}
