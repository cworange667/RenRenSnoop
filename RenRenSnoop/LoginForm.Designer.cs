namespace RenRenSnoop
{
    partial class LoginForm
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
            this.loginArea = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // loginArea
            // 
            this.loginArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginArea.Location = new System.Drawing.Point(0, 0);
            this.loginArea.MinimumSize = new System.Drawing.Size(20, 20);
            this.loginArea.Name = "loginArea";
            this.loginArea.Size = new System.Drawing.Size(343, 555);
            this.loginArea.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 555);
            this.Controls.Add(this.loginArea);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser loginArea;
    }
}