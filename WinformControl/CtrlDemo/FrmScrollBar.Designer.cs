namespace CtrlDemo
{
    partial class FrmScrollBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScrollBar));
            this.scrollbarEx1 = new CtrlControls.ExScrollBar.ScrollbarEx();
            this.SuspendLayout();
            // 
            // scrollbarEx1
            // 
            this.scrollbarEx1.ChannelColor = System.Drawing.Color.DodgerBlue;
            this.scrollbarEx1.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("scrollbarEx1.DownArrowImage")));
            this.scrollbarEx1.LargeChange = 10;
            this.scrollbarEx1.Location = new System.Drawing.Point(157, 37);
            this.scrollbarEx1.Maximum = 100;
            this.scrollbarEx1.Minimum = 0;
            this.scrollbarEx1.MinimumSize = new System.Drawing.Size(15, 92);
            this.scrollbarEx1.Name = "scrollbarEx1";
            this.scrollbarEx1.Size = new System.Drawing.Size(15, 150);
            this.scrollbarEx1.SmallChange = 1;
            this.scrollbarEx1.TabIndex = 0;
            this.scrollbarEx1.ThumbBottomImage = ((System.Drawing.Image)(resources.GetObject("scrollbarEx1.ThumbBottomImage")));
            this.scrollbarEx1.ThumbBottomSpanImage = ((System.Drawing.Image)(resources.GetObject("scrollbarEx1.ThumbBottomSpanImage")));
            this.scrollbarEx1.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("scrollbarEx1.ThumbMiddleImage")));
            this.scrollbarEx1.ThumbTopImage = ((System.Drawing.Image)(resources.GetObject("scrollbarEx1.ThumbTopImage")));
            this.scrollbarEx1.ThumbTopSpanImage = ((System.Drawing.Image)(resources.GetObject("scrollbarEx1.ThumbTopSpanImage")));
            this.scrollbarEx1.UpArrowImage = ((System.Drawing.Image)(resources.GetObject("scrollbarEx1.UpArrowImage")));
            this.scrollbarEx1.Value = 0;
            // 
            // FrmScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.scrollbarEx1);
            this.Name = "FrmScrollBar";
            this.Text = "FrmScrollBar";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlControls.ExScrollBar.ScrollbarEx scrollbarEx1;

    }
}