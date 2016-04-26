namespace CtrlDemo
{
    partial class FrmCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckBox));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxEx1 = new CtrlControls.ExCheckBox.CheckBoxEx();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxEx1
            // 
            this.checkBoxEx1.AutoSize = true;
            this.checkBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx1.HighLightImage = ((System.Drawing.Image)(resources.GetObject("checkBoxEx1.HighLightImage")));
            this.checkBoxEx1.HighLightImageChecked = ((System.Drawing.Image)(resources.GetObject("checkBoxEx1.HighLightImageChecked")));
            this.checkBoxEx1.Location = new System.Drawing.Point(43, 71);
            this.checkBoxEx1.Name = "checkBoxEx1";
            this.checkBoxEx1.NormalImage = ((System.Drawing.Image)(resources.GetObject("checkBoxEx1.NormalImage")));
            this.checkBoxEx1.NormalImageChecked = ((System.Drawing.Image)(resources.GetObject("checkBoxEx1.NormalImageChecked")));
            this.checkBoxEx1.Size = new System.Drawing.Size(216, 16);
            this.checkBoxEx1.TabIndex = 1;
            this.checkBoxEx1.Text = "王云鹏是北大青鸟趟城中心第一帅哥";
            this.checkBoxEx1.UseVisualStyleBackColor = false;
            // 
            // FrmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.checkBoxEx1);
            this.Controls.Add(this.checkBox1);
            this.Name = "FrmCheckBox";
            this.Text = "FrmCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private CtrlControls.ExCheckBox.CheckBoxEx checkBoxEx1;
    }
}