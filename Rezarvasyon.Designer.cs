namespace cafeotomasyon
{
    partial class Rezarvasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezarvasyon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdRezarvasyon = new System.Windows.Forms.TextBox();
            this.txtSoyadRezarvasyon = new System.Windows.Forms.TextBox();
            this.txtSaatRezarvasyon = new System.Windows.Forms.TextBox();
            this.masaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet8 = new cafeotomasyon.cafeDataSet8();
            this.cmbMasaRezarvasyon = new System.Windows.Forms.ComboBox();
            this.masaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet9 = new cafeotomasyon.cafeDataSet9();
            this.masaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet10 = new cafeotomasyon.cafeDataSet10();
            this.btnRezarvasyon = new System.Windows.Forms.Button();
            this.masaTableAdapter = new cafeotomasyon.cafeDataSet8TableAdapters.masaTableAdapter();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtTarihRezarvasyon = new System.Windows.Forms.TextBox();
            this.masaTableAdapter1 = new cafeotomasyon.cafeDataSet9TableAdapters.masaTableAdapter();
            this.masaTableAdapter2 = new cafeotomasyon.cafeDataSet10TableAdapters.masaTableAdapter();
            this.cafeDataSet11 = new cafeotomasyon.cafeDataSet11();
            this.masalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masalarTableAdapter = new cafeotomasyon.cafeDataSet11TableAdapters.masalarTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(523, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(481, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(493, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(492, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Masa :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(502, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saat :";
            // 
            // txtAdRezarvasyon
            // 
            this.txtAdRezarvasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdRezarvasyon.Location = new System.Drawing.Point(587, 111);
            this.txtAdRezarvasyon.Multiline = true;
            this.txtAdRezarvasyon.Name = "txtAdRezarvasyon";
            this.txtAdRezarvasyon.Size = new System.Drawing.Size(170, 29);
            this.txtAdRezarvasyon.TabIndex = 6;
            // 
            // txtSoyadRezarvasyon
            // 
            this.txtSoyadRezarvasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadRezarvasyon.Location = new System.Drawing.Point(587, 186);
            this.txtSoyadRezarvasyon.Multiline = true;
            this.txtSoyadRezarvasyon.Name = "txtSoyadRezarvasyon";
            this.txtSoyadRezarvasyon.Size = new System.Drawing.Size(170, 29);
            this.txtSoyadRezarvasyon.TabIndex = 7;
            // 
            // txtSaatRezarvasyon
            // 
            this.txtSaatRezarvasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaatRezarvasyon.Location = new System.Drawing.Point(587, 423);
            this.txtSaatRezarvasyon.Multiline = true;
            this.txtSaatRezarvasyon.Name = "txtSaatRezarvasyon";
            this.txtSaatRezarvasyon.Size = new System.Drawing.Size(170, 29);
            this.txtSaatRezarvasyon.TabIndex = 9;
            // 
            // masaBindingSource
            // 
            this.masaBindingSource.DataMember = "masa";
            this.masaBindingSource.DataSource = this.cafeDataSet8;
            // 
            // cafeDataSet8
            // 
            this.cafeDataSet8.DataSetName = "cafeDataSet8";
            this.cafeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMasaRezarvasyon
            // 
            this.cmbMasaRezarvasyon.DataSource = this.masaBindingSource1;
            this.cmbMasaRezarvasyon.DisplayMember = "masaID";
            this.cmbMasaRezarvasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMasaRezarvasyon.FormattingEnabled = true;
            this.cmbMasaRezarvasyon.Location = new System.Drawing.Point(587, 489);
            this.cmbMasaRezarvasyon.Name = "cmbMasaRezarvasyon";
            this.cmbMasaRezarvasyon.Size = new System.Drawing.Size(170, 28);
            this.cmbMasaRezarvasyon.TabIndex = 11;
            this.cmbMasaRezarvasyon.ValueMember = "masaID";
            this.cmbMasaRezarvasyon.SelectedIndexChanged += new System.EventHandler(this.cmbMasaRezarvasyon_SelectedIndexChanged);
            // 
            // masaBindingSource1
            // 
            this.masaBindingSource1.DataMember = "masa";
            this.masaBindingSource1.DataSource = this.cafeDataSet9;
            // 
            // cafeDataSet9
            // 
            this.cafeDataSet9.DataSetName = "cafeDataSet9";
            this.cafeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masaBindingSource2
            // 
            this.masaBindingSource2.DataMember = "masa";
            this.masaBindingSource2.DataSource = this.cafeDataSet10;
            // 
            // cafeDataSet10
            // 
            this.cafeDataSet10.DataSetName = "cafeDataSet10";
            this.cafeDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRezarvasyon
            // 
            this.btnRezarvasyon.BackColor = System.Drawing.Color.Transparent;
            this.btnRezarvasyon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRezarvasyon.BackgroundImage")));
            this.btnRezarvasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRezarvasyon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezarvasyon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezarvasyon.Location = new System.Drawing.Point(620, 523);
            this.btnRezarvasyon.Name = "btnRezarvasyon";
            this.btnRezarvasyon.Size = new System.Drawing.Size(116, 94);
            this.btnRezarvasyon.TabIndex = 12;
            this.btnRezarvasyon.UseVisualStyleBackColor = false;
            this.btnRezarvasyon.Click += new System.EventHandler(this.btnRezarvasyon_Click);
            // 
            // masaTableAdapter
            // 
            this.masaTableAdapter.ClearBeforeFill = true;
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
            this.btnGeri.Location = new System.Drawing.Point(12, 666);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(47, 41);
            this.btnGeri.TabIndex = 20;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtTarihRezarvasyon
            // 
            this.txtTarihRezarvasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarihRezarvasyon.Location = new System.Drawing.Point(587, 343);
            this.txtTarihRezarvasyon.Multiline = true;
            this.txtTarihRezarvasyon.Name = "txtTarihRezarvasyon";
            this.txtTarihRezarvasyon.Size = new System.Drawing.Size(170, 29);
            this.txtTarihRezarvasyon.TabIndex = 21;
            // 
            // masaTableAdapter1
            // 
            this.masaTableAdapter1.ClearBeforeFill = true;
            // 
            // masaTableAdapter2
            // 
            this.masaTableAdapter2.ClearBeforeFill = true;
            // 
            // cafeDataSet11
            // 
            this.cafeDataSet11.DataSetName = "cafeDataSet11";
            this.cafeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masalarBindingSource
            // 
            this.masalarBindingSource.DataMember = "masalar";
            this.masalarBindingSource.DataSource = this.cafeDataSet11;
            // 
            // masalarTableAdapter
            // 
            this.masalarTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(587, 264);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 29);
            this.textBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(457, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefon : ";
            // 
            // Rezarvasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 733);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTarihRezarvasyon);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnRezarvasyon);
            this.Controls.Add(this.cmbMasaRezarvasyon);
            this.Controls.Add(this.txtSaatRezarvasyon);
            this.Controls.Add(this.txtSoyadRezarvasyon);
            this.Controls.Add(this.txtAdRezarvasyon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Rezarvasyon";
            this.Text = "Rezarvasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rezarvasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdRezarvasyon;
        private System.Windows.Forms.TextBox txtSoyadRezarvasyon;
        private System.Windows.Forms.TextBox txtSaatRezarvasyon;
        private System.Windows.Forms.ComboBox cmbMasaRezarvasyon;
        private cafeDataSet8 cafeDataSet8;
        private System.Windows.Forms.BindingSource masaBindingSource;
        private cafeDataSet8TableAdapters.masaTableAdapter masaTableAdapter;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtTarihRezarvasyon;
        private cafeDataSet9 cafeDataSet9;
        private System.Windows.Forms.BindingSource masaBindingSource1;
        private cafeDataSet9TableAdapters.masaTableAdapter masaTableAdapter1;
        private cafeDataSet10 cafeDataSet10;
        private System.Windows.Forms.BindingSource masaBindingSource2;
        private cafeDataSet10TableAdapters.masaTableAdapter masaTableAdapter2;
        public System.Windows.Forms.Button btnRezarvasyon;
        private cafeDataSet11 cafeDataSet11;
        private System.Windows.Forms.BindingSource masalarBindingSource;
        private cafeDataSet11TableAdapters.masalarTableAdapter masalarTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}