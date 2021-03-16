namespace FilterController
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.wavelengthBar = new System.Windows.Forms.TrackBar();
            this.lb_MinWavelength = new System.Windows.Forms.Label();
            this.lb_MaxWavelength = new System.Windows.Forms.Label();
            this.lb_CurrentWavelength = new System.Windows.Forms.Label();
            this.btn_Narrow = new System.Windows.Forms.Button();
            this.btn_Medium = new System.Windows.Forms.Button();
            this.btn_Wide = new System.Windows.Forms.Button();
            this.btn_Black = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wavelengthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Red;
            this.btn_connect.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(12, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(143, 54);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.On_Test);
            // 
            // wavelengthBar
            // 
            this.wavelengthBar.Location = new System.Drawing.Point(315, 21);
            this.wavelengthBar.Maximum = 600;
            this.wavelengthBar.Minimum = 420;
            this.wavelengthBar.Name = "wavelengthBar";
            this.wavelengthBar.Size = new System.Drawing.Size(295, 45);
            this.wavelengthBar.TabIndex = 1;
            this.wavelengthBar.Value = 420;
            this.wavelengthBar.ValueChanged += new System.EventHandler(this.On_Change);
            // 
            // lb_MinWavelength
            // 
            this.lb_MinWavelength.AutoSize = true;
            this.lb_MinWavelength.Location = new System.Drawing.Point(313, 54);
            this.lb_MinWavelength.Name = "lb_MinWavelength";
            this.lb_MinWavelength.Size = new System.Drawing.Size(0, 12);
            this.lb_MinWavelength.TabIndex = 2;
            this.lb_MinWavelength.Visible = false;
            // 
            // lb_MaxWavelength
            // 
            this.lb_MaxWavelength.AutoSize = true;
            this.lb_MaxWavelength.Location = new System.Drawing.Point(582, 54);
            this.lb_MaxWavelength.Name = "lb_MaxWavelength";
            this.lb_MaxWavelength.Size = new System.Drawing.Size(0, 12);
            this.lb_MaxWavelength.TabIndex = 3;
            this.lb_MaxWavelength.Visible = false;
            // 
            // lb_CurrentWavelength
            // 
            this.lb_CurrentWavelength.AutoSize = true;
            this.lb_CurrentWavelength.Location = new System.Drawing.Point(439, 9);
            this.lb_CurrentWavelength.Name = "lb_CurrentWavelength";
            this.lb_CurrentWavelength.Size = new System.Drawing.Size(0, 12);
            this.lb_CurrentWavelength.TabIndex = 4;
            this.lb_CurrentWavelength.Visible = false;
            // 
            // btn_Narrow
            // 
            this.btn_Narrow.Location = new System.Drawing.Point(255, 72);
            this.btn_Narrow.Name = "btn_Narrow";
            this.btn_Narrow.Size = new System.Drawing.Size(75, 23);
            this.btn_Narrow.TabIndex = 5;
            this.btn_Narrow.Text = "narrow";
            this.btn_Narrow.UseVisualStyleBackColor = true;
            this.btn_Narrow.Click += new System.EventHandler(this.On_NarrowMode);
            // 
            // btn_Medium
            // 
            this.btn_Medium.Location = new System.Drawing.Point(375, 72);
            this.btn_Medium.Name = "btn_Medium";
            this.btn_Medium.Size = new System.Drawing.Size(75, 23);
            this.btn_Medium.TabIndex = 6;
            this.btn_Medium.Text = "medium";
            this.btn_Medium.UseVisualStyleBackColor = true;
            this.btn_Medium.Click += new System.EventHandler(this.On_MidiumMode);
            // 
            // btn_Wide
            // 
            this.btn_Wide.Location = new System.Drawing.Point(495, 72);
            this.btn_Wide.Name = "btn_Wide";
            this.btn_Wide.Size = new System.Drawing.Size(75, 23);
            this.btn_Wide.TabIndex = 7;
            this.btn_Wide.Text = "wide";
            this.btn_Wide.UseVisualStyleBackColor = true;
            this.btn_Wide.Click += new System.EventHandler(this.On_WideMode);
            // 
            // btn_Black
            // 
            this.btn_Black.Location = new System.Drawing.Point(615, 72);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(75, 23);
            this.btn_Black.TabIndex = 8;
            this.btn_Black.Text = "black";
            this.btn_Black.UseVisualStyleBackColor = true;
            this.btn_Black.Click += new System.EventHandler(this.On_BlackMode);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Black);
            this.Controls.Add(this.btn_Wide);
            this.Controls.Add(this.btn_Medium);
            this.Controls.Add(this.btn_Narrow);
            this.Controls.Add(this.lb_CurrentWavelength);
            this.Controls.Add(this.lb_MaxWavelength);
            this.Controls.Add(this.lb_MinWavelength);
            this.Controls.Add(this.wavelengthBar);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Kurios";
            ((System.ComponentModel.ISupportInitialize)(this.wavelengthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TrackBar wavelengthBar;
        private System.Windows.Forms.Label lb_MinWavelength;
        private System.Windows.Forms.Label lb_MaxWavelength;
        public System.Windows.Forms.Label lb_CurrentWavelength;
        private System.Windows.Forms.Button btn_Narrow;
        private System.Windows.Forms.Button btn_Medium;
        private System.Windows.Forms.Button btn_Wide;
        private System.Windows.Forms.Button btn_Black;
    }
}

