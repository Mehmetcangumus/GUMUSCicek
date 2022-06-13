using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUMUSCicek.BL;
using GUMUSCicek.Uİ;

namespace GUMUSCicek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Musteriler mf = new Musteriler();
        Cicekler cf = new Cicekler();
        
        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnCicekler_Click(object sender, EventArgs e)
        {
            cf.ShowDialog();
        }

        private void btnSatısyap_Click(object sender, EventArgs e)
        {
            FrmSatış frm = new FrmSatış()
            {
                Text = "Satış Yap",
                Satis = new Satis()
                {
                    ID = Guid.NewGuid()
                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatışEkle(frm.Satis);
                if (b)
                {

                    DataSet ds = BLogic.SatisDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.SatisDetay();
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

            DataSet ds2 = BLogic.ÖdemeDetay();
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        private void btnSatışDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmSatış frm = new FrmSatış()
            {
                Text = "Satış Düzenle",
                Güncelleme = true,
                Satis = new Satis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Musteriid= Guid.Parse(row.Cells[1].Value.ToString()),
                    Cicekid=Guid.Parse( row.Cells[2].Value.ToString()),
                    Fiyat =double.Parse( row.Cells[6].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[7].Value.ToString()),
                    


                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatışGüncelle(frm.Satis);
                if (b)
                {

                    row.Cells[1].Value = frm.Satis.Musteriid;
                    row.Cells[2].Value = frm.Satis.Cicekid;
                    row.Cells[6].Value = frm.Satis.Fiyat;
                    row.Cells[7].Value = frm.Satis.Tarih;
                    




                }

            }
        }

        private void btnSatışSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili Kayıtı Silmek İstermisiniz?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatışSil(ID);

                {

                    if (b)
                    {
                        DataSet ds = BLogic.SatisDetay();
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];

                    }




                }

            }
        }

        private void btnÖdemeyap_Click(object sender, EventArgs e)
        {
            FrmÖdeme frm = new FrmÖdeme()
            {
                Text = "Ödeme Yap",
                Ödeme = new Ödeme()
                {
                    ID = Guid.NewGuid()
                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÖdemeEkle(frm.Ödeme);
               if (b)
                {

                    DataSet ds = BLogic.ÖdemeDetay();
                   if (ds != null)
                       dataGridView2.DataSource = ds.Tables[0];
                }

            }
        }

        private void btnödemedüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmÖdeme frm = new FrmÖdeme()
            {
                Text = "Ödeme Düzenle",
                Güncelleme = true,
                Ödeme = new Ödeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Musteriid = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Tutar= double.Parse(row.Cells[4].Value.ToString()),
                    Tur = row.Cells[5].Value.ToString(),
                    Aciklama = row.Cells[6].Value.ToString(),



                   
                    
                    



                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÖdemeGüncelle(frm.Ödeme);
                if (b)
                {

                    row.Cells[1].Value = frm.Ödeme.Musteriid;
                    row.Cells[3].Value = frm.Ödeme.Tarih;
                    row.Cells[4].Value = frm.Ödeme.Tutar;
                    row.Cells[5].Value = frm.Ödeme.Tur;
                    row.Cells[6].Value = frm.Ödeme.Aciklama;





                }

            }
        }

        private void btnödemesil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili Kayıtı Silmek İstermisiniz?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÖdemeSil(ID);

                {

                    if (b)
                    {

                        DataSet ds2 = BLogic.ÖdemeDetay();
                        if (ds2 != null)
                            dataGridView2.DataSource = ds2.Tables[0];
                    }




                }

            }

           
        }
    }
}

