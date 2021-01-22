using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace EmlakOtomasyon
{
    public partial class UyeBilgiGuncelleme : Form
    {

        OracleConnection connection = new OracleConnection("User Id=OSMANM;Password=12345;Data Source=localhost:1521/XEPDB1;");


        public UyeBilgiGuncelleme()
        {
            InitializeComponent();
        }

        private void güncelleButon_Click(object sender, EventArgs e)
        {
            String ad, pass, num, adres;
            ad = textBox2.Text;
            pass = textBox3.Text;
            num = textBox4.Text;
            adres = textBox5.Text;
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE SATICI SET SATICI_AD = '" + ad + "', SATICI_PASS = '" + pass + "', SATICI_NUMARA = '" + num + "', SATICI_ADRES = '" + adres + "' WHERE SATICI_ID = " + Form1.satıcıID;
            cmd.CommandType = CommandType.Text;
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc == 1)
            {
                MessageBox.Show("GÜNCELLEME BAŞARILI!");
                Form1.satıcıAd = textBox2.Text;
                Form1.satıcıNum = textBox4.Text;
                Form1.satıcıPass = textBox3.Text;
                Form1.satıcıAdres = textBox5.Text;
                connection.Close();
                this.Hide();
                var UyeIslemEkran = new UyeIslem();
                UyeIslemEkran.Closed += (s, args) => this.Close();
                UyeIslemEkran.Show();
            }
            else
            {
                MessageBox.Show("GÜNCELLEME BAŞARISIZ!");
            }
            connection.Close();
            
        }

        private void UyeBilgiGuncelleme_Load(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(Form1.satıcıID);
            textBox2.Text = Form1.satıcıAd;
            textBox4.Text = Form1.satıcıNum;
            textBox5.Text = Form1.satıcıAdres;
            textBox3.Text = Form1.satıcıPass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UyeIslemEkran = new UyeIslem();
            UyeIslemEkran.Closed += (s, args) => this.Close();
            UyeIslemEkran.Show();
        }
    }
}
