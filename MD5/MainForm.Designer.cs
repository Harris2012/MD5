namespace MD5
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelMD5 = new System.Windows.Forms.Label();
            this.SourceFileBox = new System.Windows.Forms.Label();
            this.btCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "MD5";
            // 
            // labelMD5
            // 
            this.labelMD5.Location = new System.Drawing.Point(41, 124);
            this.labelMD5.Name = "labelMD5";
            this.labelMD5.Size = new System.Drawing.Size(232, 12);
            this.labelMD5.TabIndex = 2;
            // 
            // SourceFileBox
            // 
            this.SourceFileBox.AllowDrop = true;
            this.SourceFileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SourceFileBox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceFileBox.Location = new System.Drawing.Point(12, 9);
            this.SourceFileBox.Name = "SourceFileBox";
            this.SourceFileBox.Size = new System.Drawing.Size(322, 104);
            this.SourceFileBox.TabIndex = 3;
            this.SourceFileBox.Text = "  请拖动文件至此以便获取其MD5值";
            this.SourceFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourceFileBox_DragDrop);
            this.SourceFileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourceFileBox_DragEnter);
            // 
            // btCopy
            // 
            this.btCopy.AutoSize = true;
            this.btCopy.Location = new System.Drawing.Point(292, 119);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(42, 23);
            this.btCopy.TabIndex = 4;
            this.btCopy.Text = "复制";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 147);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.SourceFileBox);
            this.Controls.Add(this.labelMD5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取MD5数值小程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMD5;
        private System.Windows.Forms.Label SourceFileBox;
        private System.Windows.Forms.Button btCopy;
    }
}

