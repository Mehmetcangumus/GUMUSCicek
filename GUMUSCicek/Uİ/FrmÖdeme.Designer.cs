
namespace GUMUSCicek.Uİ
{
    partial class FrmÖdeme
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
            this.components = new System.ComponentModel.Container();
            this.nmTutar = new System.Windows.Forms.NumericUpDown();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMüşteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMusteriSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmTutar
            // 
            this.nmTutar.Location = new System.Drawing.Point(96, 112);
            this.nmTutar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmTutar.Name = "nmTutar";
            this.nmTutar.Size = new System.Drawing.Size(179, 20);
            this.nmTutar.TabIndex = 3;
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(200, 298);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 7;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(96, 298);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 6;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ödeme Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ödeme Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ödeme Tarihi:";
            // 
            // txtMüşteri
            // 
            this.txtMüşteri.Location = new System.Drawing.Point(96, 60);
            this.txtMüşteri.Name = "txtMüşteri";
            this.txtMüşteri.Size = new System.Drawing.Size(179, 20);
            this.txtMüşteri.TabIndex = 1;
            this.txtMüşteri.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Müşteri:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 31);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(179, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID:";
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Location = new System.Drawing.Point(96, 165);
            this.txtAçıklama.Multiline = true;
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAçıklama.Size = new System.Drawing.Size(182, 102);
            this.txtAçıklama.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Açıklama:";
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "EFT/HAVALE"});
            this.cmbTur.Location = new System.Drawing.Point(96, 139);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(176, 21);
            this.cmbTur.TabIndex = 4;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(96, 86);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(182, 20);
            this.dtTarih.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMusteriSeç
            // 
            this.btnMusteriSeç.Location = new System.Drawing.Point(304, 80);
            this.btnMusteriSeç.Name = "btnMusteriSeç";
            this.btnMusteriSeç.Size = new System.Drawing.Size(94, 37);
            this.btnMusteriSeç.TabIndex = 43;
            this.btnMusteriSeç.Text = "Müşteri Seç";
            this.btnMusteriSeç.UseVisualStyleBackColor = true;
            this.btnMusteriSeç.Click += new System.EventHandler(this.btnMusteriSeç_Click);
            // 
            // FrmÖdeme
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(410, 358);
            this.Controls.Add(this.btnMusteriSeç);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtAçıklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmTutar);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMüşteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmÖdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.FrmÖdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nmTutar;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMüşteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMusteriSeç;
    }
}