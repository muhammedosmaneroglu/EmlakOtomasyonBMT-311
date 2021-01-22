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
    public partial class UyeOl : Form
    {

        OracleConnection connection = new OracleConnection("User Id=OSMANM;Password=12345;Data Source=localhost:1521/XEPDB1;");
        public UyeOl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UyeIslemEkran = new Form1();
            UyeIslemEkran.Closed += (s, args) => this.Close();
            UyeIslemEkran.Show();
        }

        private void üyeOl_Click(object sender, EventArgs e)
        {
            connection.Open();
            String ad, pass, num, adres,a,b;
            ad = textBox1.Text;
            pass = textBox2.Text;
            num = textBox3.Text;
            adres = textBox4.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO SATICI VALUES (DEFAULT,'"+ad+"','"+pass+"','"+num+"','"+adres+"',DEFAULT,DEFAULT)";
            cmd.CommandType = CommandType.Text;
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc==1)
            {
                OracleCommand cms = new OracleCommand();
                cms.Connection = connection;
                cms.CommandText="select * from satici where satici_ad='"+ad+"' AND satici_pass ='"+pass+"'";
                OracleDataReader dr = cms.ExecuteReader();
                if (dr.Read())
                {
                     a = dr.GetValue(0).ToString();
                     b = dr.GetValue(2).ToString();
                     MessageBox.Show("ÜYE OLUNDU! GİRİŞ ID'NIZ = " + a + " Şifreniz = " + b + " dir. Lütfen Bilgileriniz unutmayınız.");
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Şifre ve ID çağırılamadı.");
                }             
                this.Hide();
                var UyeIslemEkran = new Form1();
                UyeIslemEkran.Closed += (s, args) => this.Close();
                UyeIslemEkran.Show();
            }
            else
            {
                MessageBox.Show("Bir şeyler yanlış gitti lütfen tekrar deneyin");
            }
            
            
        }

        private void UyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
