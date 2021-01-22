
namespace EmlakOtomasyon
{
    partial class IlanIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.adresBilgi = new System.Windows.Forms.TextBox();
            this.detayBilgi = new System.Windows.Forms.TextBox();
            this.fiyatBilgi = new System.Windows.Forms.TextBox();
            this.durumCombo = new System.Windows.Forms.ComboBox();
            this.kimdenCombo = new System.Windows.Forms.ComboBox();
            this.türCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.islemID = new System.Windows.Forms.TextBox();
            this.ilanGetir = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonBilgi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(232, 297);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(75, 23);
            this.güncelle.TabIndex = 53;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // adresBilgi
            // 
            this.adresBilgi.Location = new System.Drawing.Point(232, 221);
            this.adresBilgi.Name = "adresBilgi";
            this.adresBilgi.Size = new System.Drawing.Size(286, 20);
            this.adresBilgi.TabIndex = 52;
            // 
            // detayBilgi
            // 
            this.detayBilgi.Location = new System.Drawing.Point(232, 186);
            this.detayBilgi.Name = "detayBilgi";
            this.detayBilgi.Size = new System.Drawing.Size(286, 20);
            this.detayBilgi.TabIndex = 44;
            // 
            // fiyatBilgi
            // 
            this.fiyatBilgi.Location = new System.Drawing.Point(232, 156);
            this.fiyatBilgi.Name = "fiyatBilgi";
            this.fiyatBilgi.Size = new System.Drawing.Size(286, 20);
            this.fiyatBilgi.TabIndex = 43;
            // 
            // durumCombo
            // 
            this.durumCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durumCombo.FormattingEnabled = true;
            this.durumCombo.Items.AddRange(new object[] {
            "SATILIK",
            "KİRALIK"});
            this.durumCombo.Location = new System.Drawing.Point(232, 131);
            this.durumCombo.Name = "durumCombo";
            this.durumCombo.Size = new System.Drawing.Size(121, 21);
            this.durumCombo.TabIndex = 42;
            // 
            // kimdenCombo
            // 
            this.kimdenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kimdenCombo.FormattingEnabled = true;
            this.kimdenCombo.Items.AddRange(new object[] {
            "SAHİBİNDEN",
            "EMLAKÇI"});
            this.kimdenCombo.Location = new System.Drawing.Point(232, 104);
            this.kimdenCombo.Name = "kimdenCombo";
            this.kimdenCombo.Size = new System.Drawing.Size(121, 21);
            this.kimdenCombo.TabIndex = 41;
            // 
            // türCombo
            // 
            this.türCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.türCombo.FormattingEnabled = true;
            this.türCombo.Items.AddRange(new object[] {
            "ARSA",
            "BİNA",
            "KONUT"});
            this.türCombo.Location = new System.Drawing.Point(232, 71);
            this.türCombo.Name = "türCombo";
            this.türCombo.Size = new System.Drawing.Size(121, 21);
            this.türCombo.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "ADRES:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "DETAY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "FİYAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "DURUM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "KİMDEN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "İLAN TÜRÜ:";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(334, 297);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 54;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(549, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 227);
            this.dataGridView1.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(229, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "İŞLEM YAPILACAK İLAN  ID GİRİN:";
            // 
            // islemID
            // 
            this.islemID.Location = new System.Drawing.Point(433, 16);
            this.islemID.Name = "islemID";
            this.islemID.Size = new System.Drawing.Size(100, 20);
            this.islemID.TabIndex = 57;
            this.islemID.TextChanged += new System.EventHandler(this.islemID_TextChanged);
            // 
            // ilanGetir
            // 
            this.ilanGetir.Location = new System.Drawing.Point(913, 19);
            this.ilanGetir.Name = "ilanGetir";
            this.ilanGetir.Size = new System.Drawing.Size(169, 23);
            this.ilanGetir.TabIndex = 58;
            this.ilanGetir.Text = "İLANLARI GETİR";
            this.ilanGetir.UseVisualStyleBackColor = true;
            this.ilanGetir.Click += new System.EventHandler(this.button4_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(443, 297);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 59;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "TEL NO:";
            // 
            // telefonBilgi
            // 
            this.telefonBilgi.Location = new System.Drawing.Point(232, 251);
            this.telefonBilgi.Name = "telefonBilgi";
            this.telefonBilgi.Size = new System.Drawing.Size(286, 20);
            this.telefonBilgi.TabIndex = 61;
            // 
            // IlanIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 332);
            this.Controls.Add(this.telefonBilgi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ilanGetir);
            this.Controls.Add(this.islemID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.adresBilgi);
            this.Controls.Add(this.detayBilgi);
            this.Controls.Add(this.fiyatBilgi);
            this.Controls.Add(this.durumCombo);
            this.Controls.Add(this.kimdenCombo);
            this.Controls.Add(this.türCombo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "IlanIslemleri";
            this.Text = "İlan İşlemleri";
            this.Load += new System.EventHandler(this.IlanIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.TextBox adresBilgi;
        private System.Windows.Forms.TextBox detayBilgi;
        private System.Windows.Forms.TextBox fiyatBilgi;
        private System.Windows.Forms.ComboBox durumCombo;
        private System.Windows.Forms.ComboBox kimdenCombo;
        private System.Windows.Forms.ComboBox türCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox islemID;
        private System.Windows.Forms.Button ilanGetir;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefonBilgi;
    }
}