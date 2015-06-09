namespace RenRenSnoop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.userProvince = new System.Windows.Forms.Label();
            this.userCity = new System.Windows.Forms.Label();
            this.userSchool = new System.Windows.Forms.Label();
            this.searchtBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.targetUserName = new System.Windows.Forms.Label();
            this.targetUserAvatar = new System.Windows.Forms.PictureBox();
            this.userInfoArea = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetUserAvatar)).BeginInit();
            this.userInfoArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // userAvatar
            // 
            this.userAvatar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userAvatar.Location = new System.Drawing.Point(3, 0);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(100, 100);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatar.TabIndex = 0;
            this.userAvatar.TabStop = false;
            this.userAvatar.Click += new System.EventHandler(this.userAvatar_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(109, 8);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(117, 28);
            this.userName.TabIndex = 1;
            this.userName.Text = "Loading…";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // userProvince
            // 
            this.userProvince.AutoSize = true;
            this.userProvince.Location = new System.Drawing.Point(107, 49);
            this.userProvince.Name = "userProvince";
            this.userProvince.Size = new System.Drawing.Size(59, 12);
            this.userProvince.TabIndex = 2;
            this.userProvince.Text = "Loading…";
            // 
            // userCity
            // 
            this.userCity.AutoSize = true;
            this.userCity.Location = new System.Drawing.Point(172, 49);
            this.userCity.Name = "userCity";
            this.userCity.Size = new System.Drawing.Size(59, 12);
            this.userCity.TabIndex = 3;
            this.userCity.Text = "Loading…";
            // 
            // userSchool
            // 
            this.userSchool.AutoSize = true;
            this.userSchool.Location = new System.Drawing.Point(107, 70);
            this.userSchool.Name = "userSchool";
            this.userSchool.Size = new System.Drawing.Size(59, 12);
            this.userSchool.TabIndex = 4;
            this.userSchool.Text = "Loading…";
            // 
            // searchtBox
            // 
            this.searchtBox.Location = new System.Drawing.Point(12, 149);
            this.searchtBox.Name = "searchtBox";
            this.searchtBox.Size = new System.Drawing.Size(100, 21);
            this.searchtBox.TabIndex = 5;
            this.searchtBox.Text = "输入人人ID";
            this.searchtBox.TextChanged += new System.EventHandler(this.searchtBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(126, 149);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "搜索该用户";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // targetUserName
            // 
            this.targetUserName.AutoSize = true;
            this.targetUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.targetUserName.Location = new System.Drawing.Point(71, 188);
            this.targetUserName.Name = "targetUserName";
            this.targetUserName.Size = new System.Drawing.Size(94, 22);
            this.targetUserName.TabIndex = 8;
            this.targetUserName.Text = "UserName";
            this.targetUserName.Click += new System.EventHandler(this.TargetUserName_Click);
            // 
            // targetUserAvatar
            // 
            this.targetUserAvatar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.targetUserAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.targetUserAvatar.Location = new System.Drawing.Point(15, 188);
            this.targetUserAvatar.Name = "targetUserAvatar";
            this.targetUserAvatar.Size = new System.Drawing.Size(50, 50);
            this.targetUserAvatar.TabIndex = 9;
            this.targetUserAvatar.TabStop = false;
            this.targetUserAvatar.Click += new System.EventHandler(this.targetUserAvatar_Click);
            // 
            // userInfoArea
            // 
            this.userInfoArea.Controls.Add(this.userAvatar);
            this.userInfoArea.Controls.Add(this.userName);
            this.userInfoArea.Controls.Add(this.userProvince);
            this.userInfoArea.Controls.Add(this.userCity);
            this.userInfoArea.Controls.Add(this.userSchool);
            this.userInfoArea.Location = new System.Drawing.Point(12, 12);
            this.userInfoArea.Name = "userInfoArea";
            this.userInfoArea.Size = new System.Drawing.Size(251, 101);
            this.userInfoArea.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(283, 273);
            this.Controls.Add(this.userInfoArea);
            this.Controls.Add(this.targetUserAvatar);
            this.Controls.Add(this.targetUserName);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchtBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetUserAvatar)).EndInit();
            this.userInfoArea.ResumeLayout(false);
            this.userInfoArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userProvince;
        private System.Windows.Forms.Label userCity;
        private System.Windows.Forms.Label userSchool;
        private System.Windows.Forms.TextBox searchtBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label targetUserName;
        private System.Windows.Forms.PictureBox targetUserAvatar;
        private System.Windows.Forms.Panel userInfoArea;

    }
}