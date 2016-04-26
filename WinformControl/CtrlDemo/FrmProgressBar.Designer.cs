namespace CtrlDemo
{
    partial class FrmProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBarEx1 = new CtrlControls.ExProgressBar.ProgressBarEx();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(52, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 50;
            // 
            // progressBarEx1
            // 
            this.progressBarEx1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.progressBarEx1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.progressBarEx1.Location = new System.Drawing.Point(37, 132);
            this.progressBarEx1.Name = "progressBarEx1";
            this.progressBarEx1.ProgressBarBorderColor = System.Drawing.Color.LightGray;
            this.progressBarEx1.ProgressBarColor = System.Drawing.Color.CornflowerBlue;
            this.progressBarEx1.ProgressBarText = "";
            this.progressBarEx1.ProgressBarTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(147)))));
            this.progressBarEx1.Radius = 8;
            this.progressBarEx1.Size = new System.Drawing.Size(231, 78);
            this.progressBarEx1.TabIndex = 2;
            this.progressBarEx1.Value = 50;
            // 
            // FrmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.progressBarEx1);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrmProgressBar";
            this.Text = "FrmProgressBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private CtrlControls.ExProgressBar.ProgressBarEx progressBarEx1;
    }
}