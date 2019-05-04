namespace QQMaiLlinkConvert
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
            this.convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TopcheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // convert
            // 
            this.convert.BackColor = System.Drawing.Color.Transparent;
            this.convert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.convert.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.convert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.convert.Location = new System.Drawing.Point(199, 72);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(256, 54);
            this.convert.TabIndex = 0;
            this.convert.Text = "转换链接并复制到剪贴板(&C)";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "复制QQ中转邮箱的下载链接后，点击下方按钮即可将链接转换为分享链接（快捷键:Ctrl+Q）";
            // 
            // TopcheckBox
            // 
            this.TopcheckBox.AutoSize = true;
            this.TopcheckBox.Checked = true;
            this.TopcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopcheckBox.Location = new System.Drawing.Point(34, 89);
            this.TopcheckBox.Name = "TopcheckBox";
            this.TopcheckBox.Size = new System.Drawing.Size(142, 22);
            this.TopcheckBox.TabIndex = 2;
            this.TopcheckBox.Text = "窗口是否置顶";
            this.TopcheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(477, 144);
            this.Controls.Add(this.TopcheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(499, 200);
            this.Name = "Form1";
            this.Text = "QQ邮箱中转站下载链接转分享链接";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TopcheckBox;
    }
}

