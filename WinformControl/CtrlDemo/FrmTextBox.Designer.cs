namespace CtrlDemo
{
    partial class FrmTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTextBox));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxEx1 = new CtrlControls.ExTextBox.TextBoxEx();
            this.textBoxIconEx1 = new CtrlControls.ExTextBoxIcon.TextBoxIconEx();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.Border = true;
            this.textBoxEx1.BorderNormalColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxEx1.BorderNormalImage = ((System.Drawing.Image)(resources.GetObject("textBoxEx1.BorderNormalImage")));
            this.textBoxEx1.BorderOverColor = System.Drawing.Color.Blue;
            this.textBoxEx1.BorderOverImage = ((System.Drawing.Image)(resources.GetObject("textBoxEx1.BorderOverImage")));
            this.textBoxEx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEx1.BorderWeight = 1F;
            this.textBoxEx1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxEx1.Location = new System.Drawing.Point(41, 121);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Size = new System.Drawing.Size(100, 26);
            this.textBoxEx1.TabIndex = 3;
            this.textBoxEx1.WaterColor = System.Drawing.Color.DarkGray;
            this.textBoxEx1.WaterText = "";
            // 
            // textBoxIconEx1
            // 
            this.textBoxIconEx1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxIconEx1.BorderNormalImage = ((System.Drawing.Image)(resources.GetObject("textBoxIconEx1.BorderNormalImage")));
            this.textBoxIconEx1.BorderOverImage = ((System.Drawing.Image)(resources.GetObject("textBoxIconEx1.BorderOverImage")));
            this.textBoxIconEx1.Icon = global::CtrlDemo.Properties.Resources.textBoxEx_Keyword;
            this.textBoxIconEx1.Lines = new string[] {
        "textBoxIconEx1"};
            this.textBoxIconEx1.Location = new System.Drawing.Point(41, 175);
            this.textBoxIconEx1.MaximumSize = new System.Drawing.Size(0, 26);
            this.textBoxIconEx1.MaxLength = 32767;
            this.textBoxIconEx1.Name = "textBoxIconEx1";
            this.textBoxIconEx1.PasswordChar = '\0';
            this.textBoxIconEx1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxIconEx1.Size = new System.Drawing.Size(157, 26);
            this.textBoxIconEx1.TabIndex = 4;
            this.textBoxIconEx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxIconEx1.UseSystemPasswordChar = false;
            // 
            // FrmTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.textBoxIconEx1);
            this.Controls.Add(this.textBoxEx1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmTextBox";
            this.Text = "FrmTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private CtrlControls.ExTextBox.TextBoxEx textBoxEx1;
        private CtrlControls.ExTextBoxIcon.TextBoxIconEx textBoxIconEx1;

    }
}