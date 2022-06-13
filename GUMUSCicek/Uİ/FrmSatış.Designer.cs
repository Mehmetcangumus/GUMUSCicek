
namespace GUMUSCicek.Uİ
{
    partial class FrmSatış
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtÇiçek = new System.Windows.Forms.ComboBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMüşteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMusteriSeç = new System.Windows.Forms.Button();
            this.btnÇiçekSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmFiyat
            // 
            this.nmFiyat.Location = new System.Drawing.Point(76, 104);
            this.nmFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(179, 20);
            this.nmFiyat.TabIndex = 3;
            // 
            // txtÇiçek
            // 
            this.txtÇiçek.FormattingEnabled = true;
            this.txtÇiçek.Items.AddRange(new object[] {
            "Saksı Çiçekleri",
            "Çiçek Buketleri",
            "Güller",
            "Orkide",
            "Tasarım Çiçekler",
            "Yapay Çiçekler",
            "Yenilebilinir Çiçekler"});
            this.txtÇiçek.Location = new System.Drawing.Point(76, 74);
            this.txtÇiçek.Name = "txtÇiçek";
            this.txtÇiçek.Size = new System.Drawing.Size(176, 21);
            this.txtÇiçek.TabIndex = 2;
            this.txtÇiçek.TabStop = false;
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(180, 199);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 6;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(76, 199);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Satış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Çiçek:";
            // 
            // txtMüşteri
            // 
            this.txtMüşteri.Location = new System.Drawing.Point(76, 52);
            this.txtMüşteri.Name = "txtMüşteri";
            this.txtMüşteri.Size = new System.Drawing.Size(179, 20);
            this.txtMüşteri.TabIndex = 1;
            this.txtMüşteri.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Müşteri:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 23);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(179, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(76, 131);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(179, 20);
            this.dtTarih.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMusteriSeç
            // 
            this.btnMusteriSeç.Location = new System.Drawing.Point(295, 45);
            this.btnMusteriSeç.Name = "btnMusteriSeç";
            this.btnMusteriSeç.Size = new System.Drawing.Size(94, 37);
            this.btnMusteriSeç.TabIndex = 29;
            this.btnMusteriSeç.Text = "Müşteri Seç";
            this.btnMusteriSeç.UseVisualStyleBackColor = true;
            this.btnMusteriSeç.Click += new System.EventHandler(this.btnMusteriSeç_Click);
            // 
            // btnÇiçekSeç
            // 
            this.btnÇiçekSeç.Location = new System.Drawing.Point(295, 91);
            this.btnÇiçekSeç.Name = "btnÇiçekSeç";
            this.btnÇiçekSeç.Size = new System.Drawing.Size(94, 39);
            this.btnÇiçekSeç.TabIndex = 30;
            this.btnÇiçekSeç.Text = "Çiçek Seç";
            this.btnÇiçekSeç.UseVisualStyleBackColor = true;
            this.btnÇiçekSeç.Click += new System.EventHandler(this.btnÇiçekSeç_Click);
            // 
            // FrmSatış
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(401, 269);
            this.Controls.Add(this.btnÇiçekSeç);
            this.Controls.Add(this.btnMusteriSeç);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.txtÇiçek);
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
            this.Name = "FrmSatış";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSatış";
            this.Load += new System.EventHandler(this.FrmSatış_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.ComboBox txtÇiçek;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMüşteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnÇiçekSeç;
        private System.Windows.Forms.Button btnMusteriSeç;
    }
}