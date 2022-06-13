using GUMUSCicek.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUMUSCicek.Uİ
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            FrmMüsteri frmMüsteri = new Uİ.FrmMüsteri()
            {
                Text = "Müşteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },
            };
            var sonuc = frmMüsteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriEkle(frmMüsteri.Musteri);
                if (b)
                {

                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }
        }

        private void btnMüşteriDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmMüsteri frmMüsteri = new Uİ.FrmMüsteri()
            {
                Text = "Müşteri Güncelle",
                Güncelleme = true,
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),


                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frmMüsteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriGüncelle(frmMüsteri.Musteri);
                if (b)
                {

                    row.Cells[1].Value = frmMüsteri.Musteri.Ad;
                    row.Cells[2].Value = frmMüsteri.Musteri.Soyad;
                    row.Cells[3].Value = frmMüsteri.Musteri.Telefon;
                    row.Cells[4].Value = frmMüsteri.Musteri.Mail;
                    row.Cells[5].Value = frmMüsteri.Musteri.Adres;




                }

            }
        }

        private void btnMüşteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnMüşteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili Kayıtı Silmek İstermisiniz?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriSil(ID);

                {

                    if (b)
                    {

                        DataSet ds = BLogic.MusteriGetir("");
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];
                    }




                }

            }

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriGetir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }
        
        public Musteri musteri { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            
            

                musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),


                };

                //{ ID = Guid.NewGuid() },
            
            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
