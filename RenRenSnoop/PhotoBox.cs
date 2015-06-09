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
    public partial class PhotoBox : Form
    {
        private List<PhotoUnit> photoUnit;
        private OAuth _oauth; 
        private string _albumId;
        private string _ownerId;
        private int _pageNumber;
        private Button _nextPage;
        private string _pageSize;
        public PhotoBox(OAuth oauth, string albumId, string ownerId)
        {
            InitializeComponent();
            _oauth = oauth;
            _albumId = albumId;
            _ownerId = ownerId;
            _pageNumber = 1;
            _pageSize = "20";
            PhotoBoxRefresh(_pageNumber);
            _nextPage = new Button();
            _nextPage.Text = "更多照片";
            _nextPage.Size = new Size(700, 50);
            _nextPage.TabStop = false;
            _nextPage.Location = new Point(10, 1020);
            _nextPage.Click += _nextPage_Click;
            photoPanel.Controls.Add(_nextPage);

        }

        void _nextPage_Click(object sender, EventArgs e)
        {
            _pageNumber++;
            int buttonLocationy = PhotoBoxRefresh(_pageNumber);
            if (buttonLocationy != 0)
                _nextPage.Location = new Point(10, buttonLocationy + 220);
        }
        private int PhotoBoxRefresh(int pageNumber)
        {
            int posx = 0;
            int posy = 0;
            PhotoListInfoResponse photoList = _oauth.TargetUserPhotoList(_albumId, _ownerId, _pageSize, pageNumber.ToString());
            if (photoList.response.Length == 0)
            {
                _nextPage.Text = "没有更多的照片了";
                _nextPage.Enabled = false;
                return 0;
            }
            photoUnit = new List<PhotoUnit>();
            for (int i = 0; i < photoList.response.Length; i++)
            {
                posx = 10 + 180 * (i % 4);
                if(pageNumber == 1)
                    posy = 10 + 200 * (i / 4);
                else
                    posy = 500 + 10 + 200 * (i / 4);
                photoUnit.Add(new PhotoUnit(photoList.response[i], posx, posy, this));
                photoPanel.Controls.Add(photoUnit[i].previewPicture);
                photoPanel.Controls.Add(photoUnit[i].pictureDescription);
            }
            return posy;
 
        }
    }
    public class PhotoUnit
    {
        public System.Windows.Forms.PictureBox previewPicture;
        public System.Windows.Forms.Label pictureDescription;
        public PhotoUnit(PhotoInfo photoInfo, int posx, int posy, PhotoBox albumBoxForm)
        {
            previewPicture = new PictureBox();
            pictureDescription = new Label();
            previewPicture.ImageLocation = photoInfo.images[1].url;
            previewPicture.BackColor = System.Drawing.SystemColors.InactiveCaption;
            previewPicture.Location = new System.Drawing.Point(posx, posy);
            previewPicture.Size = new System.Drawing.Size(150, 150);
            previewPicture.SizeMode = PictureBoxSizeMode.Zoom;
            previewPicture.Name = photoInfo.images[0].url;
            previewPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            previewPicture.Click += previewPicture_Click;
            pictureDescription.Text = photoInfo.description;
            pictureDescription.Location = new System.Drawing.Point(posx, posy + 155);
            pictureDescription.TextAlign = ContentAlignment.TopLeft;
            //pictureDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureDescription.AutoSize = true;
            pictureDescription.MaximumSize = new Size(150, 25);
            //previewPicture.Click += albumBoxForm.albumHandler;
            //albumCover.Click += new System.EventHandler(albumBoxForm.albumHandler);
            //albumName.Click += new System.EventHandler(albumBoxForm.albumHandler);
        }

        void previewPicture_Click(object sender, EventArgs e)
        {
            PictureBox targetPicture = new PictureBox();
            targetPicture.Location = new Point(0, 0);
            System.Net.WebClient webClient = new System.Net.WebClient();
            var imageData = webClient.DownloadData(((PictureBox)sender).Name);
            var steam = new System.IO.MemoryStream(imageData);
            var targetImage = Image.FromStream(steam);
            targetPicture.Image = targetImage;
            targetPicture.Size = targetImage.Size;
            Form pictureForm = new Form();
            pictureForm.TopLevel = true;
//            pictureForm.AutoScroll = true;
            pictureForm.Size = new Size(800, 600);
            pictureForm.AutoScroll = true;
            pictureForm.Show();
            pictureForm.Controls.Add(targetPicture);


        }
    }
}
