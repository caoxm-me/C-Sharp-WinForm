namespace _13_CheckBox
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.isPasswdShow = new System.Windows.Forms.CheckBox();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // isPasswdShow
            // 
            this.isPasswdShow.AutoSize = true;
            this.isPasswdShow.Location = new System.Drawing.Point(263, 165);
            this.isPasswdShow.Name = "isPasswdShow";
            this.isPasswdShow.Size = new System.Drawing.Size(72, 16);
            this.isPasswdShow.TabIndex = 0;
            this.isPasswdShow.Text = "显示密码";
            this.isPasswdShow.UseVisualStyleBackColor = true;
            this.isPasswdShow.CheckedChanged += new System.EventHandler(this.isPasswdShow_CheckedChanged);
            // 
            // passwdBox
            // 
            this.passwdBox.Location = new System.Drawing.Point(250, 105);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.PasswordChar = '*';
            this.passwdBox.Size = new System.Drawing.Size(100, 21);
            this.passwdBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwdBox);
            this.Controls.Add(this.isPasswdShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox isPasswdShow;
        private System.Windows.Forms.TextBox passwdBox;
    }
}

