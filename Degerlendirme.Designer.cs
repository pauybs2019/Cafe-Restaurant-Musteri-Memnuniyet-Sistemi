namespace cafeotomasyon
{
    partial class Degerlendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Degerlendirme));
            this.btnSonucGoster = new System.Windows.Forms.Button();
            this.listSonuc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbKategoriID = new System.Windows.Forms.ComboBox();
            this.masalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet14 = new cafeotomasyon.cafeDataSet14();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.masalarTableAdapter = new cafeotomasyon.cafeDataSet14TableAdapters.masalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSonucGoster
            // 
            this.btnSonucGoster.BackColor = System.Drawing.Color.Transparent;
            this.btnSonucGoster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSonucGoster.BackgroundImage")));
            this.btnSonucGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSonucGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonucGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonucGoster.Location = new System.Drawing.Point(672, 590);
            this.btnSonucGoster.Name = "btnSonucGoster";
            this.btnSonucGoster.Size = new System.Drawing.Size(65, 65);
            this.btnSonucGoster.TabIndex = 15;
            this.btnSonucGoster.UseVisualStyleBackColor = false;
            this.btnSonucGoster.Click += new System.EventHandler(this.btnSonucGoster_Click);
            // 
            // listSonuc
            // 
            this.listSonuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.listSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listSonuc.GridLines = true;
            this.listSonuc.Location = new System.Drawing.Point(409, 265);
            this.listSonuc.Name = "listSonuc";
            this.listSonuc.Size = new System.Drawing.Size(579, 319);
            this.listSonuc.TabIndex = 16;
            this.listSonuc.UseCompatibleStateImageBehavior = false;
            this.listSonuc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Servis";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aciklama";
            this.columnHeader4.Width = 508;
            // 
            // cmbKategoriID
            // 
            this.cmbKategoriID.DataSource = this.masalarBindingSource;
            this.cmbKategoriID.DisplayMember = "masaAdi";
            this.cmbKategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriID.FormattingEnabled = true;
            this.cmbKategoriID.Location = new System.Drawing.Point(661, 132);
            this.cmbKategoriID.Name = "cmbKategoriID";
            this.cmbKategoriID.Size = new System.Drawing.Size(152, 26);
            this.cmbKategoriID.TabIndex = 20;
            // 
            // masalarBindingSource
            // 
            this.masalarBindingSource.DataMember = "masalar";
            this.masalarBindingSource.DataSource = this.cafeDataSet14;
            // 
            // cafeDataSet14
            // 
            this.cafeDataSet14.DataSetName = "cafeDataSet14";
            this.cafeDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(570, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "MASA :";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataSource = this.masalarBindingSource;
            this.cmbKategori.DisplayMember = "sorumlu";
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(661, 189);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(152, 26);
            this.cmbKategori.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(529, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "SORUMLU :";
            // 
            // masalarTableAdapter
            // 
            this.masalarTableAdapter.ClearBeforeFill = true;
            // 
            // Degerlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 744);
            this.Controls.Add(this.cmbKategoriID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSonuc);
            this.Controls.Add(this.btnSonucGoster);
            this.Name = "Degerlendirme";
            this.Text = "Degerlendirme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Degerlendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSonucGoster;
        private System.Windows.Forms.ListView listSonuc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cmbKategoriID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label1;
        private cafeDataSet14 cafeDataSet14;
        private System.Windows.Forms.BindingSource masalarBindingSource;
        private cafeDataSet14TableAdapters.masalarTableAdapter masalarTableAdapter;
    }
}