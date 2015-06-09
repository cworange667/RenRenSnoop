namespace RenRenSnoop
{
    partial class TargetUserDetail
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
            this.detailShowArea = new System.Windows.Forms.TabControl();
            this.statusShowArea = new System.Windows.Forms.TabPage();
            this.albumShowArea = new System.Windows.Forms.TabPage();
            this.detailShowArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailShowArea
            // 
            this.detailShowArea.Controls.Add(this.statusShowArea);
            this.detailShowArea.Controls.Add(this.albumShowArea);
            this.detailShowArea.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detailShowArea.Location = new System.Drawing.Point(12, 12);
            this.detailShowArea.Name = "detailShowArea";
            this.detailShowArea.SelectedIndex = 0;
            this.detailShowArea.Size = new System.Drawing.Size(693, 451);
            this.detailShowArea.TabIndex = 0;
            // 
            // statusShowArea
            // 
            this.statusShowArea.Location = new System.Drawing.Point(4, 24);
            this.statusShowArea.Name = "statusShowArea";
            this.statusShowArea.Padding = new System.Windows.Forms.Padding(3);
            this.statusShowArea.Size = new System.Drawing.Size(685, 423);
            this.statusShowArea.TabIndex = 0;
            this.statusShowArea.Text = "状态";
            this.statusShowArea.UseVisualStyleBackColor = true;
            // 
            // albumShowArea
            // 
            this.albumShowArea.Location = new System.Drawing.Point(4, 24);
            this.albumShowArea.Name = "albumShowArea";
            this.albumShowArea.Padding = new System.Windows.Forms.Padding(3);
            this.albumShowArea.Size = new System.Drawing.Size(685, 423);
            this.albumShowArea.TabIndex = 1;
            this.albumShowArea.Text = "相册";
            this.albumShowArea.UseVisualStyleBackColor = true;
            this.albumShowArea.Click += new System.EventHandler(this.albumShowArea_Click);
            // 
            // TargetUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 475);
            this.Controls.Add(this.detailShowArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TargetUserDetail";
            this.Text = "TargetUserDetail";
            this.detailShowArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl detailShowArea;
        private System.Windows.Forms.TabPage statusShowArea;
        private System.Windows.Forms.TabPage albumShowArea;
    }
}