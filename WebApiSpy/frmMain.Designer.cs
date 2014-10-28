namespace WebApiSpy
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgrdLog = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbRecord = new System.Windows.Forms.ToolStripButton();
            this.tsbPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdLog)).BeginInit();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdLog
            // 
            this.dgrdLog.AllowUserToAddRows = false;
            this.dgrdLog.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dgrdLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrdLog.BackgroundColor = System.Drawing.Color.Linen;
            this.dgrdLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Timer,
            this.Metod,
            this.Url,
            this.Request,
            this.Response});
            this.dgrdLog.Location = new System.Drawing.Point(0, 40);
            this.dgrdLog.MultiSelect = false;
            this.dgrdLog.Name = "dgrdLog";
            this.dgrdLog.ReadOnly = true;
            this.dgrdLog.RowHeadersVisible = false;
            this.dgrdLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdLog.Size = new System.Drawing.Size(968, 485);
            this.dgrdLog.TabIndex = 2;
            this.dgrdLog.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdLog_CellContentDoubleClick);
            this.dgrdLog.SelectionChanged += new System.EventHandler(this.dgrdLog_SelectionChanged);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.Width = 36;
            // 
            // Timer
            // 
            this.Timer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Timer.HeaderText = "Timer";
            this.Timer.Name = "Timer";
            this.Timer.ReadOnly = true;
            this.Timer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Timer.Width = 39;
            // 
            // Metod
            // 
            this.Metod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Metod.HeaderText = "Type";
            this.Metod.Name = "Metod";
            this.Metod.ReadOnly = true;
            this.Metod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Metod.Width = 35;
            // 
            // Url
            // 
            this.Url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Url.Width = 180;
            // 
            // Request
            // 
            this.Request.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Request.HeaderText = "Request";
            this.Request.Name = "Request";
            this.Request.ReadOnly = true;
            this.Request.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Request.Width = 53;
            // 
            // Response
            // 
            this.Response.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Response.HeaderText = "Response";
            this.Response.Name = "Response";
            this.Response.ReadOnly = true;
            this.Response.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRecord,
            this.tsbPause,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(968, 39);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsbRecord
            // 
            this.tsbRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecord.Image")));
            this.tsbRecord.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbRecord.Name = "tsbRecord";
            this.tsbRecord.Size = new System.Drawing.Size(36, 36);
            this.tsbRecord.Text = "Record";
            this.tsbRecord.Click += new System.EventHandler(this.tsbRecord_Click);
            // 
            // tsbPause
            // 
            this.tsbPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPause.Image = ((System.Drawing.Image)(resources.GetObject("tsbPause.Image")));
            this.tsbPause.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbPause.Name = "tsbPause";
            this.tsbPause.Size = new System.Drawing.Size(36, 36);
            this.tsbPause.Text = "Pause";
            this.tsbPause.Visible = false;
            this.tsbPause.Click += new System.EventHandler(this.tsbPause_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Delete all";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Details";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 525);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.dgrdLog);
            this.Name = "frmMain";
            this.Text = "WebApiSpy";
            ((System.ComponentModel.ISupportInitialize)(this.dgrdLog)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdLog;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbRecord;
        private System.Windows.Forms.ToolStripButton tsbPause;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn Response;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

