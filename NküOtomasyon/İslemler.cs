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
    public partial class İslemler : Form
    {
        SqlConnection ktpBgl;
        SqlCommand komutKitap;
        SqlDataAdapter adapterK;
        public İslemler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void kitapListe()
        {
            ktpBgl = new SqlConnection("Data Source=DESKTOP-0SG48DE;Initial Catalog=KutuphaneOto;Integrated Security=True");
            ktpBgl.Open();
            adapterK = new SqlDataAdapter("SELECT * FROM kitapListele", ktpBgl);
            DataTable dt = new DataTable();
            adapterK.Fill(dt);
            dataGridView1.DataSource = dt;
            ktpBgl.Close();
        }
        private void İslemler_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle= FormBorderStyle.None;
            kitapListe();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btmax.Visible = false;
            btmaxed.Location = btmax.Location;
            btmaxed.Visible = true;
            
        }

        private void btmaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btmaxed.Visible = false;
            btmax.Visible = true;
            
        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            added1.Visible = false;
            dataGridView1.Visible = true;
            panel4.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            if (anaS.Focused == true)
            {
                anaS.BackColor = Color.DarkSlateGray;
                ekleSil.BackColor = panel2.BackColor;
                odunc.BackColor = panel2.BackColor;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;  
            added1.Visible = true;
            panel4.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
            if (ekleSil.Focused == true)
            {
                ekleSil.BackColor = Color.DarkSlateGray;
                anaS.BackColor = panel2.BackColor;
                odunc.BackColor = panel2.BackColor;
            }
            
        }

        private void added1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (odunc.Focused == true)
            {
                odunc.BackColor = Color.DarkSlateGray;
                anaS.BackColor = panel2.BackColor;
                ekleSil.BackColor = panel2.BackColor;
            }
        }

        private void added1_Load_1(object sender, EventArgs e)
        {

        }

        private bool isDragging = false;
        private Point lastLocation;
        private void İslemler_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void İslemler_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        

        private void İslemler_MouseUp(object sender, MouseEventArgs e)
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
    }
}
