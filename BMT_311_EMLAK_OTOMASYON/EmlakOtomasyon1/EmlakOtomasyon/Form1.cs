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
    public partial class Form1 : Form
    {
        public static int satıcıID;
        public static String satıcıAd;
        public static String satıcıPass;
        public static String satıcıNum;
        public static String satıcıAdres;
        public static int toplam_ilan;
        OracleConnection connection = new OracleConnection("User Id=OSMANM;Password=12345;Data Source=localhost:1521/XEPDB1;");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            satıcıID = Convert.ToInt32(satıcı_ıd.Text);
            String üyePass = satıcı_sifre.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM SATICI WHERE SATICI_ID= " + satıcıID + "AND SATICI_PASS = '" + üyePass + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                satıcıAd = dr.GetValue(1).ToString();
                satıcıPass = üyePass;
                satıcıNum = dr.GetValue(3).ToString();
                satıcıAdres = dr.GetValue(4).ToString();
                toplam_ilan = dr.GetInt32(5);
                this.Hide();
                var UyeIslemEkran = new UyeIslem();
                UyeIslemEkran.Closed += (s, args) => this.Close();
                UyeIslemEkran.Show();
                connection.Close();
            }
            else
            {
                MessageBox.Show("ID veya Şifre yanlış!");
                connection.Close();
            }
            
        }

        private void üyeOl_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UyeIslemEkran = new UyeOl();
            UyeIslemEkran.Closed += (s, args) => this.Close();
            UyeIslemEkran.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            OracleDataAdapter oda = new OracleDataAdapter("SELECT * from ILAN ", connection);
            DataTable dtbl = new DataTable();
            oda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            connection.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
