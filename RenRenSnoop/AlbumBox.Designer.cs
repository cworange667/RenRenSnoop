namespace RenRenSnoop
{
    partial class AlbumBox
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
            this.showArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.BackColor = System.Drawing.SystemColors.Control;
            this.showArea.Location = new System.Drawing.Point(2, 1);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(562, 427);
            this.showArea.TabIndex = 0;
            // 
            // AlbumBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(576, 440);
            this.Controls.Add(this.showArea);
            this.Name = "AlbumBox";
            this.Text = "AlbumBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel showArea;

    }
}