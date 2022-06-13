
namespace GUMUSCicek.Uİ
{
    partial class Cicekler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cicekler));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnÇiçekEkle = new System.Windows.Forms.ToolStripButton();
            this.btnÇiçekDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnÇiçekSil = new System.Windows.Forms.ToolStripButton();
            this.btnÇiçekBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.BtnTamam = new System.Windows.Forms.Button();
            this.Btnİptal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btnİptal);
            this.tabPage2.Controls.Add(this.BtnTamam);
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ÇİÇEKLER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(3, 349);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(635, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(635, 280);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnÇiçekEkle,
            this.btnÇiçekDüzenle,
            this.btnÇiçekSil,
            this.btnÇiçekBul,
            this.toolStripTextBox2,
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(635, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnÇiçekEkle
            // 
            this.btnÇiçekEkle.Image = global::GUMUSCicek.Properties.Resources.plus;
            this.btnÇiçekEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇiçekEkle.Name = "btnÇiçekEkle";
            this.btnÇiçekEkle.Size = new System.Drawing.Size(80, 22);
            this.btnÇiçekEkle.Text = "Çiçek Ekle";
            this.btnÇiçekEkle.Click += new System.EventHandler(this.btnÇiçekEkle_Click);
            // 
            // btnÇiçekDüzenle
            // 
            this.btnÇiçekDüzenle.Image = global::GUMUSCicek.Properties.Resources.user;
            this.btnÇiçekDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇiçekDüzenle.Name = "btnÇiçekDüzenle";
            this.btnÇiçekDüzenle.Size = new System.Drawing.Size(101, 22);
            this.btnÇiçekDüzenle.Text = "Çiçek Düzenle";
            this.btnÇiçekDüzenle.Click += new System.EventHandler(this.btnÇiçekDüzenle_Click);
            // 
            // btnÇiçekSil
            // 
            this.btnÇiçekSil.Image = global::GUMUSCicek.Properties.Resources.clear;
            this.btnÇiçekSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇiçekSil.Name = "btnÇiçekSil";
            this.btnÇiçekSil.Size = new System.Drawing.Size(71, 22);
            this.btnÇiçekSil.Text = "Çiçek Sil";
            this.btnÇiçekSil.Click += new System.EventHandler(this.btnÇiçekSil_Click);
            // 
            // btnÇiçekBul
            // 
            this.btnÇiçekBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnÇiçekBul.Image = global::GUMUSCicek.Properties.Resources.search__1_;
            this.btnÇiçekBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇiçekBul.Name = "btnÇiçekBul";
            this.btnÇiçekBul.Size = new System.Drawing.Size(44, 22);
            this.btnÇiçekBul.Text = "Bul";
            this.btnÇiçekBul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnÇiçekBul.Click += new System.EventHandler(this.btnÇiçekBul_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton6.Text = "Ara";
            // 
            // BtnTamam
            // 
            this.BtnTamam.Location = new System.Drawing.Point(429, 314);
            this.BtnTamam.Name = "BtnTamam";
            this.BtnTamam.Size = new System.Drawing.Size(84, 32);
            this.BtnTamam.TabIndex = 5;
            this.BtnTamam.Text = "TAMAM";
            this.BtnTamam.UseVisualStyleBackColor = true;
            this.BtnTamam.Click += new System.EventHandler(this.BtnTamam_Click);
            // 
            // Btnİptal
            // 
            this.Btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btnİptal.Location = new System.Drawing.Point(519, 314);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(84, 32);
            this.Btnİptal.TabIndex = 6;
            this.Btnİptal.Text = "İPTAL";
            this.Btnİptal.UseVisualStyleBackColor = true;
            this.Btnİptal.Click += new System.EventHandler(this.Btnİptal_Click);
            // 
            // Cicekler
            // 
            this.AcceptButton = this.BtnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btnİptal;
            this.ClientSize = new System.Drawing.Size(653, 377);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cicekler";
            this.Text = "Cicekler";
            this.Load += new System.EventHandler(this.Cicekler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnÇiçekEkle;
        private System.Windows.Forms.ToolStripButton btnÇiçekDüzenle;
        private System.Windows.Forms.ToolStripButton btnÇiçekSil;
        private System.Windows.Forms.ToolStripButton btnÇiçekBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Button Btnİptal;
        private System.Windows.Forms.Button BtnTamam;
    }
}