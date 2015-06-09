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
    public partial class StatusBox : Form
    {
        private StatusListInfoResponse _statusList;
        private string statusMessage = String.Empty;
        private OAuth _oauth;
        private string _targetId;
        int pageNumber;
        private Button _nextPage = new Button();
        public StatusBox(OAuth oauth, string targetId)
        {
            InitializeComponent();
            _oauth = oauth;
            _targetId = targetId;
            pageNumber = 1;
            int buttonPosy = StatusRefresh(pageNumber);
            _nextPage.Text = "更多状态";
            _nextPage.Size = new Size(550, 50);
            _nextPage.TabStop = false;
            _nextPage.Location = new Point(5, buttonPosy);
            _nextPage.Click += _nextPage_Click;
            statusShowArea.Controls.Add(_nextPage);
        }

        void _nextPage_Click(object sender, EventArgs e)
        {
            pageNumber++;
            int buttonPosy = StatusRefresh(pageNumber);
            statusShowArea.Controls.Remove(_nextPage);
            if (_nextPage.Enabled != false)
                _nextPage.Location = new Point(5, buttonPosy);
            statusShowArea.Controls.Add(_nextPage);
        }
        int StatusRefresh(int pageNumber)
        {
            _statusList = _oauth.TargetUserStatusList(_targetId, "20", pageNumber.ToString());
            if (_statusList.response.Length != 0)
            {
                int posy;
                int statusWidth;
                if (pageNumber != 1)
                {
                    posy = 370;
                    statusWidth = 640;
                }
                else
                {
                    posy = 10;
                    statusWidth = 550;
                }
    //            statusWidth = pageNumber * 30 + 500;
                for (int i = 0; i < _statusList.response.Length; i++)
                {
                    StatusUnit statusUnit = new StatusUnit(_statusList.response[i], 5, posy, statusWidth, statusShowArea);
                    posy += statusUnit.unitHeight + 10;
                }
                return posy;
            }
            else
            {
                _nextPage.Enabled = false;
                _nextPage.Text = "没有更多状态";
                return 0;
            }
        }

    }
    public class StatusUnit
    {
        public StatusInfo _statusInfo;
        public TextBox _statusText;
        public Label _statusProperties;
        public int unitHeight;
        public StatusUnit(StatusInfo statusInfo,  int statusPosx, int statusPosy, int statusWidth, Panel statusShowArea) 
        {
            _statusInfo = statusInfo;
            _statusText = new TextBox();
            _statusText.Text = statusInfo.content;
            _statusText.Multiline = true;
            _statusText.WordWrap = true;
            _statusText.AutoSize = true;
            _statusText.ReadOnly = true;
            _statusText.BorderStyle = BorderStyle.None;
            Graphics tmpG = _statusText.CreateGraphics();
            SizeF size = tmpG.MeasureString(_statusText.Text, _statusText.Font);
            int textHeight = (int)size.Width / 550 + 1;
            _statusText.ClientSize = new Size(statusWidth, (int)(size.Height * textHeight));
            _statusText.Parent = statusShowArea;
            _statusText.Location = new Point(statusPosx, statusPosy);
            _statusText.BackColor = System.Drawing.SystemColors.Control;
            statusShowArea.Controls.Add(_statusText);

            _statusProperties = new Label();
            _statusProperties.Text = statusInfo.createTime + "  评论("+statusInfo.commentCount+")  转发("+statusInfo.shareCount+")";
            _statusProperties.AutoSize = true;
            _statusProperties.Location = new Point(statusPosx, statusPosy + _statusText.Height);
            statusShowArea.Controls.Add(_statusProperties);

            unitHeight = _statusText.Height + _statusProperties.Height;
        }
    }
}
