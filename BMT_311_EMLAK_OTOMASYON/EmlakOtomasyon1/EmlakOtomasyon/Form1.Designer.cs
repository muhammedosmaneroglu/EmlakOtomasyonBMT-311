
namespace EmlakOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.satıcı_giris_buton = new System.Windows.Forms.Button();
            this.satıcı_ıd = new System.Windows.Forms.TextBox();
            this.satıcı_sifre = new System.Windows.Forms.TextBox();
            this.aramaTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.üyeOl = new System.Windows.Forms.Button();
            this.aramaTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // satıcı_giris_buton
            // 
            this.satıcı_giris_buton.Location = new System.Drawing.Point(515, 330);
            this.satıcı_giris_buton.Name = "satıcı_giris_buton";
            this.satıcı_giris_buton.Size = new System.Drawing.Size(143, 23);
            this.satıcı_giris_buton.TabIndex = 0;
            this.satıcı_giris_buton.Text = "GİRİŞ";
            this.satıcı_giris_buton.UseVisualStyleBackColor = true;
            this.satıcı_giris_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // satıcı_ıd
            // 
            this.satıcı_ıd.Location = new System.Drawing.Point(515, 220);
            this.satıcı_ıd.Name = "satıcı_ıd";
            this.satıcı_ıd.Size = new System.Drawing.Size(143, 20);
            this.satıcı_ıd.TabIndex = 2;
            // 
            // satıcı_sifre
            // 
            this.satıcı_sifre.Location = new System.Drawing.Point(515, 273);
            this.satıcı_sifre.Name = "satıcı_sifre";
            this.satıcı_sifre.PasswordChar = '*';
            this.satıcı_sifre.Size = new System.Drawing.Size(143, 20);
            this.satıcı_sifre.TabIndex = 3;
            // 
            // aramaTab
            // 
            this.aramaTab.Controls.Add(this.tabPage1);
            this.aramaTab.Controls.Add(this.tabPage2);
            this.aramaTab.Location = new System.Drawing.Point(12, 12);
            this.aramaTab.Name = "aramaTab";
            this.aramaTab.SelectedIndex = 0;
            this.aramaTab.Size = new System.Drawing.Size(1169, 648);
            this.aramaTab.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İLAN ARAMA EKRANI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(970, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "İLANLARI GETİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 530);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.üyeOl);
            this.tabPage2.Controls.Add(this.satıcı_ıd);
            this.tabPage2.Controls.Add(this.satıcı_giris_buton);
            this.tabPage2.Controls.Add(this.satıcı_sifre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ÜYE GİRİŞİ";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // üyeOl
            // 
            this.üyeOl.Location = new System.Drawing.Point(545, 393);
            this.üyeOl.Name = "üyeOl";
            this.üyeOl.Size = new System.Drawing.Size(75, 23);
            this.üyeOl.TabIndex = 4;
            this.üyeOl.Text = "Üye Ol";
            this.üyeOl.UseVisualStyleBackColor = true;
            this.üyeOl.Click += new System.EventHandler(this.üyeOl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 664);
            this.Controls.Add(this.aramaTab);
            this.Name = "Form1";
            this.Text = "ANA EKRAN";
            this.aramaTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button satıcı_giris_buton;
        private System.Windows.Forms.TextBox satıcı_ıd;
        private System.Windows.Forms.TextBox satıcı_sifre;
        private System.Windows.Forms.TabControl aramaTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button üyeOl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

