namespace CtrlDemo
{
    partial class FrmDataGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataGridView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlEx1 = new CtrlControls.ExTabControl.TabControlEx();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewEx1 = new CtrlControls.ExDataGridView.DataGridViewEx();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperator1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKeyword1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colWaitTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperator = new CtrlControls.ExDataGridView.DataGridViewExLinkColumnEx();
            this.colKeyWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colWaitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastTime = new CtrlControls.ExDataGridView.DataGridViewExCalendarColumn();
            this.tabControlEx1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEx1
            // 
            this.tabControlEx1.Controls.Add(this.tabPage1);
            this.tabControlEx1.Controls.Add(this.tabPage2);
            this.tabControlEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEx1.ItemSize = new System.Drawing.Size(120, 34);
            this.tabControlEx1.Location = new System.Drawing.Point(0, 0);
            this.tabControlEx1.Name = "tabControlEx1";
            this.tabControlEx1.SelectedIndex = 0;
            this.tabControlEx1.Size = new System.Drawing.Size(694, 401);
            this.tabControlEx1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlEx1.TabControlBorderColor = System.Drawing.SystemColors.Control;
            this.tabControlEx1.TabHeadArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControlEx1.TabHeadArrowDown")));
            this.tabControlEx1.TabHeadArrowMove = ((System.Drawing.Image)(resources.GetObject("tabControlEx1.TabHeadArrowMove")));
            this.tabControlEx1.TabHeadBackgroundMove = ((System.Drawing.Image)(resources.GetObject("tabControlEx1.TabHeadBackgroundMove")));
            this.tabControlEx1.TabHeadBackgroundNormal = ((System.Drawing.Image)(resources.GetObject("tabControlEx1.TabHeadBackgroundNormal")));
            this.tabControlEx1.TabHeadBackgroundSelected = ((System.Drawing.Image)(resources.GetObject("tabControlEx1.TabHeadBackgroundSelected")));
            this.tabControlEx1.TabIndex = 0;
            this.tabControlEx1.TabPageBackColor = System.Drawing.SystemColors.Control;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewEx1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自定义GridView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEx1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEx1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCardName,
            this.colStatus,
            this.colCount,
            this.colOperator,
            this.colKeyWord,
            this.colSource,
            this.colWaitTime,
            this.colLastTime});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEx1.MouseMoveColor = System.Drawing.Color.Yellow;
            this.dataGridViewEx1.MultiSelect = false;
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.ReadOnly = true;
            this.dataGridViewEx1.RowHeadersVisible = false;
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEx1.Size = new System.Drawing.Size(680, 353);
            this.dataGridViewEx1.TabIndex = 1;
            this.dataGridViewEx1.TitleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dataGridViewEx1.TitleColorB = System.Drawing.Color.White;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "系统GridView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName1,
            this.colCardName1,
            this.colStatus1,
            this.colCount1,
            this.colOperator1,
            this.colKeyword1,
            this.colSource1,
            this.colWaitTime1,
            this.colLastTime1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // colName1
            // 
            this.colName1.DataPropertyName = "Name";
            this.colName1.HeaderText = "访客名称";
            this.colName1.Name = "colName1";
            this.colName1.ReadOnly = true;
            // 
            // colCardName1
            // 
            this.colCardName1.DataPropertyName = "CardName";
            this.colCardName1.HeaderText = "卡片名称";
            this.colCardName1.Name = "colCardName1";
            this.colCardName1.ReadOnly = true;
            // 
            // colStatus1
            // 
            this.colStatus1.DataPropertyName = "Status";
            this.colStatus1.HeaderText = "状态";
            this.colStatus1.Name = "colStatus1";
            this.colStatus1.ReadOnly = true;
            // 
            // colCount1
            // 
            this.colCount1.DataPropertyName = "Count";
            this.colCount1.HeaderText = "访问次数";
            this.colCount1.Name = "colCount1";
            this.colCount1.ReadOnly = true;
            // 
            // colOperator1
            // 
            this.colOperator1.HeaderText = "访客操作";
            this.colOperator1.Name = "colOperator1";
            this.colOperator1.ReadOnly = true;
            this.colOperator1.Width = 270;
            // 
            // colKeyword1
            // 
            this.colKeyword1.DataPropertyName = "Keyword";
            this.colKeyword1.HeaderText = "关键词";
            this.colKeyword1.Name = "colKeyword1";
            this.colKeyword1.ReadOnly = true;
            // 
            // colSource1
            // 
            this.colSource1.DataPropertyName = "Source";
            this.colSource1.HeaderText = "访问来源";
            this.colSource1.Name = "colSource1";
            this.colSource1.ReadOnly = true;
            this.colSource1.Width = 120;
            // 
            // colWaitTime1
            // 
            this.colWaitTime1.DataPropertyName = "WaitTime";
            this.colWaitTime1.HeaderText = "等待时间";
            this.colWaitTime1.Name = "colWaitTime1";
            this.colWaitTime1.ReadOnly = true;
            // 
            // colLastTime1
            // 
            this.colLastTime1.DataPropertyName = "LastTime";
            this.colLastTime1.HeaderText = "最后时间";
            this.colLastTime1.Name = "colLastTime1";
            this.colLastTime1.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "访客名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCardName
            // 
            this.colCardName.DataPropertyName = "CardName";
            this.colCardName.HeaderText = "卡片名称";
            this.colCardName.Name = "colCardName";
            this.colCardName.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "状态";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.DataPropertyName = "Count";
            this.colCount.HeaderText = "访问次数";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // colOperator
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.colOperator.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOperator.HeaderText = "访客操作";
            this.colOperator.Name = "colOperator";
            this.colOperator.ReadOnly = true;
            this.colOperator.Width = 270;
            // 
            // colKeyWord
            // 
            this.colKeyWord.DataPropertyName = "KeyWord";
            this.colKeyWord.HeaderText = "关键词";
            this.colKeyWord.Name = "colKeyWord";
            this.colKeyWord.ReadOnly = true;
            // 
            // colSource
            // 
            this.colSource.DataPropertyName = "Source";
            this.colSource.HeaderText = "访问来源";
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            this.colSource.Width = 120;
            // 
            // colWaitTime
            // 
            this.colWaitTime.DataPropertyName = "WaitTime";
            this.colWaitTime.HeaderText = "等待时间";
            this.colWaitTime.Name = "colWaitTime";
            this.colWaitTime.ReadOnly = true;
            // 
            // colLastTime
            // 
            this.colLastTime.DataPropertyName = "LastTime";
            this.colLastTime.HeaderText = "最后时间";
            this.colLastTime.Name = "colLastTime";
            this.colLastTime.ReadOnly = true;
            // 
            // FrmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 401);
            this.Controls.Add(this.tabControlEx1);
            this.Name = "FrmDataGridView";
            this.Text = "FrmDataGridView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlEx1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlControls.ExTabControl.TabControlEx tabControlEx1;
        private System.Windows.Forms.TabPage tabPage1;
        private CtrlControls.ExDataGridView.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private CtrlControls.ExDataGridView.DataGridViewExLinkColumnEx colOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeyWord;
        private System.Windows.Forms.DataGridViewLinkColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaitTime;
        private CtrlControls.ExDataGridView.DataGridViewExCalendarColumn colLastTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeyword1;
        private System.Windows.Forms.DataGridViewLinkColumn colSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaitTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastTime1;

    }
}