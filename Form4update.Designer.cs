namespace TitansComic
{
    partial class Form4update
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4update));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb4hint = new System.Windows.Forms.Label();
            this.btn4rls = new System.Windows.Forms.Button();
            this.lb4ver = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(8, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Copyright © 2018 TitansComic.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // lb4hint
            // 
            this.lb4hint.Enabled = false;
            this.lb4hint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb4hint.Location = new System.Drawing.Point(8, 230);
            this.lb4hint.Name = "lb4hint";
            this.lb4hint.Size = new System.Drawing.Size(437, 47);
            this.lb4hint.TabIndex = 28;
            this.lb4hint.Text = "        您可以前往Github的Release页面下载最新编译打包，该下载的文件通常命名为TitansComic-0.X-win32.zip。";
            // 
            // btn4rls
            // 
            this.btn4rls.Enabled = false;
            this.btn4rls.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4rls.Location = new System.Drawing.Point(160, 287);
            this.btn4rls.Name = "btn4rls";
            this.btn4rls.Size = new System.Drawing.Size(132, 33);
            this.btn4rls.TabIndex = 27;
            this.btn4rls.Text = "前往下载页";
            this.btn4rls.Click += new System.EventHandler(this.btn4rls_Click);
            // 
            // lb4ver
            // 
            this.lb4ver.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb4ver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb4ver.Location = new System.Drawing.Point(8, 189);
            this.lb4ver.Name = "lb4ver";
            this.lb4ver.Size = new System.Drawing.Size(437, 27);
            this.lb4ver.TabIndex = 31;
            this.lb4ver.Text = "正在检查更新...";
            this.lb4ver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 363);
            this.Controls.Add(this.lb4ver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb4hint);
            this.Controls.Add(this.btn4rls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检查更新 for TitansComic";
            this.Load += new System.EventHandler(this.Form4update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb4hint;
        private System.Windows.Forms.Button btn4rls;
        private System.Windows.Forms.Label lb4ver;
        private System.Windows.Forms.Timer timer1;
    }
}