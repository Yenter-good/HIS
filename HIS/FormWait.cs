//              _ooOoo_                   
//             o8888888o                  
//            88\" . \"88                  
//             (| -_- |)                  
//            O\\  =  /O                  
//          ____/`---'\\____               
//        .'  \\|     |//  `.             
//       /  \\\\|||  :  |||//  \\            
//      /  _||||| -:- |||||-  \\           
//     |   | \\\\\\  -  /// |   |           
//     | \\_|  ''\\---/''  |   |           
//     \\  .-\\__  `-`  ___/-. /           
//    ___`. .'  /--.--\\  `. . __          
//   .\"\" '<  `.___\\_<|>_/___.'  >'\"\".       
//| | :  `- \\`.;`\\ _ /`;.`/ - ` : | |     
//\\  \\ `-.   \\_ __\\ /__ _/   .-` /  /     
//======`-.____`-.___\\_____/___.-`____.-'======
//                   `=---='                   
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
//佛祖保佑                永无BUG
//佛曰：
//写字楼里写字间，写字间里程序员；
//程序人员写程序，又拿程序换酒钱。
//酒醒只在网上坐，酒醉还来网下眠；
//酒醉酒醒日复日，网上网下年复年。
//但愿老死电脑间，不愿鞠躬老板前；
//奔驰宝马贵者趣，公交自行程序员。
//别人笑我减疯癫，我笑自己命太贱；
//不见满街漂亮妹，哪个归得程序员？


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Core;
using HIS.Core.UI;

/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-29 09:16:10
/// 功能:
/// </summary>
namespace HIS
{
    public partial class FormWait : Form
    {
        public FormWait()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.picSlider.Left >= this.pnlProgress.Width)
                this.picSlider.Left = 0;
            this.picSlider.Left += 10;
        }

        private void UpdateSystem()
        {
            try
            {
                Process process = Process.Start(Directory.GetParent(Application.StartupPath) + "\\Client.exe", "HIS HIS.exe " + Process.GetCurrentProcess().ProcessName + " " + Application.StartupPath);
                while (!process.HasExited)
                {
                    Application.DoEvents();
                }
            }
            catch
            {
            }

        }

        private void Init()
        {
            UpdateSystem();
            App.Instance.InitializeService();
        }

        private void ac(IAsyncResult result)
        {
            var action = result.AsyncState as Action;
            this.Invoke((MethodInvoker)delegate
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            });
        }

        private void FormWait_Shown(object sender, EventArgs e)
        {
            var action = new Action(Init);
            action.BeginInvoke(ac, null);
        }
    }
}
