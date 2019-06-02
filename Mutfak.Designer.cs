namespace cafeotomasyon
{
    partial class Mutfak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mutfak));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new cafeotomasyon.cafeDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunGoster = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.grpBoxUrunler = new System.Windows.Forms.GroupBox();
            this.listUrun = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategoriTableAdapter = new cafeotomasyon.cafeDataSetTableAdapters.kategoriTableAdapter();
            this.cmbKategoriID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txt_urunID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.grpBoxUrunler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(680, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "KATEGORİ :";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataSource = this.kategoriBindingSource;
            this.cmbKategori.DisplayMember = "kategoriad";
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(812, 66);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(152, 26);
            this.cmbKategori.TabIndex = 4;
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "kategori";
            this.kategoriBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(688, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ÜRÜN ADI :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(812, 133);
            this.txtUrunAdi.Multiline = true;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(152, 25);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(812, 196);
            this.txtFiyat.Multiline = true;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(152, 25);
            this.txtFiyat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(726, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "FİYAT :";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.BackgroundImage")));
            this.btnUrunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunEkle.Location = new System.Drawing.Point(692, 253);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(65, 65);
            this.btnUrunEkle.TabIndex = 9;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunGuncelle.BackgroundImage")));
            this.btnUrunGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(773, 253);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(65, 65);
            this.btnUrunGuncelle.TabIndex = 10;
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunGoster
            // 
            this.btnUrunGoster.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunGoster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunGoster.BackgroundImage")));
            this.btnUrunGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunGoster.Location = new System.Drawing.Point(856, 253);
            this.btnUrunGoster.Name = "btnUrunGoster";
            this.btnUrunGoster.Size = new System.Drawing.Size(65, 65);
            this.btnUrunGoster.TabIndex = 11;
            this.btnUrunGoster.UseVisualStyleBackColor = false;
            this.btnUrunGoster.Click += new System.EventHandler(this.btnUrunGoster_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.BackgroundImage")));
            this.btnUrunSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunSil.Location = new System.Drawing.Point(943, 253);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(65, 65);
            this.btnUrunSil.TabIndex = 12;
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // grpBoxUrunler
            // 
            this.grpBoxUrunler.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxUrunler.Controls.Add(this.listUrun);
            this.grpBoxUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxUrunler.ForeColor = System.Drawing.Color.White;
            this.grpBoxUrunler.Location = new System.Drawing.Point(548, 356);
            this.grpBoxUrunler.Name = "grpBoxUrunler";
            this.grpBoxUrunler.Size = new System.Drawing.Size(589, 260);
            this.grpBoxUrunler.TabIndex = 13;
            this.grpBoxUrunler.TabStop = false;
            this.grpBoxUrunler.Text = "ÜRÜNLER";
            this.grpBoxUrunler.Visible = false;
            // 
            // listUrun
            // 
            this.listUrun.AllowColumnReorder = true;
            this.listUrun.CheckBoxes = true;
            this.listUrun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrun.FullRowSelect = true;
            this.listUrun.GridLines = true;
            this.listUrun.Location = new System.Drawing.Point(6, 28);
            this.listUrun.Name = "listUrun";
            this.listUrun.Size = new System.Drawing.Size(577, 220);
            this.listUrun.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listUrun.TabIndex = 0;
            this.listUrun.UseCompatibleStateImageBehavior = false;
            this.listUrun.View = System.Windows.Forms.View.Details;
            this.listUrun.SelectedIndexChanged += new System.EventHandler(this.listUrun_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "UrunID";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "UrunAd";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UrunFiyat";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KategoriID";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KategoriAd";
            this.columnHeader5.Width = 149;
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // cmbKategoriID
            // 
            this.cmbKategoriID.DataSource = this.kategoriBindingSource;
            this.cmbKategoriID.DisplayMember = "kategoriID";
            this.cmbKategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriID.FormattingEnabled = true;
            this.cmbKategoriID.Location = new System.Drawing.Point(812, 9);
            this.cmbKategoriID.Name = "cmbKategoriID";
            this.cmbKategoriID.Size = new System.Drawing.Size(152, 26);
            this.cmbKategoriID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(655, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "KATEGORİ ID :";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeri.Location = new System.Drawing.Point(12, 654);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(47, 41);
            this.btnGeri.TabIndex = 20;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txt_urunID
            // 
            this.txt_urunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunID.Location = new System.Drawing.Point(436, 136);
            this.txt_urunID.Multiline = true;
            this.txt_urunID.Name = "txt_urunID";
            this.txt_urunID.Size = new System.Drawing.Size(152, 25);
            this.txt_urunID.TabIndex = 22;
            this.txt_urunID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(332, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "URUN ID:";
            this.label5.Visible = false;
            // 
            // Mutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txt_urunID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cmbKategoriID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpBoxUrunler);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunGoster);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label1);
            this.Name = "Mutfak";
            this.Text = "Mutfak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mutfak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.grpBoxUrunler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunGoster;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.GroupBox grpBoxUrunler;
        private System.Windows.Forms.ListView listUrun;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private cafeDataSetTableAdapters.kategoriTableAdapter kategoriTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cmbKategoriID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txt_urunID;
        private System.Windows.Forms.Label label5;
    }
}