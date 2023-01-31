namespace WebPageToPdfV2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edPath = new System.Windows.Forms.TextBox();
            this.edUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPdf.Location = new System.Drawing.Point(52, 117);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(186, 31);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "Save PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copy selector ( Chome )";
            // 
            // edPath
            // 
            this.edPath.Location = new System.Drawing.Point(23, 83);
            this.edPath.Name = "edPath";
            this.edPath.Size = new System.Drawing.Size(255, 20);
            this.edPath.TabIndex = 1;
            // 
            // edUrl
            // 
            this.edUrl.Location = new System.Drawing.Point(23, 33);
            this.edUrl.Name = "edUrl";
            this.edUrl.Size = new System.Drawing.Size(255, 20);
            this.edUrl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 173);
            this.Controls.Add(this.edUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Web to pdf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edPath;
        private System.Windows.Forms.TextBox edUrl;
        private System.Windows.Forms.Label label2;
    }
}

