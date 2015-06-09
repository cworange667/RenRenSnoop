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
    public partial class TargetUserDetail : Form
    {
        private string _targetID;
        private OAuth _oauth;
        private StatusBox _statusBoxForm;
        private AlbumBox _albumBoxForm;
        private int _statusPageNumber;
        private int _albumPageNumber;
        private enum ScanType
        {
            none,
            status,
            album,
            photo,
            blog
        }
        private ScanType _scanType = ScanType.none;
        private string _pageNumber2Skip;
        public TargetUserDetail(OAuth oauth, string targetID)
        {
            InitializeComponent();
            _oauth = oauth;
            _targetID = targetID;
            _statusPageNumber = 1;
            _albumPageNumber = 1;
            _scanType = ScanType.status;
            _statusPageNumber = 1;
            StatusScan(_statusPageNumber);
            _scanType = ScanType.album;
            _albumPageNumber = 1;
            AlbumScan(_albumPageNumber);
        }


        private void AlbumScan(int albumPageNumber) 
        {
            _albumBoxForm = new AlbumBox(_targetID, _oauth, albumShowArea);
            _albumBoxForm.TopLevel = false;
            _albumBoxForm.Dock = DockStyle.Fill;
            _albumBoxForm.FormBorderStyle = FormBorderStyle.None;
            _albumBoxForm.Parent = albumShowArea;
            _albumBoxForm.Show();
        }
        private void StatusScan(int statusPageNumber)
        {
            _statusBoxForm = new StatusBox(_oauth, _targetID);
            _statusBoxForm.TopLevel = false;
            _statusBoxForm.Dock = DockStyle.Fill;
            _statusBoxForm.FormBorderStyle = FormBorderStyle.None;
            _statusBoxForm.Parent = statusShowArea;
            _statusBoxForm.Show();
        }


        private void albumShowArea_Click(object sender, EventArgs e)
        {

        }

    }
}
