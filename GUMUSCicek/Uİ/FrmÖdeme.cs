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
    public partial class FrmÖdeme : Form
    {
        public FrmÖdeme()
        {
            InitializeComponent();
        }
        public bool Güncelleme { get; set; } = false;
        public Ödeme Ödeme { get; set; }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lütfen Tutar Giriniz...");
                nmTutar.Focus();
            }
            else
            {
                errorProvider1.SetError(nmTutar, "");

            }
            if (cmbTur.SelectedItem==null )
            {
                errorProvider1.SetError(cmbTur, "Ödeme Türü Seçiniz");
                cmbTur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cmbTur, "");
               
            }
            if (txtAçıklama.Text == "")
            {
                errorProvider1.SetError(txtAçıklama, "Açıklama Giriniz...");
                txtAçıklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAçıklama, "");

            }
            Ödeme.Musteriid =Guid.Parse( txtMüşteri.Text);
            Ödeme.Tur = cmbTur.SelectedItem.ToString();
            Ödeme.Tutar = (double)nmTutar.Value;
            Ödeme.Aciklama = txtAçıklama.Text;
            Ödeme.Tarih = dtTarih.Value;


            DialogResult = DialogResult.OK;



        }

        private void FrmÖdeme_Load(object sender, EventArgs e)
        {
            txtID.Text = Ödeme.ID.ToString();
            if (Güncelleme)
            {
                txtMüşteri.Text = Ödeme.Musteriid.ToString();
                dtTarih.Value = Ödeme.Tarih;
                nmTutar.Value = (decimal)Ödeme.Tutar;
                cmbTur.SelectedItem = Ödeme.Tur;
                txtAçıklama.Text = Ödeme.Aciklama.ToString();
                

            }
        }

        private void btnMusteriSeç_Click(object sender, EventArgs e)
        {            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Musteri = frm.musteri;
                txtMüşteri.Text = frm.musteri.ID.ToString();
            }
        }
    }
    }

