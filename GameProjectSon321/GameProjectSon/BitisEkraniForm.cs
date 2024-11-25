using System;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using BBP201Project1;


namespace GameProjectSon
{
    public partial class BitisEkraniForm : Form
    {


        string conString = "Data Source=NISA;Initial Catalog=gameProject222;Integrated Security=True";
      //  SqlConnection connect = new SqlConnection(conString);


        public BitisEkraniForm()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            form1.Sayaç.Stop();

        }


        private void SaveScoreToDatabase(int oyuncuID, int bolumNo, int skor)
        {
           /*    try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                 // Veritabanına ekleme yapacak komut
                    string insertQuery = "INSERT INTO BolumDurumu (OyuncuID, BolumNo, Skor) VALUES (@OyuncuID, @BolumNo, @Skor)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@OyuncuID", oyuncuID);
                    command.Parameters.AddWithValue("@BolumNo", bolumNo);
                    command.Parameters.AddWithValue("@Skor", skor);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Skor kaydedilirken hata oluştu: " + ex.Message);
            }*/
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        }
        public void Score(int a)
        {
            lblScore.Text = a.ToString();
        }
        public void Time(string c)
        {
            label3.Text = c;
        }
        public void Message(string b)
        {
            lblText.Text = b;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            YapimcilarForm f = new YapimcilarForm();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f = new AnaSayfaForm();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f = new AnaSayfaForm();
            f.Show();
            this.Hide();
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
          /*  int oyuncuID = GetPlayerID(); // Oyuncu ID'sini burada almanız gerekecek
            int bolumNo = GetLevelNumber(lblText.Text); // Bölüm numarasını burada almanız gerekecek
            int skor = Convert.ToInt32(lblScore.Text);*/

         //   SaveScoreToDatabase(oyuncuID, bolumNo, skor);

            if (lblText.Text == "1. Bölüm Bitti" || lblText.Text == "Bolum 1 İyi Denemeydi")
             {
                 Form1 f = new Form1();
                 f.Show();
                 this.Hide();
             }
             if (lblText.Text == "2. Bölüm Bitti" || lblText.Text == "Bolum 2 İyi Denemeydi")
             {
                 Form2 f = new Form2();
                 f.Show();
                 this.Hide();
             }
             if (lblText.Text == "3. Bölüm Bitti" || lblText.Text == "Bolum 3 İyi Denemeydi")
             {
                 Form3 f = new Form3();
                 f.Show();
                 this.Hide();
             }
             if (lblText.Text == "4. Bölüm Bitti" || lblText.Text == "Bolum 4 İyi Denemeydi")
             {
                 Form4 f = new Form4();
                 f.Show();
                 this.Hide();
             }
             if (lblText.Text == "5. Bölüm Bitti" || lblText.Text == "Bolum 5 İyi Denemeydi")
             {
                 Form5 f = new Form5();
                 f.Show();
                 this.Hide();
             }
     


    }
    
        private void button4_Click(object sender, EventArgs e)
        {
            if (lblText.Text == "1. Bölüm Bitti")
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "2. Bölüm Bitti")
            {
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "3. Bölüm Bitti")
            {
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "4. Bölüm Bitti")
            {
                Form5 f = new Form5();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "5. Bölüm Bitti")
            {
                Form5 f = new Form5();
                f.Show();
                this.Hide();
            }
        }
        AnaSayfaForm AnaSayfaForm=new AnaSayfaForm();
    private void BitisEkraniForm_Load(object sender, EventArgs e)
        {
            
            if (lblText.Text == "Bolum 1 İyi Denemeydi"|| lblText.Text == "Bolum 2 İyi Denemeydi"|| lblText.Text == "Bolum 3 İyi Denemeydi"|| lblText.Text == "Bolum 4 İyi Denemeydi"|| lblText.Text == "Bolum 5 İyi Denemeydi")
            {
                button4.Visible = false;
            }
            
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void OyunuDurdur(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void lblScore_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=NISA;Initial Catalog=gameProject222;Integrated Security=True";
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO BolumDurumu (Skor) VALUES (@skor)", connect);
                cmd.Parameters.AddWithValue("@skor", lblScore.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Score başarıyla kaydedildi!");

                // Kullanıcı adını labela atayalım
                label2.Text = "Skor:  " + lblScore.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
       


        }

        private void label3_Click(object sender, EventArgs e)
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
