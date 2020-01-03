namespace 仓库管理
{
    partial class splr
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
            this.dgvrk = new System.Windows.Forms.DataGridView();
            this.spm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxspm = new System.Windows.Forms.TextBox();
            this.boxxh = new System.Windows.Forms.TextBox();
            this.tonlr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrk
            // 
            this.dgvrk.AllowUserToAddRows = false;
            this.dgvrk.AllowUserToDeleteRows = false;
            this.dgvrk.AllowUserToResizeColumns = false;
            this.dgvrk.AllowUserToResizeRows = false;
            this.dgvrk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spm,
            this.xh,
            this.cz});
            this.dgvrk.Location = new System.Drawing.Point(1, 0);
            this.dgvrk.Name = "dgvrk";
            this.dgvrk.ReadOnly = true;
            this.dgvrk.RowHeadersVisible = false;
            this.dgvrk.RowTemplate.Height = 23;
            this.dgvrk.Size = new System.Drawing.Size(303, 150);
            this.dgvrk.TabIndex = 13;
            // 
            // spm
            // 
            this.spm.HeaderText = "商品名";
            this.spm.Name = "spm";
            this.spm.ReadOnly = true;
            // 
            // xh
            // 
            this.xh.HeaderText = "型号";
            this.xh.Name = "xh";
            this.xh.ReadOnly = true;
            // 
            // cz
            // 
            this.cz.HeaderText = "操作";
            this.cz.Name = "cz";
            this.cz.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(336, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "规格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(322, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "商品名：";
            // 
            // boxspm
            // 
            this.boxspm.Location = new System.Drawing.Point(375, 22);
            this.boxspm.Name = "boxspm";
            this.boxspm.Size = new System.Drawing.Size(100, 21);
            this.boxspm.TabIndex = 18;
            // 
            // boxxh
            // 
            this.boxxh.Location = new System.Drawing.Point(375, 56);
            this.boxxh.Name = "boxxh";
            this.boxxh.Size = new System.Drawing.Size(100, 21);
            this.boxxh.TabIndex = 19;
            // 
            // tonlr
            // 
            this.tonlr.Location = new System.Drawing.Point(356, 100);
            this.tonlr.Name = "tonlr";
            this.tonlr.Size = new System.Drawing.Size(75, 23);
            this.tonlr.TabIndex = 20;
            this.tonlr.Text = "录入";
            this.tonlr.UseVisualStyleBackColor = true;
            this.tonlr.Click += new System.EventHandler(this.tonlr_Click);
            // 
            // splr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 151);
            this.Controls.Add(this.tonlr);
            this.Controls.Add(this.boxxh);
            this.Controls.Add(this.boxspm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvrk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splr";
            this.Text = "splr";
            this.Load += new System.EventHandler(this.splr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxspm;
        private System.Windows.Forms.TextBox boxxh;
        private System.Windows.Forms.Button tonlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn spm;
        private System.Windows.Forms.DataGridViewTextBoxColumn xh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cz;
    }
}