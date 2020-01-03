namespace 仓库管理
{
    partial class ckdh
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
            this.boxcx = new System.Windows.Forms.Button();
            this.comboxrkdh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // boxcx
            // 
            this.boxcx.Location = new System.Drawing.Point(369, 227);
            this.boxcx.Name = "boxcx";
            this.boxcx.Size = new System.Drawing.Size(75, 23);
            this.boxcx.TabIndex = 8;
            this.boxcx.Text = "查询";
            this.boxcx.UseVisualStyleBackColor = true;
            this.boxcx.Click += new System.EventHandler(this.boxcx_Click);
            // 
            // comboxrkdh
            // 
            this.comboxrkdh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxrkdh.FormattingEnabled = true;
            this.comboxrkdh.Location = new System.Drawing.Point(384, 179);
            this.comboxrkdh.Name = "comboxrkdh";
            this.comboxrkdh.Size = new System.Drawing.Size(93, 20);
            this.comboxrkdh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "出库单号：";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(7, 1);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.RowTemplate.Height = 23;
            this.dg.Size = new System.Drawing.Size(800, 162);
            this.dg.TabIndex = 5;
            // 
            // ckdh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 262);
            this.Controls.Add(this.boxcx);
            this.Controls.Add(this.comboxrkdh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ckdh";
            this.Text = "ckdh";
            this.Load += new System.EventHandler(this.ckdh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boxcx;
        private System.Windows.Forms.ComboBox comboxrkdh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg;
    }
}