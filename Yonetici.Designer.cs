namespace cafeotomasyon
{
    partial class Yonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici));
            this.listYonetici = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnYoneticiGuncelle = new System.Windows.Forms.Button();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.textParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listYonetici
            // 
            this.listYonetici.AllowColumnReorder = true;
            this.listYonetici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listYonetici.FullRowSelect = true;
            this.listYonetici.GridLines = true;
            this.listYonetici.Location = new System.Drawing.Point(329, 233);
            this.listYonetici.Name = "listYonetici";
            this.listYonetici.Size = new System.Drawing.Size(633, 277);
            this.listYonetici.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listYonetici.TabIndex = 33;
            this.listYonetici.UseCompatibleStateImageBehavior = false;
            this.listYonetici.View = System.Windows.Forms.View.Details;
            this.listYonetici.SelectedIndexChanged += new System.EventHandler(this.listYonetici_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "AD";
            this.columnHeader6.Width = 156;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SOYAD";
            this.columnHeader7.Width = 166;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PAROLA";
            this.columnHeader8.Width = 229;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriSil.BackgroundImage")));
            this.btnMusteriSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriSil.ForeColor = System.Drawing.Color.Transparent;
            this.btnMusteriSil.Location = new System.Drawing.Point(768, 537);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(100, 81);
            this.btnMusteriSil.TabIndex = 32;
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnYoneticiGuncelle
            // 
            this.btnYoneticiGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnYoneticiGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYoneticiGuncelle.BackgroundImage")));
            this.btnYoneticiGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYoneticiGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYoneticiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYoneticiGuncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoneticiGuncelle.Location = new System.Drawing.Point(617, 537);
            this.btnYoneticiGuncelle.Name = "btnYoneticiGuncelle";
            this.btnYoneticiGuncelle.Size = new System.Drawing.Size(100, 81);
            this.btnYoneticiGuncelle.TabIndex = 29;
            this.btnYoneticiGuncelle.UseVisualStyleBackColor = false;
            this.btnYoneticiGuncelle.Click += new System.EventHandler(this.btnYoneticiGuncelle_Click);
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnYoneticiEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYoneticiEkle.BackgroundImage")));
            this.btnYoneticiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYoneticiEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYoneticiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYoneticiEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoneticiEkle.Location = new System.Drawing.Point(452, 537);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(100, 81);
            this.btnYoneticiEkle.TabIndex = 28;
            this.btnYoneticiEkle.UseVisualStyleBackColor = false;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // textParola
            // 
            this.textParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textParola.Location = new System.Drawing.Point(820, 194);
            this.textParola.Name = "textParola";
            this.textParola.PasswordChar = '*';
            this.textParola.Size = new System.Drawing.Size(140, 24);
            this.textParola.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(837, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "PAROLA";
            // 
            // textSoyad
            // 
            this.textSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSoyad.Location = new System.Drawing.Point(655, 194);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(140, 24);
            this.textSoyad.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(676, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "SOYAD";
            // 
            // textAD
            // 
            this.textAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAD.Location = new System.Drawing.Point(491, 194);
            this.textAD.Name = "textAD";
            this.textAD.Size = new System.Drawing.Size(140, 24);
            this.textAD.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(536, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "AD";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textID.Location = new System.Drawing.Point(327, 194);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(140, 24);
            this.textID.TabIndex = 35;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelID.ForeColor = System.Drawing.Color.Transparent;
            this.labelID.Location = new System.Drawing.Point(372, 162);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(38, 29);
            this.labelID.TabIndex = 34;
            this.labelID.Text = "ID";
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 707);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.listYonetici);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnYoneticiGuncelle);
            this.Controls.Add(this.btnYoneticiEkle);
            this.Controls.Add(this.textParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAD);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Yonetici";
            this.Text = "Yonetici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Yonetici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listYonetici;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnYoneticiGuncelle;
        private System.Windows.Forms.Button btnYoneticiEkle;
        private System.Windows.Forms.TextBox textParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelID;
    }
}