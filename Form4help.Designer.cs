namespace TitansComic
{
    partial class Form4help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4help));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn4pdf = new System.Windows.Forms.Button();
            this.btn4chm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Copyright © 2018 TitansComic.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "请选择您支持的帮助文档格式";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn4pdf
            // 
            this.btn4pdf.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4pdf.Location = new System.Drawing.Point(12, 240);
            this.btn4pdf.Name = "btn4pdf";
            this.btn4pdf.Size = new System.Drawing.Size(132, 33);
            this.btn4pdf.TabIndex = 22;
            this.btn4pdf.Text = "打开PDF文档";
            this.btn4pdf.Click += new System.EventHandler(this.btn4pdf_Click);
            // 
            // btn4chm
            // 
            this.btn4chm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4chm.Location = new System.Drawing.Point(162, 240);
            this.btn4chm.Name = "btn4chm";
            this.btn4chm.Size = new System.Drawing.Size(132, 33);
            this.btn4chm.TabIndex = 26;
            this.btn4chm.Text = "打开CHM文档";
            this.btn4chm.Click += new System.EventHandler(this.btn4chm_Click);
            // 
            // Form4help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 317);
            this.Controls.Add(this.btn4chm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn4pdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用帮助 for TitansComic";
            this.Load += new System.EventHandler(this.Form4help_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn4pdf;
        private System.Windows.Forms.Button btn4chm;
    }
}