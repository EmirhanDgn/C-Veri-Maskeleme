
namespace TextBoxtakiVeriyiMaskeleme
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
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaskele = new System.Windows.Forms.Button();
            this.btnMaskeAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(59, 59);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(118, 20);
            this.txtVeri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veri:";
            // 
            // btnMaskele
            // 
            this.btnMaskele.Location = new System.Drawing.Point(194, 43);
            this.btnMaskele.Name = "btnMaskele";
            this.btnMaskele.Size = new System.Drawing.Size(75, 23);
            this.btnMaskele.TabIndex = 2;
            this.btnMaskele.Text = "Maskele";
            this.btnMaskele.UseVisualStyleBackColor = true;
            this.btnMaskele.Click += new System.EventHandler(this.btnMaskele_Click);
            // 
            // btnMaskeAc
            // 
            this.btnMaskeAc.Location = new System.Drawing.Point(194, 72);
            this.btnMaskeAc.Name = "btnMaskeAc";
            this.btnMaskeAc.Size = new System.Drawing.Size(75, 23);
            this.btnMaskeAc.TabIndex = 3;
            this.btnMaskeAc.Text = "Maskeyi Aç";
            this.btnMaskeAc.UseVisualStyleBackColor = true;
            this.btnMaskeAc.Click += new System.EventHandler(this.btnMaskeAc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 138);
            this.Controls.Add(this.btnMaskeAc);
            this.Controls.Add(this.btnMaskele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaskele;
        private System.Windows.Forms.Button btnMaskeAc;
    }
}

