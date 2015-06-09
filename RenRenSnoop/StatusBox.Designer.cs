namespace RenRenSnoop
{
    partial class StatusBox
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
            this.statusShowArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // statusShowArea
            // 
            this.statusShowArea.AutoScroll = true;
            this.statusShowArea.AutoSize = true;
            this.statusShowArea.BackColor = System.Drawing.SystemColors.Control;
            this.statusShowArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusShowArea.Location = new System.Drawing.Point(0, 0);
            this.statusShowArea.Name = "statusShowArea";
            this.statusShowArea.Size = new System.Drawing.Size(325, 284);
            this.statusShowArea.TabIndex = 0;
            // 
            // StatusBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(325, 284);
            this.Controls.Add(this.statusShowArea);
            this.Name = "StatusBox";
            this.Text = "StatusBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel statusShowArea;



    }
}