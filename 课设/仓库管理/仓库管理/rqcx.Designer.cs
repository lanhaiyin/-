namespace 仓库管理
{
    partial class rqcx
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
            this.dateTimecx = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toncx = new System.Windows.Forms.Button();
            this.dg2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(0, 1);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowTemplate.Height = 23;
            this.dg.Size = new System.Drawing.Size(800, 171);
            this.dg.TabIndex = 0;
            // 
            // dateTimecx
            // 
            this.dateTimecx.Location = new System.Drawing.Point(360, 372);
            this.dateTimecx.Name = "dateTimecx";
            this.dateTimecx.Size = new System.Drawing.Size(109, 21);
            this.dateTimecx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "日期查询：";
            // 
            // toncx
            // 
            this.toncx.Location = new System.Drawing.Point(337, 399);
            this.toncx.Name = "toncx";
            this.toncx.Size = new System.Drawing.Size(75, 23);
            this.toncx.TabIndex = 3;
            this.toncx.Text = "查询";
            this.toncx.UseVisualStyleBackColor = true;
            this.toncx.Click += new System.EventHandler(this.toncx_Click);
            // 
            // dg2
            // 
            this.dg2.AllowUserToAddRows = false;
            this.dg2.AllowUserToDeleteRows = false;
            this.dg2.AllowUserToResizeColumns = false;
            this.dg2.AllowUserToResizeRows = false;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(0, 173);
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.RowTemplate.Height = 23;
            this.dg2.Size = new System.Drawing.Size(800, 171);
            this.dg2.TabIndex = 4;
            // 
            // rqcx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.toncx);
            this.Controls.Add(this.dateTimecx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rqcx";
            this.Text = "rqcx";
            this.Load += new System.EventHandler(this.rqcx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DateTimePicker dateTimecx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toncx;
        private System.Windows.Forms.DataGridView dg2;
    }
}