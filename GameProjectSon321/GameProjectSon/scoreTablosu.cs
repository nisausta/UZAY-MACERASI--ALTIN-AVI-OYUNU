using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProjectSon
{
    public partial class scoreTablosu : Form
    {
        public scoreTablosu()
        {
            InitializeComponent();
        }

        private void scoreTablosu_Load(object sender, EventArgs e)
        {
            VeritabanindanSkorlariGetir();
        }

        private void VeritabanindanSkorlariGetir()
        {
         
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void scoreTablosu_Load_1(object sender, EventArgs e)
        {
            string conString = "Data Source=NISA;Initial Catalog=gameProject222;Integrated Security=True";
            SqlConnection connect = new SqlConnection(conString);
            connect.Open();
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand($"SELECT TOP 8 Oyuncular.Ad, Score.ScorePuani, Sure.Sure\r\nFROM Oyuncular\r\nJOIN Score ON Oyuncular.OyuncuID = Score.OyuncuID\r\nJOIN Sure ON Oyuncular.OyuncuID = Sure.OyuncuID\r\nORDER BY Score.ScorePuani DESC, Sure.Sure ASC;", connect);
            DataTable dt = new DataTable();
            using (SqlDataAdapter adtr = new SqlDataAdapter(cmd))
            {
                adtr.Fill(dt);
                
            }
            

            if (dt.Rows.Count == 1)
            {
                label4.Text = $"{dt.Rows[0][0].ToString()} , {dt.Rows[0][1].ToString()} , {dt.Rows[0][2].ToString()}";
            }
            if (dt.Rows.Count == 2)
            {
                label4.Text = $"{dt.Rows[0][0].ToString()} , {dt.Rows[0][1].ToString()} , {dt.Rows[0][2].ToString()}";
                label5.Text = $"{dt.Rows[1][0].ToString()} , {dt.Rows[1][1].ToString()} , {dt.Rows[1][2].ToString()}";
            }
            if (dt.Rows.Count == 3)
            {
                label4.Text = $"{dt.Rows[0][0].ToString()} , {dt.Rows[0][1].ToString()} , {dt.Rows[0][2].ToString()}";
                label5.Text = $"{dt.Rows[1][0].ToString()} , {dt.Rows[1][1].ToString()} , {dt.Rows[1][2].ToString()}";
                label6.Text = $"{dt.Rows[2][0].ToString()} , {dt.Rows[2][1].ToString()} , {dt.Rows[2][2].ToString()}";
            }
            if (dt.Rows.Count == 4)
            {
                label4.Text = $"{dt.Rows[0][0].ToString()} , {dt.Rows[0][1].ToString()} , {dt.Rows[0][2].ToString()}";
                label5.Text = $"{dt.Rows[1][0].ToString()} , {dt.Rows[1][1].ToString()} , {dt.Rows[1][2].ToString()}";
                label6.Text = $"{dt.Rows[2][0].ToString()} , {dt.Rows[2][1].ToString()} , {dt.Rows[2][2].ToString()}";
                label7.Text = $"{dt.Rows[3][0].ToString()} , {dt.Rows[3][1].ToString()} , {dt.Rows[3][2].ToString()}";
            }
            if (dt.Rows.Count >= 5)
            {
                label4.Text = $"{dt.Rows[0][0].ToString()} , {dt.Rows[0][1].ToString()} , {dt.Rows[0][2].ToString()}";
                label5.Text = $"{dt.Rows[1][0].ToString()} , {dt.Rows[1][1].ToString()} , {dt.Rows[1][2].ToString()}";
                label6.Text = $"{dt.Rows[2][0].ToString()} , {dt.Rows[2][1].ToString()} , {dt.Rows[2][2].ToString()}";
                label7.Text = $"{dt.Rows[3][0].ToString()} , {dt.Rows[3][1].ToString()} , {dt.Rows[3][2].ToString()}";
                label8.Text = $"{dt.Rows[4][0].ToString()} , {dt.Rows[4][1].ToString()} , {dt.Rows[4][2].ToString()}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f = new AnaSayfaForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YapimcilarForm f = new YapimcilarForm();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            scoreTablosu f = new scoreTablosu();
            f.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


