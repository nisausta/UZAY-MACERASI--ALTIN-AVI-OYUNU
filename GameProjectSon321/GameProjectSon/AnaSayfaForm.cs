using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BBP201Project1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static GameProjectSon.KullaniciGiris;

namespace GameProjectSon
{
    public partial class AnaSayfaForm : Form
    {

        public AnaSayfaForm()
        {
            InitializeComponent();
        }

        public class sayaç
        {
            public DateTime geçenSüre { get; set; }
        }

        public static class adgetir
        {
            public static string ad { get; set; }
        }
        private void button3_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(veri.name))
            {
                MessageBox.Show("Lütfen bir kullanıcı adı girin.");
                return; // Metodu burada sonlandırın, çünkü kullanıcı adı girilmemiş.
            }
            string conString = "Data Source=NISA;Initial Catalog=gameProject222;Integrated Security=True";
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Oyuncular(Ad) SELECT '{veri.name}' WHERE NOT EXISTS (SELECT 1 FROM Oyuncular WHERE Ad = '{veri.name}');", connect);
                cmd.Parameters.AddWithValue("@ad", veri.name);
                cmd.ExecuteNonQuery();
               

                // Kullanıcı adını labela atayalım
                label1.Text = "" + veri.name;
                adgetir.ad= veri.name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            Form1 f = new Form1();
            f.isimYaz();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YapimcilarForm f = new YapimcilarForm();
            f.Show();
            this.Hide();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {

            label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            label1.Text = veri.name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scoreTablosu f = new scoreTablosu();
            f.Show();
            this.Hide();
        }

        private void txtadi_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            scoreTablosu f = new scoreTablosu();
            f.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



