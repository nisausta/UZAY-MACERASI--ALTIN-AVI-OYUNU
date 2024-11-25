using BBP201Project1;
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
using static GameProjectSon.AnaSayfaForm;

namespace GameProjectSon
{


    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        public void isimYaz()
        {
            label1.Text = adgetir.ad;
        }
        public static class adgetir
        {
            public static string ad { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(lblad.Text))
            {
                MessageBox.Show("Lütfen bir kullanıcı adı girin.");
                return; // Metodu burada sonlandırın, çünkü kullanıcı adı girilmemiş.
            }
            string conString = "Data Source=NISA;Initial Catalog=gameProject222;Integrated Security=True";
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Oyuncular(Ad) SELECT '{lblad.Text}' WHERE NOT EXISTS (SELECT 1 FROM Oyuncular WHERE Ad = '{lblad.Text}');", connect);
                cmd.Parameters.AddWithValue("@ad", lblad.Text);
                cmd.ExecuteNonQuery();
                

                // Kullanıcı adını labela atayalım
                label1.Text = "Kullanıcı Adı: " + lblad.Text;
                adgetir.ad = lblad.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            AnaSayfaForm f = new AnaSayfaForm();
           
            f.Show();
            this.Hide();

        }
      

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static class veri
        {
            public static string name = "";
            public static int gecen_sure;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblad.Text))
            {
                MessageBox.Show("Lütfen bir kullanıcı adı girin.");
                return; // Metodu burada sonlandırın, çünkü kullanıcı adı girilmemiş.
            }
            string conString = "Data Source=DESKTOP-65RMS34;Initial Catalog=gameProject222;Integrated Security=True";
            SqlConnection connect = new SqlConnection(conString);
            label1.Text=lblad.Text;
            veri.name=lblad.Text;
            MessageBox.Show("Oyuncu başarıyla kaydedildi!");
            button3.Enabled = true;
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
