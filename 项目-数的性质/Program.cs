using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 项目_数的性质
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
/*            System.Media.SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"Music\\Rick.wav"; //音乐文件
            sp.PlayLooping();*/
        }
    }
}
