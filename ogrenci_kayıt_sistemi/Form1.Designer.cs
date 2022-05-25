
namespace ogrenci_kayıt_sistemi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskOgretmenNumara = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskOgrenciNumara = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnOgretmenGiris = new System.Windows.Forms.Button();
            this.BtnOgrGiris = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.BtnOgretmenGiris);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TxtOgretmenSifre);
            this.groupBox1.Controls.Add(this.MskOgretmenNumara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRETMEN";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.BtnOgrGiris);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.TxtOgrenciSifre);
            this.groupBox2.Controls.Add(this.MskOgrenciNumara);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(37, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÖĞRENCİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE";
            // 
            // MskOgretmenNumara
            // 
            this.MskOgretmenNumara.Location = new System.Drawing.Point(443, 42);
            this.MskOgretmenNumara.Name = "MskOgretmenNumara";
            this.MskOgretmenNumara.Size = new System.Drawing.Size(100, 20);
            this.MskOgretmenNumara.TabIndex = 2;
            // 
            // TxtOgretmenSifre
            // 
            this.TxtOgretmenSifre.Location = new System.Drawing.Point(443, 106);
            this.TxtOgretmenSifre.Name = "TxtOgretmenSifre";
            this.TxtOgretmenSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtOgretmenSifre.TabIndex = 3;
            this.TxtOgretmenSifre.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 203);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NUMARA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ŞİFRE";
            // 
            // MskOgrenciNumara
            // 
            this.MskOgrenciNumara.Location = new System.Drawing.Point(459, 65);
            this.MskOgrenciNumara.Name = "MskOgrenciNumara";
            this.MskOgrenciNumara.Size = new System.Drawing.Size(100, 20);
            this.MskOgrenciNumara.TabIndex = 2;
            // 
            // TxtOgrenciSifre
            // 
            this.TxtOgrenciSifre.Location = new System.Drawing.Point(459, 132);
            this.TxtOgrenciSifre.Name = "TxtOgrenciSifre";
            this.TxtOgrenciSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtOgrenciSifre.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 210);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // BtnOgretmenGiris
            // 
            this.BtnOgretmenGiris.Location = new System.Drawing.Point(443, 191);
            this.BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            this.BtnOgretmenGiris.Size = new System.Drawing.Size(100, 38);
            this.BtnOgretmenGiris.TabIndex = 5;
            this.BtnOgretmenGiris.Text = "GİRİŞ YAP";
            this.BtnOgretmenGiris.UseVisualStyleBackColor = true;
            this.BtnOgretmenGiris.Click += new System.EventHandler(this.BtnOgretmenGiris_Click);
            // 
            // BtnOgrGiris
            // 
            this.BtnOgrGiris.Location = new System.Drawing.Point(459, 197);
            this.BtnOgrGiris.Name = "BtnOgrGiris";
            this.BtnOgrGiris.Size = new System.Drawing.Size(100, 38);
            this.BtnOgrGiris.TabIndex = 5;
            this.BtnOgrGiris.Text = "GİRİŞ YAP";
            this.BtnOgrGiris.UseVisualStyleBackColor = true;
            this.BtnOgrGiris.Click += new System.EventHandler(this.BtnOgrGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnOgretmenGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtOgretmenSifre;
        private System.Windows.Forms.MaskedTextBox MskOgretmenNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOgrGiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtOgrenciSifre;
        private System.Windows.Forms.MaskedTextBox MskOgrenciNumara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

