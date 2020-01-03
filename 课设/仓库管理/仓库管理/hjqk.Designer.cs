namespace 仓库管理
{
    partial class hjqk
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.comboxhjbh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toncx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowTemplate.Height = 23;
            this.dg.Size = new System.Drawing.Size(800, 177);
            this.dg.TabIndex = 0;
            // 
            // comboxhjbh
            // 
            this.comboxhjbh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxhjbh.FormattingEnabled = true;
            this.comboxhjbh.Location = new System.Drawing.Point(398, 183);
            this.comboxhjbh.Name = "comboxhjbh";
            this.comboxhjbh.Size = new System.Drawing.Size(67, 20);
            this.comboxhjbh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "货架编号：";
            // 
            // toncx
            // 
            this.toncx.Location = new System.Drawing.Point(364, 212);
            this.toncx.Name = "toncx";
            this.toncx.Size = new System.Drawing.Size(75, 23);
            this.toncx.TabIndex = 3;
            this.toncx.Text = "查询";
            this.toncx.UseVisualStyleBackColor = true;
            this.toncx.Click += new System.EventHandler(this.toncx_Click);
            // 
            // hjqk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 262);
            this.Controls.Add(this.toncx);
            this.Controls.Add(this.comboxhjbh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hjqk";
            this.Text = "hjqk";
            this.Load += new System.EventHandler(this.hjqk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox comboxhjbh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toncx;
    }
}