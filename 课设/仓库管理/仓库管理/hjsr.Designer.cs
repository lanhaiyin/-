namespace 仓库管理
{
    partial class hjsr
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
            this.tonlr = new System.Windows.Forms.Button();
            this.boxhjck = new System.Windows.Forms.TextBox();
            this.boxhjbh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.spm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // tonlr
            // 
            this.tonlr.Location = new System.Drawing.Point(349, 102);
            this.tonlr.Name = "tonlr";
            this.tonlr.Size = new System.Drawing.Size(75, 23);
            this.tonlr.TabIndex = 26;
            this.tonlr.Text = "录入";
            this.tonlr.UseVisualStyleBackColor = true;
            this.tonlr.Click += new System.EventHandler(this.tonlr_Click);
            // 
            // boxhjck
            // 
            this.boxhjck.Enabled = false;
            this.boxhjck.Location = new System.Drawing.Point(405, 58);
            this.boxhjck.Name = "boxhjck";
            this.boxhjck.Size = new System.Drawing.Size(100, 21);
            this.boxhjck.TabIndex = 25;
            this.boxhjck.Text = "215";
            // 
            // boxhjbh
            // 
            this.boxhjbh.Location = new System.Drawing.Point(405, 24);
            this.boxhjbh.Name = "boxhjbh";
            this.boxhjbh.Size = new System.Drawing.Size(100, 21);
            this.boxhjbh.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(306, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "货架存放仓库：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(335, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "货架编号：";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spm,
            this.xh,
            this.cz});
            this.dg.Location = new System.Drawing.Point(0, 1);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.RowTemplate.Height = 23;
            this.dg.Size = new System.Drawing.Size(303, 150);
            this.dg.TabIndex = 21;
            // 
            // spm
            // 
            this.spm.HeaderText = "货架编号";
            this.spm.Name = "spm";
            this.spm.ReadOnly = true;
            this.spm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.spm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // xh
            // 
            this.xh.HeaderText = "货架存放仓库";
            this.xh.Name = "xh";
            this.xh.ReadOnly = true;
            this.xh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.xh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cz
            // 
            this.cz.HeaderText = "操作";
            this.cz.Name = "cz";
            this.cz.ReadOnly = true;
            // 
            // hjsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 151);
            this.Controls.Add(this.tonlr);
            this.Controls.Add(this.boxhjck);
            this.Controls.Add(this.boxhjbh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg);
            this.Name = "hjsr";
            this.Text = "hjsr";
            this.Load += new System.EventHandler(this.hjsr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tonlr;
        private System.Windows.Forms.TextBox boxhjck;
        private System.Windows.Forms.TextBox boxhjbh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn spm;
        private System.Windows.Forms.DataGridViewTextBoxColumn xh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cz;
    }
}