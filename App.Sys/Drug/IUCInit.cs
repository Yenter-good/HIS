using HIS.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Sys.Drug
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-13 17:02:15
    /// 描述:
    /// </summary>
    internal interface IUCInit
    {
        ViewData ViewData { get; set; }
        void Init();
    }
}
