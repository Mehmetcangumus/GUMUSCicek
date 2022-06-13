
namespace GUMUSCicek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMusteriler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCicekler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSatısyap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnÖdemeyap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSatışDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSatışSil = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnödemedüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnödemesil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusteriler,
            this.toolStripSeparator1,
            this.btnCicekler,
            this.toolStripSeparator2,
            this.btnSatısyap,
            this.toolStripSeparator3,
            this.btnÖdemeyap,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(627, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.Image")));
            this.btnMusteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(109, 36);
            this.btnMusteriler.Text = "MÜŞTERİLER";
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnCicekler
            // 
            this.btnCicekler.Image = ((System.Drawing.Image)(resources.GetObject("btnCicekler.Image")));
            this.btnCicekler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCicekler.Name = "btnCicekler";
            this.btnCicekler.Size = new System.Drawing.Size(94, 36);
            this.btnCicekler.Text = "ÇİÇEKLER";
            this.btnCicekler.Click += new System.EventHandler(this.btnCicekler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSatısyap
            // 
            this.btnSatısyap.Image = ((System.Drawing.Image)(resources.GetObject("btnSatısyap.Image")));
            this.btnSatısyap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatısyap.Name = "btnSatısyap";
            this.btnSatısyap.Size = new System.Drawing.Size(95, 36);
            this.btnSatısyap.Text = "SATIŞ YAP";
            this.btnSatısyap.Click += new System.EventHandler(this.btnSatısyap_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnÖdemeyap
            // 
            this.btnÖdemeyap.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdemeyap.Image")));
            this.btnÖdemeyap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeyap.Name = "btnÖdemeyap";
            this.btnÖdemeyap.Size = new System.Drawing.Size(107, 36);
            this.btnÖdemeyap.Text = "ÖDEME YAP";
            this.btnÖdemeyap.Click += new System.EventHandler(this.btnÖdemeyap_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 329);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnİptal);
            this.tabPage1.Controls.Add(this.btnTamam);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SATIŞLAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnİptal
            // 
            this.btnİptal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(500, 295);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(93, 2);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.Location = new System.Drawing.Point(402, 295);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(93, 2);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(612, 261);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSatışDüzenle,
            this.btnSatışSil,
            this.btnMüşteriBul,
            this.toolStripTextBox1,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(612, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSatışDüzenle
            // 
            this.btnSatışDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışDüzenle.Image")));
            this.btnSatışDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışDüzenle.Name = "btnSatışDüzenle";
            this.btnSatışDüzenle.Size = new System.Drawing.Size(96, 22);
            this.btnSatışDüzenle.Text = "Satış Düzenle";
            this.btnSatışDüzenle.Click += new System.EventHandler(this.btnSatışDüzenle_Click);
            // 
            // btnSatışSil
            // 
            this.btnSatışSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışSil.Image")));
            this.btnSatışSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışSil.Name = "btnSatışSil";
            this.btnSatışSil.Size = new System.Drawing.Size(66, 22);
            this.btnSatışSil.Text = "Satış Sil";
            this.btnSatışSil.Click += new System.EventHandler(this.btnSatışSil_Click);
            // 
            // btnMüşteriBul
            // 
            this.btnMüşteriBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMüşteriBul.Image = global::GUMUSCicek.Properties.Resources.search;
            this.btnMüşteriBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriBul.Name = "btnMüşteriBul";
            this.btnMüşteriBul.Size = new System.Drawing.Size(44, 22);
            this.btnMüşteriBul.Text = "Bul";
            this.btnMüşteriBul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton4.Text = "Ara";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ÖDEMELER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 33);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(612, 261);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnödemedüzenle,
            this.btnödemesil,
            this.toolStripButton3,
            this.toolStripTextBox2,
            this.toolStripButton5});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(612, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnödemedüzenle
            // 
            this.btnödemedüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnödemedüzenle.Image")));
            this.btnödemedüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnödemedüzenle.Name = "btnödemedüzenle";
            this.btnödemedüzenle.Size = new System.Drawing.Size(111, 22);
            this.btnödemedüzenle.Text = "Ödeme Düzenle";
            this.btnödemedüzenle.Click += new System.EventHandler(this.btnödemedüzenle_Click);
            // 
            // btnödemesil
            // 
            this.btnödemesil.Image = ((System.Drawing.Image)(resources.GetObject("btnödemesil.Image")));
            this.btnödemesil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnödemesil.Name = "btnödemesil";
            this.btnödemesil.Size = new System.Drawing.Size(81, 22);
            this.btnödemesil.Text = "Ödeme Sil";
            this.btnödemesil.Click += new System.EventHandler(this.btnödemesil_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = global::GUMUSCicek.Properties.Resources.search;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton3.Text = "Bul";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton5.Text = "Ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 362);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMusteriler;
        private System.Windows.Forms.ToolStripButton btnCicekler;
        private System.Windows.Forms.ToolStripButton btnSatısyap;
        private System.Windows.Forms.ToolStripButton btnÖdemeyap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSatışDüzenle;
        private System.Windows.Forms.ToolStripButton btnSatışSil;
        private System.Windows.Forms.ToolStripButton btnMüşteriBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnödemedüzenle;
        private System.Windows.Forms.ToolStripButton btnödemesil;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

