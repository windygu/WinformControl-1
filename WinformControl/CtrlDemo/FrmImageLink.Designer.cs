namespace CtrlDemo
{
    partial class FrmImageLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImageLink));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.imageLinkEx1 = new CtrlControls.ExImageLink.ImageLinkEx();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(51, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(23, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "123";
            // 
            // imageLinkEx1
            // 
            this.imageLinkEx1.BackColor = System.Drawing.Color.Transparent;
            this.imageLinkEx1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(112)))), ((int)(((byte)(235)))));
            this.imageLinkEx1.Icon = ((System.Drawing.Image)(resources.GetObject("imageLinkEx1.Icon")));
            this.imageLinkEx1.Location = new System.Drawing.Point(67, 127);
            this.imageLinkEx1.Name = "imageLinkEx1";
            this.imageLinkEx1.NatureColor = System.Drawing.Color.Empty;
            this.imageLinkEx1.Size = new System.Drawing.Size(108, 23);
            this.imageLinkEx1.TabIndex = 1;
            this.imageLinkEx1.Text = "imageLinkEx1";
            // 
            // FrmImageLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.imageLinkEx1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "FrmImageLink";
            this.Text = "FrmImageLink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private CtrlControls.ExImageLink.ImageLinkEx imageLinkEx1;
    }
}