namespace cmcc_counter
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.time_remain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.time_remain_mini = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.tb_time_remain = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_open_ppt = new System.Windows.Forms.Button();
            this.btn_close_ppt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // time_remain
            // 
            this.time_remain.Font = new System.Drawing.Font("微软雅黑", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_remain.ForeColor = System.Drawing.Color.Red;
            this.time_remain.Location = new System.Drawing.Point(12, 179);
            this.time_remain.Name = "time_remain";
            this.time_remain.Size = new System.Drawing.Size(399, 172);
            this.time_remain.TabIndex = 0;
            this.time_remain.Text = "0000";
            this.time_remain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "剩余时间：";
            // 
            // time_remain_mini
            // 
            this.time_remain_mini.AutoSize = true;
            this.time_remain_mini.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_remain_mini.Location = new System.Drawing.Point(365, 251);
            this.time_remain_mini.Name = "time_remain_mini";
            this.time_remain_mini.Size = new System.Drawing.Size(164, 83);
            this.time_remain_mini.TabIndex = 2;
            this.time_remain_mini.Text = ".000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(516, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 172);
            this.label2.TabIndex = 3;
            this.label2.Text = "秒";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_start.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_start.Location = new System.Drawing.Point(591, 465);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(152, 76);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tb_time_remain
            // 
            this.tb_time_remain.Location = new System.Drawing.Point(122, 504);
            this.tb_time_remain.Name = "tb_time_remain";
            this.tb_time_remain.Size = new System.Drawing.Size(100, 21);
            this.tb_time_remain.TabIndex = 5;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reset.Location = new System.Drawing.Point(411, 465);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(152, 76);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "倒计时设置：";
            // 
            // timer1
            // 
            this.timer1.Interval = 9;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_open_ppt
            // 
            this.btn_open_ppt.Location = new System.Drawing.Point(283, 465);
            this.btn_open_ppt.Name = "btn_open_ppt";
            this.btn_open_ppt.Size = new System.Drawing.Size(93, 38);
            this.btn_open_ppt.TabIndex = 8;
            this.btn_open_ppt.Text = "打开PPT";
            this.btn_open_ppt.UseVisualStyleBackColor = true;
            this.btn_open_ppt.Click += new System.EventHandler(this.btn_open_ppt_Click);
            // 
            // btn_close_ppt
            // 
            this.btn_close_ppt.Location = new System.Drawing.Point(283, 509);
            this.btn_close_ppt.Name = "btn_close_ppt";
            this.btn_close_ppt.Size = new System.Drawing.Size(93, 41);
            this.btn_close_ppt.TabIndex = 9;
            this.btn_close_ppt.Text = "关闭PPT";
            this.btn_close_ppt.UseVisualStyleBackColor = true;
            this.btn_close_ppt.Click += new System.EventHandler(this.btn_close_ppt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btn_close_ppt);
            this.Controls.Add(this.btn_open_ppt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tb_time_remain);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time_remain_mini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_remain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CMCC计时器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_remain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time_remain_mini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox tb_time_remain;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_open_ppt;
        private System.Windows.Forms.Button btn_close_ppt;
    }
}

