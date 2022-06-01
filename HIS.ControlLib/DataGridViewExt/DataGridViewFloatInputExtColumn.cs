using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.ControlLib
{
    public class DataGridViewFloatInputExtColumn : DataGridViewTextBoxExtColumn
    {
        /// <summary>
        /// 小数位数
        /// </summary>
        public int Digits { get; set; }
        /// <summary>
        /// 超过位数是否四舍五入
        /// </summary>
        public bool Round { get; set; }
    }
}
