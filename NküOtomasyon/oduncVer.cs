using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NküOtomasyon
{
    public partial class oduncVer : UserControl
    {
        public oduncVer()
        {
            InitializeComponent();
        }
        SqlConnection ekleme;
        SqlCommand eklemeCommand;
        SqlDataAdapter adapter;
        public void OduncListe()
        {
            ekleme = new SqlConnection("Data Source=DESKTOP-0SG48DE;Initial Catalog=KutuphaneOto;Integrated Security=True");
            ekleme.Open();
            adapter = new SqlDataAdapter("SELECT * FROM kitapListele", ekleme);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridV.DataSource = dt;
            ekleme.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OduncListe();
            temizle();
        }
        void temizle()
        {
            idn.Clear();
            secilenK.Clear();
            ara.Clear();
            
        }
        private void gridV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idn.Text = gridV.CurrentRow.Cells[0].Value.ToString();
            secilenK.Text = gridV.CurrentRow.Cells[1].Value.ToString();
            



        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            ekleme = new SqlConnection("Data Source=DESKTOP-0SG48DE;Initial Catalog=KutuphaneOto;Integrated Security=True");
            eklemeCommand = new SqlCommand("SELECT * FROM kitapListele WHERE  kitap_adi LIKE '%" + ara.Text  + "%'", ekleme);
            adapter = new SqlDataAdapter(eklemeCommand);
            DataSet ds = new DataSet();
            ekleme.Open();
            adapter.Fill(ds,"kitapListele");
            gridV.DataSource = ds.Tables["kitapListele"];
            ekleme.Close();
        }

        private void oduncVer_Load(object sender, EventArgs e)
        {
            temizle();
        }

        private void secilenK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
