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
    public partial class AlbumBox : Form
    {
        private string _targetID;
        private PhotoBox photoBoxForm;
        private OAuth _oauth;
        private Panel _albumShowArea;
        private Button _nextPage;
        private int _pageNumber;
        public AlbumBox( string targetID, OAuth oauth, Panel albumShowArea)
        {
            InitializeComponent();
            _oauth = oauth;
            _targetID = targetID;
            _albumShowArea = albumShowArea;
            _pageNumber = 1;
            albumBoxRefresh(_pageNumber);
            //_nextPage = new Button();
            //_nextPage.Text = "更多相册";
            //_nextPage.Size = new Size(620, 50);
            //_nextPage.TabStop = false;
            //_nextPage.Location = new Point(10, 400);
            //_nextPage.Click += _nextPage_Click;
            showArea.Controls.Add(_nextPage);

        }

        //void _nextPage_Click(object sender, EventArgs e)
        //{
        //    _pageNumber++;
        //    albumBoxRefresh(_pageNumber);
        //}
        public void albumHandler(object sender, EventArgs e)
        {
            photoBoxForm = new PhotoBox(_oauth, ((PictureBox)sender).Name, _targetID);
            photoBoxForm.TopLevel = true;
            photoBoxForm.Show();
        }
        public int albumBoxRefresh(int pageNumber)
        {
            int posx = 0;
            int posy = 0;
            AlbumListInfoResponse albumList = _oauth.TargetUserAlbumList(_targetID, "99", pageNumber.ToString());
            if (albumList.response.Length == 0)
            {
                _nextPage.Text = "没有更多的相册了";
                _nextPage.Enabled = false;
                return 0;
            }
            List<AlbumUnit> albumUnit = new List<AlbumUnit>();
            for (int i = 0; i < albumList.response.Length; i++)
            {
                posx = 10 + 140 * (i % 4);
                if (pageNumber == 1)
                    posy = 10 + 150 * (i / 4);
                else
                    posy = 300 + 10 + 150 * (i / 4);
                albumUnit.Add(new AlbumUnit(albumList.response[i], posx, posy, this));
                showArea.Controls.Add(albumUnit[i].albumCover);
                showArea.Controls.Add(albumUnit[i].albumName);
            }
            return posy;
        }

    }
    public class AlbumUnit
    {
        public System.Windows.Forms.PictureBox albumCover;
        public System.Windows.Forms.Label albumName;
        public AlbumUnit(AlbumInfo albumInfo, int posx, int posy, AlbumBox albumBoxForm)
        {
            albumCover = new PictureBox();
            albumName = new Label();
            albumCover.ImageLocation = albumInfo.cover[0].url;
            albumCover.BackColor = System.Drawing.SystemColors.InactiveCaption;
            albumCover.Location = new System.Drawing.Point(posx, posy);
            albumCover.Size = new System.Drawing.Size(120, 120);
            albumCover.SizeMode = PictureBoxSizeMode.Zoom;
            albumCover.Name = albumInfo.id;
            albumCover.Cursor = System.Windows.Forms.Cursors.Hand;
            albumName.Text = albumInfo.name;
            albumName.Location = new System.Drawing.Point(posx + 10 , posy + 125);
            albumName.TextAlign = ContentAlignment.MiddleCenter;
            albumName.Cursor = System.Windows.Forms.Cursors.Hand;
            albumCover.Click += albumBoxForm.albumHandler;
            //albumCover.Click += new System.EventHandler(albumBoxForm.albumHandler);
            //albumName.Click += new System.EventHandler(albumBoxForm.albumHandler);
        }

    }
}
