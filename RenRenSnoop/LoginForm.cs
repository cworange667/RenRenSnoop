using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenRenSnoop
{
    public partial class LoginForm : Form
    {
        private string _giveBackCode;
        private OAuth _oauth;
        public LoginForm(OAuth oauth)
        {
            InitializeComponent();
            this._oauth = oauth;
            _giveBackCode = string.Empty;
            string authorizeUrl = "https://graph.renren.com/oauth/authorize?client_id=" + Program.appKey
                + "&response_type=code&redirect_uri=" + Program.callBackUrl
                + "&scope=read_user_blog+read_user_feed+read_user_guestbook+read_user_like_history+read_user_notification"
                + "+read_user_photo+read_user_status+read_user_album+read_user_comment+read_user_share+read_user_request&display=page";
            loginArea.Navigate(authorizeUrl);

            loginArea.DocumentCompleted += loginArea_DocumentCompleted;
        }
               //publish_blog	 以用户身份发布日志时需要用户授予的权限。
        //publish_checkin	 以用户身份发布报到时需要用户授予的权限。
        //publish_feed	 以用户身份发送新鲜事时需要用户授予的权限。
        //publish_share	 以用户身份发送分享时需要用户授予的权限。。
        //write_guestbook	 以用户身份进行留言时需要用户授予的权限。
        //send_invitation	 以用户身份发送邀请时需要用户授予的权限。
        //send_request	 以用户身份发送好友申请、圈人请求等时需要用户授予的权限。
        //send_message	 以用户身份发送站内信时需要用户授予的权限。
        //send_notification	 以用户身份发送通知（user_to_user）时需要用户授予的权限。
        //photo_upload	 以用户身份上传照片时需要用户授予的权限。
        //status_update	 以用户身份发布状态时需要用户授予的权限。
        //create_album	 以用户身份发布相册时需要用户授予的权限。
        //publish_comment	 以用户身份发布评论时需要用户授予的权限。
        //operate_like	 以用户身份执行喜欢操作时需要用户授予的权限。

        //read_user_blog	 获取用户日志时需要用户授予的权限。
        //read_user_checkin	 获取用户报到信息时需要用户授予的权限。
        //read_user_feed	 获取用户新鲜事时需要用户授予的权限。
        //read_user_guestbook	 获取用户留言板时需要用户授予的权限。
        //read_user_invitation	 获取用户被邀请的状况时需要用户授予的权限。
        //read_user_like_history	 获取用户喜欢的历史信息时需要用户授予的权限。
        //read_user_message	 获取用户站内信时需要用户授予的权限。
        //read_user_notification	 获取用户已收到的通知时需要用户授予的权限。
        //read_user_photo	 获取用户相册相关信息时需要用户授予的权限。
        //read_user_status	 获取用户状态相关信息时需要用户授予的权限。
        //read_user_album	 获取用户相册相关信息时需要用户授予的权限。
        //read_user_comment	 获取用户评论相关信息时需要用户授予的权限。
        //read_user_share	 获取用户分享相关信息时需要用户授予的权限。
        //read_user_request	 获取用户好友请求、圈人请求等信息时需要用户授予的权限。
        void loginArea_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = loginArea.Url.ToString();
            int index = url.IndexOf("code=");
            if (index > 0)
            {
                _giveBackCode = url.Substring(index + 5);
                _oauth.SetAccessTokenByAuthorizationCode(_giveBackCode);
                if (_oauth.ReadAccessToken() != null)
                {
                    Properties.Settings.Default.AcessToken = _oauth.ReadAccessToken();
                    Properties.Settings.Default.Save();
                    this.Close();
                }
            }
            //else
            //{
            //    HtmlElement id = loginArea.Document.GetElementById("rrid");
            //    HtmlElement pwd = loginArea.Document.GetElementById("rrpw");
            //    HtmlElement submit = loginArea.Document.GetElementById("submit");
            //    id.InnerText = "";
            //    pwd.InnerText = "";
            //    submit.InvokeMember("click");
            //}
        }
    }
}
