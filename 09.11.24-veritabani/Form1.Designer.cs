namespace _09._11._24_veritabani
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOgrenci = new DataGridView();
            txtAra = new TextBox();
            txtNo = new TextBox();
            txtAd = new TextBox();
            txtPuan = new TextBox();
            rbKiz = new RadioButton();
            rbErkek = new RadioButton();
            dtpDogumTarih = new DateTimePicker();
            cmbSinif = new ComboBox();
            txtSoyad = new TextBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenci).BeginInit();
            SuspendLayout();
            // 
            // dgvOgrenci
            // 
            dgvOgrenci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenci.Location = new Point(-3, 127);
            dgvOgrenci.Name = "dgvOgrenci";
            dgvOgrenci.Size = new Size(809, 329);
            dgvOgrenci.TabIndex = 0;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(552, 12);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(175, 23);
            txtAra.TabIndex = 1;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(56, 9);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(121, 23);
            txtNo.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(56, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(121, 23);
            txtAd.TabIndex = 1;
            // 
            // txtPuan
            // 
            txtPuan.Location = new Point(332, 46);
            txtPuan.Name = "txtPuan";
            txtPuan.Size = new Size(121, 23);
            txtPuan.TabIndex = 1;
            // 
            // rbKiz
            // 
            rbKiz.AutoSize = true;
            rbKiz.Location = new Point(199, 71);
            rbKiz.Name = "rbKiz";
            rbKiz.Size = new Size(40, 19);
            rbKiz.TabIndex = 2;
            rbKiz.TabStop = true;
            rbKiz.Text = "Kız";
            rbKiz.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(199, 96);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(53, 19);
            rbErkek.TabIndex = 2;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarih
            // 
            dtpDogumTarih.Location = new Point(295, 96);
            dtpDogumTarih.Name = "dtpDogumTarih";
            dtpDogumTarih.Size = new Size(194, 23);
            dtpDogumTarih.TabIndex = 3;
            // 
            // cmbSinif
            // 
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(56, 96);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(121, 23);
            cmbSinif.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(56, 67);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(121, 23);
            txtSoyad.TabIndex = 1;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(629, 74);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(98, 23);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(521, 100);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(206, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(521, 72);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(98, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 6;
            label1.Text = "No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 43);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 72);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Soyisim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 102);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Sınıf";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 28);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 6;
            label5.Text = "Puan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 49);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 6;
            label6.Text = "Cinsiyet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 78);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 6;
            label7.Text = "Doğum Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(521, 15);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 6;
            label8.Text = "Ara";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 450);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(cmbSinif);
            Controls.Add(dtpDogumTarih);
            Controls.Add(rbErkek);
            Controls.Add(rbKiz);
            Controls.Add(txtSoyad);
            Controls.Add(txtPuan);
            Controls.Add(txtAd);
            Controls.Add(txtNo);
            Controls.Add(txtAra);
            Controls.Add(dgvOgrenci);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOgrenci;
        private TextBox txtAra;
        private TextBox txtNo;
        private TextBox txtAd;
        private TextBox txtPuan;
        private RadioButton rbKiz;
        private RadioButton rbErkek;
        private DateTimePicker dtpDogumTarih;
        private ComboBox cmbSinif;
        private TextBox txtSoyad;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
