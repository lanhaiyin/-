namespace 仓库管理
{
    partial class cktj
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
            this.dgvck = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbspm = new System.Windows.Forms.ComboBox();
            this.cmdxh = new System.Windows.Forms.ComboBox();
            this.cmbhj = new System.Windows.Forms.ComboBox();
            this.cmbshr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.Label();
            this.txbsl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvck)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvck
            // 
            this.dgvck.AllowUserToAddRows = false;
            this.dgvck.AllowUserToDeleteRows = false;
            this.dgvck.AllowUserToResizeColumns = false;
            this.dgvck.AllowUserToResizeRows = false;
            this.dgvck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvck.Location = new System.Drawing.Point(1, 0);
            this.dgvck.Name = "dgvck";
            this.dgvck.ReadOnly = true;
            this.dgvck.RowHeadersVisible = false;
            this.dgvck.RowTemplate.Height = 23;
            this.dgvck.Size = new System.Drawing.Size(504, 250);
            this.dgvck.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "规格";
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
            this.Column4.HeaderText = "存放货架";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "客户";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cmbspm
            // 
            this.cmbspm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbspm.FormattingEnabled = true;
            this.cmbspm.Location = new System.Drawing.Point(629, 21);
            this.cmbspm.Name = "cmbspm";
            this.cmbspm.Size = new System.Drawing.Size(121, 20);
            this.cmbspm.TabIndex = 0;
            this.cmbspm.SelectionChangeCommitted += new System.EventHandler(this.cmbspm_SelectionChangeCommitted);
            this.cmbspm.Leave += new System.EventHandler(this.cmbspm_Leave);
            // 
            // cmdxh
            // 
            this.cmdxh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdxh.FormattingEnabled = true;
            this.cmdxh.Location = new System.Drawing.Point(629, 60);
            this.cmdxh.Name = "cmdxh";
            this.cmdxh.Size = new System.Drawing.Size(121, 20);
            this.cmdxh.TabIndex = 2;
            this.cmdxh.SelectionChangeCommitted += new System.EventHandler(this.cmdxh_SelectionChangeCommitted);
            // 
            // cmbhj
            // 
            this.cmbhj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhj.FormattingEnabled = true;
            this.cmbhj.Location = new System.Drawing.Point(629, 100);
            this.cmbhj.Name = "cmbhj";
            this.cmbhj.Size = new System.Drawing.Size(121, 20);
            this.cmbhj.TabIndex = 4;
            this.cmbhj.SelectionChangeCommitted += new System.EventHandler(this.cmbhj_SelectionChangeCommitted);
            // 
            // cmbshr
            // 
            this.cmbshr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbshr.FormattingEnabled = true;
            this.cmbshr.Location = new System.Drawing.Point(629, 176);
            this.cmbshr.Name = "cmbshr";
            this.cmbshr.Size = new System.Drawing.Size(121, 20);
            this.cmbshr.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "规格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "存放货架";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "客户";
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Location = new System.Drawing.Point(687, 143);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(0, 12);
            this.sl.TabIndex = 11;
            // 
            // txbsl
            // 
            this.txbsl.Location = new System.Drawing.Point(629, 139);
            this.txbsl.Name = "txbsl";
            this.txbsl.Size = new System.Drawing.Size(53, 21);
            this.txbsl.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cktj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbsl);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbshr);
            this.Controls.Add(this.cmbhj);
            this.Controls.Add(this.cmdxh);
            this.Controls.Add(this.cmbspm);
            this.Controls.Add(this.dgvck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cktj";
            this.Text = "cktj";
            this.Load += new System.EventHandler(this.cktj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvck;
        private System.Windows.Forms.ComboBox cmbspm;
        private System.Windows.Forms.ComboBox cmdxh;
        private System.Windows.Forms.ComboBox cmbhj;
        private System.Windows.Forms.ComboBox cmbshr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sl;
        private System.Windows.Forms.TextBox txbsl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}