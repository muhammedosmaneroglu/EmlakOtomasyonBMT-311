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

    public partial class IlanIslemleri : Form
    {

        OracleConnection connection = new OracleConnection("User Id=OSMANM;Password=12345;Data Source=localhost:1521/XEPDB1;");
        public IlanIslemleri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cms = new OracleCommand();
            cms.Connection = connection;
            cms.CommandType = CommandType.Text;
            cms.CommandText = "DELETE FROM ILAN WHERE ILAN_ID = " + islemID.Text ;
            int a=cms.ExecuteNonQuery();
            if (a==1)
            {
                MessageBox.Show("Silinme işlemi başarılı.");
                Form1.toplam_ilan -= 1;
            }
            else
            {
                MessageBox.Show("Yanlış ya da boş değer girdiniz.");
            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleDataAdapter oda = new OracleDataAdapter("SELECT * from ILAN where ILAN_SATICI_ID='"+Form1.satıcıID+"'", connection);
            DataTable dtbl = new DataTable();
            oda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            connection.Close();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {

            
            String tür, kimden, durum, fiyat, detay,  adres,telefon;
            if (türCombo.SelectedIndex == 0)
            {
                tür = "ARSA";
            }
            else if (türCombo.SelectedIndex == 1)
            {
                tür = "BİNA";
            }
            else if (türCombo.SelectedIndex == 2)
            {
                tür = "KONUT";
            }
            else
            {
                tür = "a";
            }
            if (kimdenCombo.SelectedIndex == 0)
            {
                kimden = "SAHİBİNDEN";
            }
            else if (kimdenCombo.SelectedIndex == 1)
            {
                kimden = "EMLAKÇI";
            }
            else
            {
                kimden = "b";
            }
            if (durumCombo.SelectedIndex == 0)
            {
                durum = "SATILIK";
            }
            else if (durumCombo.SelectedIndex == 1)
            {
                durum = "KİRALIK";
            }
            else
            {
                durum = "1";
            }
            fiyat = fiyatBilgi.Text;
            detay = detayBilgi.Text;
            adres = adresBilgi.Text;
            telefon = telefonBilgi.Text;
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "INSERT INTO ILAN VALUES(DEFAULT,'" + tür + "','" + durum + "','" + kimden + "','"+Form1.satıcıID+"','"+ fiyat + "',SYSDATE,'" + detay + "','" + adres + "','"+telefon+"')";
            Console.WriteLine(cmd.CommandText);
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc==1)
            {
                MessageBox.Show("Başarılı");
                Form1.toplam_ilan = Form1.toplam_ilan + 1;
            }
            else
            {
                MessageBox.Show("Başarısız");
                
            }
            connection.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                connection.Close();
            }
        }

        private void IlanIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void güncelle_Click(object sender, EventArgs e)
        {

            try
            {

            
                String tür, kimden, durum, fiyat, detay, adres,telefon;
                if (türCombo.SelectedIndex == 0)
                {
                    tür = "ARSA";
                }
                else if (türCombo.SelectedIndex == 1)
                {
                    tür = "BİNA";
                }
                else if (türCombo.SelectedIndex == 2)
                {
                    tür = "KONUT";
                }
                else
                {
                    tür = "";
                }
                if (kimdenCombo.SelectedIndex == 0)
                {
                    kimden = "SAHİBİNDEN";
                }
                else if (kimdenCombo.SelectedIndex == 1)
                {
                    kimden = "EMLAKÇI";
                }
                else
                {
                    kimden = "";
                }
                if (durumCombo.SelectedIndex == 0)
                {
                    durum = "SATILIK";
                }
                else if (durumCombo.SelectedIndex == 1)
                {
                    durum = "KİRALIK";
                }
                else
                {
                    durum = "";
                }
                fiyat = fiyatBilgi.Text;
                detay = detayBilgi.Text;
                adres = adresBilgi.Text;
                telefon = telefonBilgi.Text;
                connection.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE ilan SET ILAN_TÜR = '" + tür + "', ILAN_DURUM = '" + durum + "', ILAN_KIMDEN = '" + kimden + "', ILAN_FIYAT = '" + fiyat + "',ILAN_DETAY='" + detay + "',ILAN_ADRES='" + adres + "',ILAN_TELEFON='"+telefon+"' WHERE ILAN_ID = " + islemID.Text;
                cmd.CommandType = CommandType.Text;
            int z = cmd.ExecuteNonQuery();
            if (z == 1)
            {
                MessageBox.Show("Güncelleme Başarılı");
                
            }
            else
            {
                MessageBox.Show("yanlışlık oldu");
            }
            connection.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                connection.Close();
            }



        }

        private void islemID_TextChanged(object sender, EventArgs e)
        {            
            connection.Open();
            OracleCommand cma = new OracleCommand();
            cma.Connection = connection;
            cma.CommandText = "SELECT * from ilan where ILAN_ID='" + islemID.Text + "'";
            cma.CommandType = CommandType.Text;
            OracleDataReader ds = cma.ExecuteReader();
            if (ds.Read())
            {
                türCombo.Text = ds.GetValue(1).ToString();
                durumCombo.Text = ds.GetValue(2).ToString();
                kimdenCombo.Text = ds.GetValue(3).ToString();
                fiyatBilgi.Text = ds.GetValue(5).ToString();
                detayBilgi.Text = ds.GetValue(7).ToString();
                adresBilgi.Text = ds.GetValue(8).ToString();
                telefonBilgi.Text = ds.GetValue(9).ToString();
                connection.Close();
            }
            else
            {
                türCombo.Text = "";
                durumCombo.Text = "";
                kimdenCombo.Text = "";
                fiyatBilgi.Text = "";
                detayBilgi.Text = "";
                adresBilgi.Text = "";
                telefonBilgi.Text = "";
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UyeIslemEkran = new UyeIslem();
            UyeIslemEkran.Closed += (s, args) => this.Close();
            UyeIslemEkran.Show();
        }
    }
}
