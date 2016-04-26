namespace CtrlDemo
{
    partial class FrmRadioButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadioButton));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonEx2 = new CtrlControls.ExRadioButton.RadioButtonEx();
            this.radioButtonEx1 = new CtrlControls.ExRadioButton.RadioButtonEx();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(50, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "asdf";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonEx2
            // 
            this.radioButtonEx2.AutoSize = true;
            this.radioButtonEx2.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEx2.HighLightImage = ((System.Drawing.Image)(resources.GetObject("radioButtonEx2.HighLightImage")));
            this.radioButtonEx2.HighLightImageChecked = ((System.Drawing.Image)(resources.GetObject("radioButtonEx2.HighLightImageChecked")));
            this.radioButtonEx2.Location = new System.Drawing.Point(50, 159);
            this.radioButtonEx2.Name = "radioButtonEx2";
            this.radioButtonEx2.NormalImage = ((System.Drawing.Image)(resources.GetObject("radioButtonEx2.NormalImage")));
            this.radioButtonEx2.NormalImageChecked = ((System.Drawing.Image)(resources.GetObject("radioButtonEx2.NormalImageChecked")));
            this.radioButtonEx2.Size = new System.Drawing.Size(107, 16);
            this.radioButtonEx2.TabIndex = 2;
            this.radioButtonEx2.TabStop = true;
            this.radioButtonEx2.Text = "radioButtonEx2";
            this.radioButtonEx2.UseVisualStyleBackColor = false;
            this.radioButtonEx2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radioButtonEx2_MouseUp);
            // 
            // radioButtonEx1
            // 
            this.radioButtonEx1.AutoSize = true;
            this.radioButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEx1.HighLightImage = ((System.Drawing.Image)(resources.GetObject("radioButtonEx1.HighLightImage")));
            this.radioButtonEx1.HighLightImageChecked = ((System.Drawing.Image)(resources.GetObject("radioButtonEx1.HighLightImageChecked")));
            this.radioButtonEx1.Location = new System.Drawing.Point(50, 99);
            this.radioButtonEx1.Name = "radioButtonEx1";
            this.radioButtonEx1.NormalImage = ((System.Drawing.Image)(resources.GetObject("radioButtonEx1.NormalImage")));
            this.radioButtonEx1.NormalImageChecked = ((System.Drawing.Image)(resources.GetObject("radioButtonEx1.NormalImageChecked")));
            this.radioButtonEx1.Size = new System.Drawing.Size(107, 16);
            this.radioButtonEx1.TabIndex = 1;
            this.radioButtonEx1.TabStop = true;
            this.radioButtonEx1.Text = "radioButtonEx1";
            this.radioButtonEx1.UseVisualStyleBackColor = true;
            // 
            // FrmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.radioButtonEx2);
            this.Controls.Add(this.radioButtonEx1);
            this.Controls.Add(this.radioButton1);
            this.Name = "FrmRadioButton";
            this.Text = "FrmRadioButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private CtrlControls.ExRadioButton.RadioButtonEx radioButtonEx1;
        private CtrlControls.ExRadioButton.RadioButtonEx radioButtonEx2;
    }
}