using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.UI
{
    /// <summary>
    /// 子窗体视图
    /// 注意继承此接口的将无法设置为菜单 
    /// </summary>
    public interface IChildViewContent
    {
        IViewContent ParentView { get; set; }
    }
}
