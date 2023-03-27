using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NküOtomasyon
{
    
    public partial class Form1 : Form
    {
        KutuphaneOtoEntities db = new KutuphaneOtoEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            yeniKayit kyt = new yeniKayit();
            this.Hide();
            kyt.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                password.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girilenAd = users.Text;
            string girilenSifre = password.Text;
            var personel = db.kayit.Where(x => x.kullanici_adi.Equals(girilenAd) && x.sifre.Equals(girilenSifre)).FirstOrDefault();
            if (personel == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");

            }
            else
            {
                MessageBox.Show("Giriş Başarılı.");
                İslemler ktpIslm = new İslemler();
                this.Hide();
                ktpIslm.ShowDialog();
            }
        }
    }
}
