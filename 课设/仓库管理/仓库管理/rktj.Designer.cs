namespace 仓库管理
{
    partial class rktj
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbspm = new System.Windows.Forms.ComboBox();
            this.cmbhj = new System.Windows.Forms.ComboBox();
            this.txbsl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbgys = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxh = new System.Windows.Forms.ComboBox();
            this.dgvrk = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "存放货架";
            // 
            // cmbspm
            // 
            this.cmbspm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbspm.FormattingEnabled = true;
            this.cmbspm.Location = new System.Drawing.Point(638, 21);
            this.cmbspm.Name = "cmbspm";
            this.cmbspm.Size = new System.Drawing.Size(121, 20);
            this.cmbspm.TabIndex = 3;
            this.cmbspm.Leave += new System.EventHandler(this.cmbspm_Leave);
            // 
            // cmbhj
            // 
            this.cmbhj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhj.FormattingEnabled = true;
            this.cmbhj.Location = new System.Drawing.Point(638, 149);
            this.cmbhj.Name = "cmbhj";
            this.cmbhj.Size = new System.Drawing.Size(121, 20);
            this.cmbhj.TabIndex = 4;
            // 
            // txbsl
            // 
            this.txbsl.Location = new System.Drawing.Point(638, 84);
            this.txbsl.Name = "txbsl";
            this.txbsl.Size = new System.Drawing.Size(100, 21);
            this.txbsl.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "供应商";
            // 
            // cmbgys
            // 
            this.cmbgys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgys.FormattingEnabled = true;
            this.cmbgys.Location = new System.Drawing.Point(638, 115);
            this.cmbgys.Name = "cmbgys";
            this.cmbgys.Size = new System.Drawing.Size(121, 20);
            this.cmbgys.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "规格";
            // 
            // cmbxh
            // 
            this.cmbxh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxh.FormattingEnabled = true;
            this.cmbxh.Location = new System.Drawing.Point(638, 53);
            this.cmbxh.Name = "cmbxh";
            this.cmbxh.Size = new System.Drawing.Size(121, 20);
            this.cmbxh.TabIndex = 11;
            // 
            // dgvrk
            // 
            this.dgvrk.AllowUserToAddRows = false;
            this.dgvrk.AllowUserToDeleteRows = false;
            this.dgvrk.AllowUserToResizeColumns = false;
            this.dgvrk.AllowUserToResizeRows = false;
            this.dgvrk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvrk.Location = new System.Drawing.Point(1, 0);
            this.dgvrk.Name = "dgvrk";
            this.dgvrk.ReadOnly = true;
            this.dgvrk.RowHeadersVisible = false;
            this.dgvrk.RowTemplate.Height = 23;
            this.dgvrk.Size = new System.Drawing.Size(503, 250);
            this.dgvrk.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "型号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "数量";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "供应商";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "存放货架";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // rktj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 250);
            this.Controls.Add(this.dgvrk);
            this.Controls.Add(this.cmbxh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbgys);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbsl);
            this.Controls.Add(this.cmbhj);
            this.Controls.Add(this.cmbspm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rktj";
            this.Text = "入库信息";
            this.Load += new System.EventHandler(this.rktj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbspm;
        private System.Windows.Forms.ComboBox cmbhj;
        private System.Windows.Forms.TextBox txbsl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbgys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxh;
        private System.Windows.Forms.DataGridView dgvrk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}