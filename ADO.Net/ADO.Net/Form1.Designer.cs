namespace ADO.Net
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
            this.btnExeNoQuery = new System.Windows.Forms.Button();
            this.btnExeScalar = new System.Windows.Forms.Button();
            this.btnExeReader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExeNoQuery
            // 
            this.btnExeNoQuery.Location = new System.Drawing.Point(47, 28);
            this.btnExeNoQuery.Name = "btnExeNoQuery";
            this.btnExeNoQuery.Size = new System.Drawing.Size(154, 23);
            this.btnExeNoQuery.TabIndex = 0;
            this.btnExeNoQuery.Text = "ExecuteNoQuery";
            this.btnExeNoQuery.UseVisualStyleBackColor = true;
            this.btnExeNoQuery.Click += new System.EventHandler(this.btnExeNoQuery_Click);
            // 
            // btnExeScalar
            // 
            this.btnExeScalar.Location = new System.Drawing.Point(47, 83);
            this.btnExeScalar.Name = "btnExeScalar";
            this.btnExeScalar.Size = new System.Drawing.Size(154, 23);
            this.btnExeScalar.TabIndex = 1;
            this.btnExeScalar.Text = "ExecuteScalar";
            this.btnExeScalar.UseVisualStyleBackColor = true;
            this.btnExeScalar.Click += new System.EventHandler(this.btnExeScalar_Click);
            // 
            // btnExeReader
            // 
            this.btnExeReader.Location = new System.Drawing.Point(47, 135);
            this.btnExeReader.Name = "btnExeReader";
            this.btnExeReader.Size = new System.Drawing.Size(154, 23);
            this.btnExeReader.TabIndex = 2;
            this.btnExeReader.Text = "ExecuteReader";
            this.btnExeReader.UseVisualStyleBackColor = true;
            this.btnExeReader.Click += new System.EventHandler(this.btnExeReader_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExeReader);
            this.Controls.Add(this.btnExeScalar);
            this.Controls.Add(this.btnExeNoQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExeNoQuery;
        private System.Windows.Forms.Button btnExeScalar;
        private System.Windows.Forms.Button btnExeReader;
    }
}

