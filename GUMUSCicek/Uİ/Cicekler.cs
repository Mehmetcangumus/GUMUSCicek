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
    public partial class Cicekler : Form
    {
        public Cicekler()
        {
            InitializeComponent();
        }
        private void btnÇiçekEkle_Click(object sender, EventArgs e)
        {
            FrmCicek frm = new FrmCicek()
            {
                Text = "Çiçek Ekle",
                Cicek = new Cicek() { ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.CicekEkle(frm.Cicek);
                if (b)
                {

                    DataSet ds = BLogic.CicekGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnÇiçekDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmCicek frm = new FrmCicek()
            {
                Text = "Cicek Güncelle",
                Güncelleme = true,
                Cicek = new Cicek()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Kategori = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Stok = double.Parse(row.Cells[4].Value.ToString()),
                    Detay = row.Cells[5].Value.ToString(),


                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.cıcekGuncelle(frm.Cicek);

                if (b)
                {

                    row.Cells[1].Value = frm.Cicek.Ad;
                    row.Cells[2].Value = frm.Cicek.Kategori;
                    row.Cells[3].Value = frm.Cicek.Fiyat;
                    row.Cells[4].Value = frm.Cicek.Stok;
                    row.Cells[5].Value = frm.Cicek.Detay;




                }

            }
        }

        private void btnÇiçekBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.CicekGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnÇiçekSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var id = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili Kayıtı Silmek İstermisiniz?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.CıcekSil(id);

                {

                    if (b)
                    {

                        DataSet ds = BLogic.CicekGetir("");
                        if (ds != null)
                            dataGridView2.DataSource = ds.Tables[0];
                    }




                }
            }
        }

        private void Cicekler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.CicekGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        public Cicek Cicek { get; set; }
        private void BtnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            
            
                
                Cicek = new Cicek()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Kategori = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Stok = double.Parse(row.Cells[4].Value.ToString()),
                    Detay = row.Cells[5].Value.ToString(),


                };
            DialogResult = DialogResult.OK;
            


        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
