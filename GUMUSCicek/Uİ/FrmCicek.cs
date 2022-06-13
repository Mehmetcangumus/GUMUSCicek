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
    public partial class FrmCicek : Form
    {
        public FrmCicek()
        {
            InitializeComponent();
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox ||c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }



            }
            else
            {
                errorProvider1.SetError(c, "");
                return true;
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value==0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(c, "");
                return true;
            }
            return true;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtCıcekAdı)) return;
            if (!ErrorControl(cbKategori)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(nmStok)) return;
            if (!ErrorControl(txtDetay)) return;

            Cicek.Ad = txtCıcekAdı.Text;
            Cicek.Kategori = cbKategori.Text;
            Cicek.Fiyat = (double)nmFiyat.Value;
            Cicek.Stok = (double)nmStok.Value;
            Cicek.Detay = txtDetay.Text;




            DialogResult = DialogResult.OK;
            
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Cicek Cicek { get; set; }
        public bool Güncelleme { get; set; } = false;



        private void FrmCicek_Load(object sender, EventArgs e)
        {
            txtID.Text = Cicek.ID.ToString();
            if(Güncelleme)
            {
                txtCıcekAdı.Text = Cicek.Ad;
                cbKategori.Text = Cicek.Kategori;
                nmFiyat.Value = (decimal)Cicek.Fiyat;
                nmStok.Value = (decimal)Cicek.Stok;
                txtDetay.Text = Cicek.Detay;
            }
        }
    }
}
