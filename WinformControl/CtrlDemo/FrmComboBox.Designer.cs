namespace CtrlDemo
{
    partial class FrmComboBox
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
            this.comboBoxEx1 = new CtrlControls.ExComboBox.ComboBoxEx();
            this.SuspendLayout();
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEx1.Location = new System.Drawing.Point(52, 66);
            this.comboBoxEx1.MinimumSize = new System.Drawing.Size(60, 28);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.ReadOnly = true;
            this.comboBoxEx1.SelectedIndex = -1;
            this.comboBoxEx1.SelectedItem = null;
            this.comboBoxEx1.SelectedValue = null;
            this.comboBoxEx1.Size = new System.Drawing.Size(200, 28);
            this.comboBoxEx1.TabIndex = 0;
            // 
            // FrmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBoxEx1);
            this.Name = "FrmComboBox";
            this.Text = "FrmComboBox";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlControls.ExComboBox.ComboBoxEx comboBoxEx1;













    }
}