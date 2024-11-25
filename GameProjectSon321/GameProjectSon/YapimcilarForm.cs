using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProjectSon
{
    public partial class YapimcilarForm : Form
    {
        static string conString = "Data Source=NISA;Initial Catalog=gameProject222;Integrated Security = True";
        SqlConnection connect = new SqlConnection(conString);

        public YapimcilarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f = new AnaSayfaForm();
            f.Show();
            this.Hide();
        }

        private void OyunuDurdur(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YapimcilarForm_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            string conString = "Data Source=NISA;Initial Catalog=gameProject222;Integrated Security=True";
            SqlConnection connect = new SqlConnection(conString);
            connect.Open();
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand($"SELECT yapimcilar.ad, yapimcilar.soyad FROM yapimcilar", connect);
            DataTable dt = new DataTable();
            using (SqlDataAdapter adtr = new SqlDataAdapter(cmd))
            {
                adtr.Fill(dt);

            }

            label1.Text = $"{dt.Rows[0][0].ToString()} {dt.Rows[0][1].ToString()}";
            label2.Text = $"{dt.Rows[1][0].ToString()} {dt.Rows[1][1].ToString()}";
            label3.Text = $"{dt.Rows[2][0].ToString()} {dt.Rows[2][1].ToString()}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            scoreTablosu f = new scoreTablosu();
            f.Show();
            this.Hide();
        }
    }
    }
