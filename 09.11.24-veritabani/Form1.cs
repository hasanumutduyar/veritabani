using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _09._11._24_veritabani
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=hasan;Uid=hasan;Pwd='123';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        string cinsiyet; //radioButtonlardan se�ilen cinsiyeti tek karakter olarak tutaca��z.
        public Form1()
        {
            InitializeComponent();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM ogrenci", conn);
            adapter.Fill(dt);
            dgvOgrenci.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "yazilimkodlama.com";
            VeriGetir();
            rbKiz.Checked = true; //K�z se�ene�i ilk a��l��ta se�ili olarak gelecektir.
            txtNo.Enabled = false;
        }
        private void rbKiz_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "K"; //K�z se�ene�i t�kland���nda global olarak tan�mlanan
                            //cinsiyet de�i�keni i�ine K atanacakt�r.
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "E"; //Erkek se�ene�i t�kland���nda global olarak tan�mlanan
                            //cinsiyet de�i�keni i�ine E atanacakt�r.
        }

        private void dgvOgrenci_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNo.Text = dgvOgrenci.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dgvOgrenci.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dgvOgrenci.CurrentRow.Cells[2].Value.ToString();
                string cins = dgvOgrenci.CurrentRow.Cells[3].Value.ToString();
                if (cins == "K")
                {
                    rbKiz.Checked = true;
                    rbErkek.Checked = false;                
                }
                else
                {
                    rbKiz.Checked = false;
                    rbErkek.Checked = true;                
                }
                dtpDogumTarih.Value = Convert.ToDateTime(dgvOgrenci.CurrentRow.Cells[4].Value);
                cmbSinif.Text = dgvOgrenci.CurrentRow.Cells[5].Value.ToString();
                txtPuan.Text = dgvOgrenci.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {

            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Ad ve Soyad kontrol�
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanlar� bo� b�rak�lamaz.");
                return;
            }

            // Puan kontrol�
            if (!int.TryParse(txtPuan.Text, out int puan))
            {
                MessageBox.Show("Puan ge�erli bir say� olmal�d�r.");
                return;
            }

            // S�n�f se�imi kontrol�
            if (string.IsNullOrEmpty(cmbSinif.Text))
            {
                MessageBox.Show("L�tfen bir s�n�f se�in.");
                return;
            }

            //veritaban�na kay�t i�lemi
            string sorgu = "Insert into ogrenci (ograd,ogrsoyad,cinsiyet,dtarih,sinif,puan) values (@ad,@soyad,@cinsiyet,@dtarih,@sinif,@puan)";
            cmd = new MySqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@dtarih", dtpDogumTarih.Value);
            cmd.Parameters.AddWithValue("@sinif", cmbSinif.Text);
            cmd.Parameters.AddWithValue("@puan", Convert.ToInt32(txtPuan.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kay�t Eklendi.");
        }



        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("ograd LIKE '{0}%' OR ogrsoyad LIKE '{0}%'", txtAra.Text);
            dgvOgrenci.DataSource = dv;
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            string sql = "Delete From ogrenci Where ogrno=@no";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@no", Convert.ToInt32(txtNo.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kay�t silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE ogrenci " +
            "SET ograd=@ad,ogrsoyad=@soyad,cinsiyet=@cinsiyet,dtarih=@dtarih,sinif=@sinif,puan=@puan" +
            " WHERE ogrno=@no";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@dtarih", dtpDogumTarih.Value);
            cmd.Parameters.AddWithValue("@sinif", cmbSinif.Text);
            cmd.Parameters.AddWithValue("@puan", Convert.ToInt32(txtPuan.Text));
            cmd.Parameters.AddWithValue("@no", Convert.ToInt32(txtNo.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kay�t g�ncellendi.");

        }
    }
}
