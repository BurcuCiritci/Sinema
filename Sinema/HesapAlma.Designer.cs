namespace Sinema
{
    partial class HesapAlma
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
            this.btnHsp = new System.Windows.Forms.Button();
            this.lblOgr = new System.Windows.Forms.Label();
            this.txtOgr = new System.Windows.Forms.TextBox();
            this.lblGozluk = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.txtGozluk = new System.Windows.Forms.TextBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHsp
            // 
            this.btnHsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHsp.Location = new System.Drawing.Point(51, 190);
            this.btnHsp.Name = "btnHsp";
            this.btnHsp.Size = new System.Drawing.Size(132, 35);
            this.btnHsp.TabIndex = 0;
            this.btnHsp.Text = "HESAPLA";
            this.btnHsp.UseVisualStyleBackColor = true;
            this.btnHsp.Click += new System.EventHandler(this.btnHsp_Click);
            // 
            // lblOgr
            // 
            this.lblOgr.AutoSize = true;
            this.lblOgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgr.Location = new System.Drawing.Point(46, 45);
            this.lblOgr.Name = "lblOgr";
            this.lblOgr.Size = new System.Drawing.Size(145, 25);
            this.lblOgr.TabIndex = 1;
            this.lblOgr.Text = "Öğrenci Sayısı:";
            // 
            // txtOgr
            // 
            this.txtOgr.Location = new System.Drawing.Point(234, 49);
            this.txtOgr.Name = "txtOgr";
            this.txtOgr.Size = new System.Drawing.Size(101, 20);
            this.txtOgr.TabIndex = 2;
            // 
            // lblGozluk
            // 
            this.lblGozluk.AutoSize = true;
            this.lblGozluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGozluk.Location = new System.Drawing.Point(47, 86);
            this.lblGozluk.Name = "lblGozluk";
            this.lblGozluk.Size = new System.Drawing.Size(79, 25);
            this.lblGozluk.TabIndex = 3;
            this.lblGozluk.Text = "Gözlük:";
            this.lblGozluk.Click += new System.EventHandler(this.lblGozluk_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(46, 128);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(68, 25);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Menü:";
            // 
            // txtGozluk
            // 
            this.txtGozluk.Location = new System.Drawing.Point(234, 92);
            this.txtGozluk.Name = "txtGozluk";
            this.txtGozluk.Size = new System.Drawing.Size(102, 20);
            this.txtGozluk.TabIndex = 5;
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(235, 133);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(100, 20);
            this.txtMenu.TabIndex = 6;
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(194, 241);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(132, 34);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(189, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOPLAM :";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(323, 195);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(23, 25);
            this.lblToplam.TabIndex = 9;
            this.lblToplam.Text = "0";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOk.Location = new System.Drawing.Point(51, 241);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(132, 34);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "TAMAM";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // HesapAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 309);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.txtGozluk);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblGozluk);
            this.Controls.Add(this.txtOgr);
            this.Controls.Add(this.lblOgr);
            this.Controls.Add(this.btnHsp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HesapAlma";
            this.Text = "HesapAlma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHsp;
        private System.Windows.Forms.Label lblOgr;
        private System.Windows.Forms.TextBox txtOgr;
        private System.Windows.Forms.Label lblGozluk;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.TextBox txtGozluk;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnOk;
    }
}