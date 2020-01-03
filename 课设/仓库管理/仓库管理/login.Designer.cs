namespace 仓库管理
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.zhbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mmbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dlton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zhbox
            // 
            this.zhbox.Location = new System.Drawing.Point(96, 53);
            this.zhbox.Name = "zhbox";
            this.zhbox.Size = new System.Drawing.Size(100, 21);
            this.zhbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "帐号：";
            // 
            // mmbox
            // 
            this.mmbox.Location = new System.Drawing.Point(96, 97);
            this.mmbox.Name = "mmbox";
            this.mmbox.Size = new System.Drawing.Size(100, 21);
            this.mmbox.TabIndex = 4;
            this.mmbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(49, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // dlton
            // 
            this.dlton.Location = new System.Drawing.Point(52, 157);
            this.dlton.Name = "dlton";
            this.dlton.Size = new System.Drawing.Size(75, 23);
            this.dlton.TabIndex = 5;
            this.dlton.Text = "登录";
            this.dlton.UseVisualStyleBackColor = true;
            this.dlton.Click += new System.EventHandler(this.dlton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dlton);
            this.Controls.Add(this.mmbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zhbox);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zhbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mmbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dlton;
        private System.Windows.Forms.Button button2;
    }
}

