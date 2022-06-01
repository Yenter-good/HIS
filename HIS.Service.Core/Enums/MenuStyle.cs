using System.ComponentModel;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 菜单打开样式
    /// </summary>
    public enum MenuStyle
    {
        /// <summary>
        /// 选项卡
        /// </summary>
        /// 
        [Description("选项卡")]
        Tab = 0
        ,
        /// <summary>
        /// 对话框
        /// </summary>
        [Description("对话框")]
        Dialog = 1
        ,
        /// <summary>
        /// 窗口
        /// </summary>
        [Description("窗口")]
        Window = 2
            ,
        /// <summary>
        /// 方法
        /// </summary>
        [Description("方法")]
        Method = 3
    }
}
