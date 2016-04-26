namespace CtrlDemo
{
    partial class FrmListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListView));
            this.listViewEx1 = new CtrlControls.ExListView.ListViewEx();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompleted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewEx1
            // 
            this.listViewEx1.BorderColor = System.Drawing.Color.Black;
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colSize,
            this.colCompleted,
            this.colProgress,
            this.colEndTime,
            this.colRate,
            this.colStartTime,
            this.colState,
            this.colResume,
            this.colURL});
            this.listViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.GridLines = true;
            this.listViewEx1.ItemBackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewEx1.ItemBackgroundImage")));
            this.listViewEx1.ItemHighLightBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(215)))));
            this.listViewEx1.Location = new System.Drawing.Point(0, 0);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.OwnerDraw = true;
            this.listViewEx1.Size = new System.Drawing.Size(942, 354);
            this.listViewEx1.TabIndex = 0;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            // 
            // colFile
            // 
            this.colFile.Text = "文件名称";
            // 
            // colSize
            // 
            this.colSize.Text = "大小";
            // 
            // colCompleted
            // 
            this.colCompleted.Text = "百分比";
            // 
            // colProgress
            // 
            this.colProgress.Text = "进度";
            // 
            // colEndTime
            // 
            this.colEndTime.Text = "剩余时间";
            this.colEndTime.Width = 150;
            // 
            // colRate
            // 
            this.colRate.Text = "速度";
            // 
            // colStartTime
            // 
            this.colStartTime.Text = "开始时间";
            this.colStartTime.Width = 150;
            // 
            // colState
            // 
            this.colState.Text = "状态";
            // 
            // colResume
            // 
            this.colResume.Text = "说明";
            // 
            // colURL
            // 
            this.colURL.Text = "网址";
            this.colURL.Width = 200;
            // 
            // FrmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 354);
            this.Controls.Add(this.listViewEx1);
            this.Name = "FrmListView";
            this.Text = "FrmListView";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlControls.ExListView.ListViewEx listViewEx1;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colCompleted;
        private System.Windows.Forms.ColumnHeader colProgress;
        private System.Windows.Forms.ColumnHeader colEndTime;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ColumnHeader colStartTime;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colResume;
        private System.Windows.Forms.ColumnHeader colURL;
    }
}