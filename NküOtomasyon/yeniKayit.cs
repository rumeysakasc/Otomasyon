using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NküOtomasyon
{
   
    public partial class yeniKayit : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;
        public yeniKayit()
        {
            InitializeComponent();
        }

        

        void kayitlar()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-0SG48DE;Initial Catalog=KutuphaneOto;Integrated Security=True");
            baglanti.Open();
            adapter = new SqlDataAdapter("SELECT * FROM kayit", baglanti);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        void clear()
        {
            kayitNo.Clear();
            tcNo.Clear();
            adi.Clear();
            soyadi.Clear();
            telNo.Clear();
            kAdi.Clear();
            sifre.Clear();
            adrs.Clear();
        }
        private void yeniKayit_Load(object sender, EventArgs e)
        {
            kayitlar();
            clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            kayitNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tcNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            adi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            soyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            telNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kAdi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sifre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            adrs.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            foto.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            foto.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-0SG48DE;Initial Catalog=KutuphaneOto;Integrated Security=True");
            openFileDialog1.ShowDialog();
            foto.ImageLocation = openFileDialog1.FileName;
            foto.Text = openFileDialog1.FileName;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-0SG48DE;Initial Catalog=KutuphaneOto;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO kayit(tc,ad,soyad,tel,kullanici_adi,sifre,adres,foto) VALUES(@tc,@ad,@soyad,@tel,@kullanici_adi,@sifre,@adres,@foto)");
            komut.Parameters.AddWithValue("@tc", tcNo.Text);
            komut.Parameters.AddWithValue("@ad",adi.Text);
            komut.Parameters.AddWithValue("@soyad", soyadi.Text);
            komut.Parameters.AddWithValue("@tel", telNo.Text);
            komut.Parameters.AddWithValue("@kullanici_adi", kAdi.Text);
            komut.Parameters.AddWithValue("@sifre", sifre.Text);
            komut.Parameters.AddWithValue("@adres", adrs.Text);
            komut.Parameters.AddWithValue("@foto", foto.Text);
            komut.Connection = baglanti;
            if (string.IsNullOrWhiteSpace(tcNo.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayitlar();
            clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ekle = "DELETE FROM kayit WHERE kayit_no=@kayitNo";
            komut = new SqlCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@kayitNo", Convert.ToInt32(kayitNo.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayitlar();
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string ekle = "UPDATE kayit SET tc=@tc,ad=@ad,soyad=@soyad,tel=@tel,kullanici_adi=@kullanici_adi,sifre=@sifre,adres=@adres,foto=@foto WHERE kayit_no=@kayitNo";
            komut = new SqlCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@kayitNo", Convert.ToInt32(kayitNo.Text));
            komut.Parameters.AddWithValue("@tc", tcNo.Text);
            komut.Parameters.AddWithValue("@ad", adi.Text);
            komut.Parameters.AddWithValue("@soyad", soyadi.Text);
            komut.Parameters.AddWithValue("@tel", telNo.Text);
            komut.Parameters.AddWithValue("@kullanici_adi", kAdi.Text);
            komut.Parameters.AddWithValue("@sifre", sifre.Text);
            komut.Parameters.AddWithValue("@adres", adrs.Text);
            komut.Parameters.AddWithValue("@foto", foto.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayitlar();
            clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void foto_Click(object sender, EventArgs e)
        {
            
        }
    }
}
