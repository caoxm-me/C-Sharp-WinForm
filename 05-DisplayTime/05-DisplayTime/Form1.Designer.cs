﻿namespace _05_DisplayTime
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
            this.btn_display = new System.Windows.Forms.Button();
            this.textTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_display
            // 
            this.btn_display.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_display.Location = new System.Drawing.Point(218, 105);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(242, 74);
            this.btn_display.TabIndex = 0;
            this.btn_display.Text = "Display Time";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.displayTime);
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(203, 229);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(321, 21);
            this.textTime.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.btn_display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.TextBox textTime;
    }
}

