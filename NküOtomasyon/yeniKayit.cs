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
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

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
            foto.Image = null;
            foto.BackgroundImage = null;
           


        }
        private void yeniKayit_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            foto.ImageLocation = null;

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

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    foto.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                }
            }
            else
            {
                foto.Image = null;
            }



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
            //tc aynıysa kaydetmeyecek aşağıdaki sorgu bunun için.
            SqlCommand kontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM kayit WHERE tc = @tc", baglanti);
            kontrolKomutu.Parameters.AddWithValue("@tc", tcNo.Text);
            int kayitSayisi = (int)kontrolKomutu.ExecuteScalar();

            if (kayitSayisi > 0)
            {
                MessageBox.Show("Bu TC numarasına sahip bir kayıt zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tcNo.Text)|| string.IsNullOrEmpty(kAdi.Text)||string.IsNullOrWhiteSpace(sifre.Text))
            {
                MessageBox.Show("Kullanıcı adı, şifre ve Tc boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
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
            if (string.IsNullOrWhiteSpace(kayitNo.Text))
            {
                MessageBox.Show("Silmek için seçim yapmanız gerekmektedir!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            komut = new SqlCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@kayitNo", Convert.ToInt32(kayitNo.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayitlar();
            clear();
                MessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleştirildi.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kayitNo.Text))
            {
                MessageBox.Show("Güncelleme yapabilmeniz için bir hücre seçmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string ekle = "UPDATE kayit SET tc=@tc,ad=@ad,soyad=@soyad,tel=@tel,kullanici_adi=@kullanici_adi,sifre=@sifre,adres=@adres,foto=@foto WHERE kayit_no=@kayitNo";
                komut = new SqlCommand(ekle, baglanti);
                komut.Parameters.AddWithValue("@kayitNo", kayitNo.Text);
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
                MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void foto_Click(object sender, EventArgs e)
        {
            foto.Image = null;
        }
  
        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isDragging;
        private Point lastLocation;
        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = e.Location.X - lastLocation.X;
                int dy = e.Location.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void yeniKayit_MouseClick(object sender, MouseEventArgs e)
        {
            if (!dataGridView1.Bounds.Contains(e.Location))
            {
                kayitNo.Clear();
                tcNo.Clear();
                adi.Clear();
                soyadi.Clear();
                kAdi.Clear();
                sifre.Clear();
                telNo.Clear();
                adrs.Clear();
                foto.Image = null;



            }
        }

        private void telNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void telNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // 10 haneden fazla yazılmamasını sağla
            if (telNo.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamların girilmesini sağlar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // 10 karakterden fazla girilmesini engeller
            if (tcNo.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void kAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void kAdi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void kAdi_Leave(object sender, EventArgs e)
        {
            if (kAdi.Text.Length < 8)
            {
                MessageBox.Show("Kullanıcı adı en az 8 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kAdi.Focus();
            }
        }

        private void sifre_Leave(object sender, EventArgs e)
        {

            if (sifre.Text.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakterden oluşmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sifre.Focus();

            }
        }

        private void telNo_Leave(object sender, EventArgs e)
        {
            if (telNo.Text.Length < 10)
            {
                MessageBox.Show("Telefon numarası doğru formatta girilmeli!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                telNo.Focus();
            }
        }

        private void tcNo_Leave(object sender, EventArgs e)
        {
            if (tcNo.Text.Length < 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tcNo.Focus();
            }
        }
    }
}
