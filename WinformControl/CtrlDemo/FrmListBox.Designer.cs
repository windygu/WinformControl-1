namespace CtrlDemo
{
    partial class FrmListBox
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
            this.components = new System.ComponentModel.Container();
            this.listBoxEx1 = new CtrlControls.ExListBox.ListBoxEx();
            this.scrollbarExComponent1 = new CtrlControls.ExScrollBar.ScrollbarExComponent(this.components);
            this.SuspendLayout();
            // 
            // listBoxEx1
            // 
            this.listBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxEx1.Font = new System.Drawing.Font("宋体", 11F);
            this.listBoxEx1.FormattingEnabled = true;
            this.listBoxEx1.ItemHeight = 35;
            this.listBoxEx1.Location = new System.Drawing.Point(22, 34);
            this.listBoxEx1.Name = "listBoxEx1";
            this.listBoxEx1.Size = new System.Drawing.Size(228, 179);
            this.listBoxEx1.TabIndex = 0;
            this.scrollbarExComponent1.SetUserCustomScrollbar(this.listBoxEx1, true);
            // 
            // FrmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBoxEx1);
            this.Name = "FrmListBox";
            this.Text = "FrmListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlControls.ExListBox.ListBoxEx listBoxEx1;
        private CtrlControls.ExScrollBar.ScrollbarExComponent scrollbarExComponent1;
    }
}