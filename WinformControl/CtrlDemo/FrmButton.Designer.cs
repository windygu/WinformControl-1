namespace CtrlDemo
{
    partial class FrmButton
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmButton));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEx1 = new CtrlControls.ExButton.ButtonEx();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::CtrlDemo.Properties.Resources.frameBorderEffect_mouseDownDraw;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(47, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "asfdsa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonEx1
            // 
            this.buttonEx1.BackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.BorderImage = ((System.Drawing.Image)(resources.GetObject("buttonEx1.BorderImage")));
            this.buttonEx1.DownImage = ((System.Drawing.Image)(resources.GetObject("buttonEx1.DownImage")));
            this.buttonEx1.FocusImage = ((System.Drawing.Image)(resources.GetObject("buttonEx1.FocusImage")));
            this.buttonEx1.Image = global::CtrlDemo.Properties.Resources.Messagebox18;
            this.buttonEx1.IsShowBorder = true;
            this.buttonEx1.Location = new System.Drawing.Point(47, 113);
            this.buttonEx1.MoveImage = ((System.Drawing.Image)(resources.GetObject("buttonEx1.MoveImage")));
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.NormalImage = ((System.Drawing.Image)(resources.GetObject("buttonEx1.NormalImage")));
            this.buttonEx1.Size = new System.Drawing.Size(178, 80);
            this.buttonEx1.TabIndex = 1;
            this.buttonEx1.Text = "buttonEx1";
            this.buttonEx1.UseVisualStyleBackColor = false;
            this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.buttonEx1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CtrlControls.ExButton.ButtonEx buttonEx1;
    }
}

