using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sifreli_Veriler_Ile_Calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3JI920O\SQLEXPRESS;Initial Catalog=DbProje13;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLVERILER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] adDizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adSifre = Convert.ToBase64String(adDizi);

            string soyad = txtSoyad.Text;
            byte[] soyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadSifre = Convert.ToBase64String(soyadDizi);

            string mail = txtMail.Text;
            byte[] mailDizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailSifre = Convert.ToBase64String(mailDizi);

            string sifre = txtSifre.Text;
            byte[] sifreDizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreSifre = Convert.ToBase64String(sifreDizi);

            string hesapNo = txtHesapNo.Text;
            byte[] hesapNoDizi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string hesapNoSifre = Convert.ToBase64String(hesapNoDizi);

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", conn);
            cmd.Parameters.AddWithValue("@p1", adSifre);
            cmd.Parameters.AddWithValue("@p2", soyadSifre);
            cmd.Parameters.AddWithValue("@p3", mailSifre);
            cmd.Parameters.AddWithValue("@p4", sifreSifre);
            cmd.Parameters.AddWithValue("@p5", hesapNoSifre);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Verileriniz Şifrelenerek Kaydedildi.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adCoz = txtAd.Text;
            byte[] adDiziCoz = Convert.FromBase64String(adCoz);
            string adCozulmus = ASCIIEncoding.ASCII.GetString(adDiziCoz);
            label6.Text = adCozulmus;
        }
    }
}
