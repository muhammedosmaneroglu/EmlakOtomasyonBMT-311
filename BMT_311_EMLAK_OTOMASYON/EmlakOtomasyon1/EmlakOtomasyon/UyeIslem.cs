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
    public partial class UyeIslem : Form
    {

        OracleConnection connection = new OracleConnection("User Id=OSMANM;Password=12345;Data Source=localhost:1521/XEPDB1;");
        public UyeIslem()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UyeIslemEkran = new IlanIslemleri();
            UyeIslemEkran.Closed += (s, args) => this.Close();
            UyeIslemEkran.Show();
        }

        private void UyeIslem_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(Form1.satıcıID);
            label6.Text = Form1.satıcıAd;
            label7.Text = Form1.satıcıNum;
            label8.Text = Form1.satıcıAdres;
            label10.Text = Form1.toplam_ilan.ToString();

        }

        private void bilgiGüncellemeButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UyeIslemEkran = new UyeBilgiGuncelleme();
            UyeIslemEkran.Closed += (s, args) => this.Close();
            UyeIslemEkran.Show();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UyeIslemEkran = new Form1();
            UyeIslemEkran.Closed += (s, args) => this.Close();
            UyeIslemEkran.Show();
        }

        private void üyeSilButon_Click(object sender, EventArgs e)
        {
            int satıcı_ıd = Form1.satıcıID;
            Console.WriteLine(satıcı_ıd);
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM SATICI WHERE SATICI_ID = " + satıcı_ıd;
            int a=cmd.ExecuteNonQuery();
            if (a == 1)
            {
                connection.Close();
                MessageBox.Show("Üyeliğiniz silinmiştir.");
                this.Hide();
                var UyeIslemEkran = new Form1();
                UyeIslemEkran.Closed += (s, args) => this.Close();
                UyeIslemEkran.Show();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.");
                connection.Close();
            }

        }
    }
}
