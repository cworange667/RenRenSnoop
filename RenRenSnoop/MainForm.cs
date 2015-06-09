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
    public partial class MainForm : Form
    {
        private string _targetID;
        private OAuth _oauth;
        private UserInfoResponse _ui;
        private List<UserInfo> friendList;
        private TargetUserDetail _detailForm;
        public MainForm(OAuth oauth)
        {
            InitializeComponent();
            this._oauth = oauth;
            RefreshUserInfo();
            _targetID = string.Empty;
            _ui = null;
        }
        private void RefreshUserInfo()
        {
            userAvatar.ImageLocation = _oauth.userInfo.response.avatar[3].url;
            if (_oauth.userInfo.response.basicInformation.homeTown != null)
                userProvince.Text = _oauth.userInfo.response.basicInformation.homeTown.province;
            if (_oauth.userInfo.response.basicInformation.homeTown != null)
                userCity.Text = _oauth.userInfo.response.basicInformation.homeTown.city;
            userName.Text = _oauth.userInfo.response.name;
            if (_oauth.userInfo.response.education.Length != 0)
                userSchool.Text = _oauth.userInfo.response.education[0].name;
        }

        private void searchtBox_TextChanged(object sender, EventArgs e)
        {
            _targetID = this.searchtBox.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _ui = _oauth.OtherUserGet(_targetID);
            if (_ui == null)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("ID不合法或没有该用户。", "错误", messButton);
            }
            else
            {
                targetUserAvatar.ImageLocation = _ui.response.avatar[0].url;
                targetUserName.Text = _ui.response.name;
                Label hint = new Label();
                hint.AutoSize = true;
                hint.Text = "点击头像查看该用户。";
                hint.Location = new Point(100, 220);
                this.Controls.Add(hint);
            }
        }

        private void TargetUserName_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void targetUserAvatar_Click(object sender, EventArgs e)
        {
            if (_ui != null)
            {
                if (_detailForm != null)
                    _detailForm.Close();
                _detailForm = new TargetUserDetail(_oauth, _targetID);
    //            _detailForm.TopLevel = false;
                _detailForm.Dock = DockStyle.Fill;
      //          _detailForm.FormBorderStyle = FormBorderStyle.None;
    //            _detailForm.Parent = targetUserArea;
                _detailForm.Show();
            }
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void targetUserArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
