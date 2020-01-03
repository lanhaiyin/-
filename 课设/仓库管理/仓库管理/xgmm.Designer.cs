namespace 仓库管理
{
    partial class xgmm
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
            this.tontj = new System.Windows.Forms.Button();
            this.boxqrxmm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxxmm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxymm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tontj
            // 
            this.tontj.Location = new System.Drawing.Point(106, 183);
            this.tontj.Name = "tontj";
            this.tontj.Size = new System.Drawing.Size(75, 23);
            this.tontj.TabIndex = 13;
            this.tontj.Text = "提交修改";
            this.tontj.UseVisualStyleBackColor = true;
            this.tontj.Click += new System.EventHandler(this.tontj_Click);
            // 
            // boxqrxmm
            // 
            this.boxqrxmm.Location = new System.Drawing.Point(119, 134);
            this.boxqrxmm.Name = "boxqrxmm";
            this.boxqrxmm.Size = new System.Drawing.Size(100, 21);
            this.boxqrxmm.TabIndex = 11;
            this.boxqrxmm.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "确认新密码：";
            // 
            // boxxmm
            // 
            this.boxxmm.Location = new System.Drawing.Point(119, 92);
            this.boxxmm.Name = "boxxmm";
            this.boxxmm.Size = new System.Drawing.Size(100, 21);
            this.boxxmm.TabIndex = 9;
            this.boxxmm.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(66, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "新密码：";
            // 
            // boxymm
            // 
            this.boxymm.Location = new System.Drawing.Point(119, 45);
            this.boxymm.Name = "boxymm";
            this.boxymm.Size = new System.Drawing.Size(100, 21);
            this.boxymm.TabIndex = 7;
            this.boxymm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "原密码：";
            // 
            // xgmm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tontj);
            this.Controls.Add(this.boxqrxmm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxxmm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxymm);
            this.Controls.Add(this.label1);
            this.Name = "xgmm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "xgmm";
            this.Load += new System.EventHandler(this.xgmm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tontj;
        private System.Windows.Forms.TextBox boxqrxmm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxxmm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxymm;
        private System.Windows.Forms.Label label1;
    }
}