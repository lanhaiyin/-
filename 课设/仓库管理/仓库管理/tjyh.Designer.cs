namespace 仓库管理
{
    partial class tjyh
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
            this.label7 = new System.Windows.Forms.Label();
            this.boxmm = new System.Windows.Forms.TextBox();
            this.boxyhm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tontj = new System.Windows.Forms.Button();
            this.boxxm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxqx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "密码：";
            // 
            // boxmm
            // 
            this.boxmm.Location = new System.Drawing.Point(477, 37);
            this.boxmm.Name = "boxmm";
            this.boxmm.Size = new System.Drawing.Size(122, 21);
            this.boxmm.TabIndex = 18;
            this.boxmm.UseSystemPasswordChar = true;
            // 
            // boxyhm
            // 
            this.boxyhm.Location = new System.Drawing.Point(477, 10);
            this.boxyhm.Name = "boxyhm";
            this.boxyhm.Size = new System.Drawing.Size(122, 21);
            this.boxyhm.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "用户名：";
            // 
            // tontj
            // 
            this.tontj.Location = new System.Drawing.Point(487, 126);
            this.tontj.Name = "tontj";
            this.tontj.Size = new System.Drawing.Size(75, 23);
            this.tontj.TabIndex = 13;
            this.tontj.Text = "帐号添加";
            this.tontj.UseVisualStyleBackColor = true;
            this.tontj.Click += new System.EventHandler(this.tontj_Click);
            // 
            // boxxm
            // 
            this.boxxm.Location = new System.Drawing.Point(478, 67);
            this.boxxm.Name = "boxxm";
            this.boxxm.Size = new System.Drawing.Size(121, 21);
            this.boxxm.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "权限：";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.RowTemplate.Height = 23;
            this.dg.Size = new System.Drawing.Size(384, 161);
            this.dg.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "帐号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "密码";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "权限";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "操作";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // boxqx
            // 
            this.boxqx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxqx.FormattingEnabled = true;
            this.boxqx.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.boxqx.Location = new System.Drawing.Point(478, 95);
            this.boxqx.Name = "boxqx";
            this.boxqx.Size = new System.Drawing.Size(45, 20);
            this.boxqx.TabIndex = 27;
            // 
            // tjyh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 162);
            this.Controls.Add(this.boxqx);
            this.Controls.Add(this.boxxm);
            this.Controls.Add(this.boxmm);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxyhm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tontj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tjyh";
            this.Load += new System.EventHandler(this.tjyh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxmm;
        private System.Windows.Forms.TextBox boxyhm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tontj;
        private System.Windows.Forms.TextBox boxxm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox boxqx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}