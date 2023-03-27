using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NküOtomasyon
{
    public partial class added : UserControl
    {
        public added()

        {
            InitializeComponent();
        }
        SqlConnection ekleme;
        SqlCommand eklemeCommand;
        SqlDataAdapter adapter;
        public void kitaplar()
        {
            ekleme = new SqlConnection("Data Source=DESKTOP-0SG48DE;Initial Catalog=KutuphaneOto;Integrated Security=True");
            ekleme.Open();
            adapter = new SqlDataAdapter("SELECT * FROM kitapListele", ekleme);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            ekleme.Close();
        }
        void clear()
        {
            kitapAdi.Clear();
            id.Clear();
            tur.Clear();
            yayinEvi.Clear();
            baski.Clear();
            sayfa.Clear();
            
           
        }
        private void search_Click(object sender, EventArgs e)
        {
            ekleme = new SqlConnection("Data Source=DESKTOP-0SG48DE;Initial Catalog=KutuphaneOto;Integrated Security=True");
            ekleme.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO kitapListele(kitap_adi,kitap_yazari,kitap_turu,yayin_evi,baski_yili,sayfa_sayisi,nerede) VALUES(@kAd,@kYazar,@kTur,@kYayin,@kBaski,@kSayfa,@kNerede)");
            komut.Parameters.AddWithValue("@kAd", kitapAdi.Text);
            komut.Parameters.AddWithValue("@kYazar", id.Text);
            komut.Parameters.AddWithValue("@kTur", tur.Text);
            komut.Parameters.AddWithValue("@kYayin", yayinEvi.Text);
            komut.Parameters.AddWithValue("@kBaski", baski.Text);
            komut.Parameters.AddWithValue("@kSayfa", sayfa.Text);
            komut.Parameters.AddWithValue("@kNerede", nerede.Text);
            
            komut.Connection = ekleme;
            if (string.IsNullOrWhiteSpace(kitapAdi.Text))
            {
                MessageBox.Show("Lütfen kitap adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                komut.ExecuteNonQuery();
                ekleme.Close();
                kitaplar();
                clear();
            }
        }

        private void nerede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sil = "DELETE FROM kayit WHERE kayit_no=@kayitNo";
            SqlCommand cmd = new SqlCommand(sil, ekleme);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
            ekleme.Open();
            cmd.ExecuteNonQuery();
            ekleme.Close();
            kitaplar();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ekle = "UPDATE kitapListele SET id=@id,kitap_adi=@kAd,kitap_yazari=@kYazar,kitap_turu=@kTur,yayin_evi=@kYayin,baski_yili=@kBaski,sayfa_sayisi=@kSayfa,nerede=@kNerede";
            eklemeCommand = new SqlCommand(ekle, ekleme);
            eklemeCommand.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
            eklemeCommand.Parameters.AddWithValue("@kAd", kitapAdi.Text);
            eklemeCommand.Parameters.AddWithValue("@kYazar", kYazar.Text);
            eklemeCommand.Parameters.AddWithValue("@kTur", tur.Text);
            eklemeCommand.Parameters.AddWithValue("@kYayin", yayinEvi.Text);
            eklemeCommand.Parameters.AddWithValue("@kBaski", baski.Text);
            eklemeCommand.Parameters.AddWithValue("@kSayfa", sayfa.Text);
            eklemeCommand.Parameters.AddWithValue("@kNerede", nerede.Text);
            ekleme.Open();
            eklemeCommand.ExecuteNonQuery();
            ekleme.Close();
            kitaplar();
            clear();
        }
    }
}
