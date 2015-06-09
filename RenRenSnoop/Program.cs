using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenRenSnoop
{
    static class Program
    {
        static public string appKey = Properties.Settings.Default.AppKey;
        static public string appSecret = Properties.Settings.Default.AppSecrect;
        static public string callBackUrl = Properties.Settings.Default.CallbackUrl;
        static public string accessToken = Properties.Settings.Default.AcessToken;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
//            OAuth oauth = new OAuth(appKey, appSecret, callBackUrl);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            callBackUrl = Properties.Settings.Default.CallbackUrl;
            accessToken = Properties.Settings.Default.AcessToken;
            OAuth oauth = new OAuth(appKey, appSecret, callBackUrl);
            if (string.IsNullOrEmpty(accessToken))	//判断配置文件中有没有保存到AccessToken，如果没有就进入授权流程
            {
                Application.Run(new LoginForm(oauth));
            }
            else
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("是否使用上次保存账号登录?", "AccessToken", messButton);
                if (dr != DialogResult.OK)
                {
                    Properties.Settings.Default.AcessToken = string.Empty;
                    Properties.Settings.Default.Save();
                    Application.Run(new LoginForm(oauth));
                }
                else
                    oauth.SetAccessToken(accessToken);
            }
            oauth.UserGet();
            if (oauth.ReadAccessToken() != null)
            {
                Application.Run(new MainForm(oauth));
                Application.Run(new LogoutForm());
            }
        }
    }
}
