
namespace GUMUSCicek.Uİ
{
    partial class Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnMüşteriEkle = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriSil = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 361);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnİptal);
            this.tabPage1.Controls.Add(this.btnTamam);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MÜŞTERİLER";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(611, 261);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMüşteriEkle,
            this.btnMüşteriDüzenle,
            this.btnMüşteriSil,
            this.btnMüşteriBul,
            this.toolStripTextBox1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(611, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // btnMüşteriEkle
            // 
            this.btnMüşteriEkle.Image = global::GUMUSCicek.Properties.Resources.add;
            this.btnMüşteriEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriEkle.Name = "btnMüşteriEkle";
            this.btnMüşteriEkle.Size = new System.Drawing.Size(91, 22);
            this.btnMüşteriEkle.Text = "Müşteri Ekle";
            this.btnMüşteriEkle.Click += new System.EventHandler(this.btnMüşteriEkle_Click);
            // 
            // btnMüşteriDüzenle
            // 
            this.btnMüşteriDüzenle.Image = global::GUMUSCicek.Properties.Resources.edit;
            this.btnMüşteriDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriDüzenle.Name = "btnMüşteriDüzenle";
            this.btnMüşteriDüzenle.Size = new System.Drawing.Size(112, 22);
            this.btnMüşteriDüzenle.Text = "Müşteri Düzenle";
            this.btnMüşteriDüzenle.Click += new System.EventHandler(this.btnMüşteriDüzenle_Click);
            // 
            // btnMüşteriSil
            // 
            this.btnMüşteriSil.Image = global::GUMUSCicek.Properties.Resources.archeology;
            this.btnMüşteriSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriSil.Name = "btnMüşteriSil";
            this.btnMüşteriSil.Size = new System.Drawing.Size(82, 22);
            this.btnMüşteriSil.Text = "Müşteri Sil";
            this.btnMüşteriSil.Click += new System.EventHandler(this.btnMüşteriSil_Click);
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
            this.btnMüşteriBul.Click += new System.EventHandler(this.btnMüşteriBul_Click);
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
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.Location = new System.Drawing.Point(402, 295);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(92, 34);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(500, 295);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(92, 34);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // Musteriler
            // 
            this.AcceptButton = this.btnİptal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(637, 356);
            this.Controls.Add(this.tabControl1);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMüşteriEkle;
        private System.Windows.Forms.ToolStripButton btnMüşteriDüzenle;
        private System.Windows.Forms.ToolStripButton btnMüşteriSil;
        private System.Windows.Forms.ToolStripButton btnMüşteriBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
    }
}