namespace _5.unite_uygulama_21
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
            this.btnVeri = new System.Windows.Forms.Button();
            this.listVeriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVeri
            // 
            this.btnVeri.Location = new System.Drawing.Point(116, 49);
            this.btnVeri.Name = "btnVeri";
            this.btnVeri.Size = new System.Drawing.Size(75, 23);
            this.btnVeri.TabIndex = 0;
            this.btnVeri.Text = "veri";
            this.btnVeri.UseVisualStyleBackColor = true;
            this.btnVeri.Click += new System.EventHandler(this.btnVeri_Click);
            // 
            // listVeriler
            // 
            this.listVeriler.FormattingEnabled = true;
            this.listVeriler.Location = new System.Drawing.Point(241, 37);
            this.listVeriler.Name = "listVeriler";
            this.listVeriler.Size = new System.Drawing.Size(120, 95);
            this.listVeriler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listVeriler);
            this.Controls.Add(this.btnVeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeri;
        private System.Windows.Forms.ListBox listVeriler;
    }
}

