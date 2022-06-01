using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.ControlLib
{
    public class DataGridViewIntegerInputExtColumn : DataGridViewTextBoxExtColumn
    {
        public int MinValue { get; set; } = int.MinValue;
        public int MaxValue { get; set; } = int.MaxValue;
    }
}
