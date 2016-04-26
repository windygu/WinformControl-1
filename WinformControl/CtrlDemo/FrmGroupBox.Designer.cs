namespace CtrlDemo
{
    partial class FrmGroupBox
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
            this.groupBoxEx1 = new CtrlControls.ExGroupBox.GroupBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.LineColor = System.Drawing.Color.SlateBlue;
            this.groupBoxEx1.Location = new System.Drawing.Point(28, 12);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(200, 181);
            this.groupBoxEx1.TabIndex = 0;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "asfd";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(108, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FrmGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEx1);
            this.Name = "FrmGroupBox";
            this.Text = "FrmGroupBox";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlControls.ExGroupBox.GroupBoxEx groupBoxEx1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}