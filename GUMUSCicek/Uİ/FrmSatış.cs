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
    public partial class FrmSatış : Form
    {
        public FrmSatış()
        {
            InitializeComponent();
        }



        public bool Güncelleme { get; set; } = false;
        public Satis Satis { get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value==0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen Fiyat Giriniz...");
                nmFiyat.Focus();
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Satis.Tarih = dtTarih.Value;
            Satis.Fiyat = (double)nmFiyat.Value;
            Satis.Cicekid = Guid.Parse( txtÇiçek.Text);
            Satis.Musteriid = Guid.Parse(txtMüşteri.Text);


            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmSatış_Load(object sender, EventArgs e)
        {
            txtID.Text = Satis.ID.ToString();
            if(Güncelleme)
            {
                txtMüşteri.Text = Satis.Musteriid.ToString();
                txtÇiçek.Text = Satis.Cicekid.ToString();
                nmFiyat.Value = (decimal)Satis.Fiyat;
                dtTarih.Value = Satis.Tarih;

            }
            
        }

        private void btnMusteriSeç_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                //Musteri = frm.musteri;
                txtMüşteri.Text =frm.musteri.ID.ToString ();
            }
        }

        private void btnÇiçekSeç_Click(object sender, EventArgs e)
        {
            Cicekler frm = new Cicekler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //cicek = frm.Cicek;
                txtÇiçek.Text = frm.Cicek.ID.ToString();
            }
        }
    }
}
