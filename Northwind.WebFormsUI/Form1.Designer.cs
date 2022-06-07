
namespace Northwind.WebFormsUI
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxcategory = new System.Windows.Forms.GroupBox();
            this.cbxcategory = new System.Windows.Forms.ComboBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.gbxproduct = new System.Windows.Forms.GroupBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.lblproductname = new System.Windows.Forms.Label();
            this.gbxproductadd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxstokadeti = new System.Windows.Forms.TextBox();
            this.tbxbirimadeti = new System.Windows.Forms.TextBox();
            this.tbxfiyat = new System.Windows.Forms.TextBox();
            this.cbxkategoriadı = new System.Windows.Forms.ComboBox();
            this.tbxürünadı = new System.Windows.Forms.TextBox();
            this.lblQuantityperunit = new System.Windows.Forms.Label();
            this.lblstok = new System.Windows.Forms.Label();
            this.lblUnitprice = new System.Windows.Forms.Label();
            this.lblcategoryıd = new System.Windows.Forms.Label();
            this.lblproductname2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.tbxstokadeti2 = new System.Windows.Forms.TextBox();
            this.tbxbirimadeti2 = new System.Windows.Forms.TextBox();
            this.tbxfiyat2 = new System.Windows.Forms.TextBox();
            this.cbxkategoriadı2 = new System.Windows.Forms.ComboBox();
            this.tbxürünadı2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxcategory.SuspendLayout();
            this.gbxproduct.SuspendLayout();
            this.gbxproductadd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(13, 134);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(672, 135);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxcategory
            // 
            this.gbxcategory.Controls.Add(this.cbxcategory);
            this.gbxcategory.Controls.Add(this.lblcategory);
            this.gbxcategory.Location = new System.Drawing.Point(13, 13);
            this.gbxcategory.Name = "gbxcategory";
            this.gbxcategory.Size = new System.Drawing.Size(671, 52);
            this.gbxcategory.TabIndex = 1;
            this.gbxcategory.TabStop = false;
            this.gbxcategory.Text = "Kategoriye göre ara";
            // 
            // cbxcategory
            // 
            this.cbxcategory.FormattingEnabled = true;
            this.cbxcategory.Location = new System.Drawing.Point(58, 23);
            this.cbxcategory.Name = "cbxcategory";
            this.cbxcategory.Size = new System.Drawing.Size(203, 21);
            this.cbxcategory.TabIndex = 1;
            this.cbxcategory.SelectedIndexChanged += new System.EventHandler(this.cbxcategory_SelectedIndexChanged);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(6, 26);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(46, 13);
            this.lblcategory.TabIndex = 0;
            this.lblcategory.Text = "Kategori";
            // 
            // gbxproduct
            // 
            this.gbxproduct.Controls.Add(this.tbxname);
            this.gbxproduct.Controls.Add(this.lblproductname);
            this.gbxproduct.Location = new System.Drawing.Point(13, 71);
            this.gbxproduct.Name = "gbxproduct";
            this.gbxproduct.Size = new System.Drawing.Size(671, 57);
            this.gbxproduct.TabIndex = 2;
            this.gbxproduct.TabStop = false;
            this.gbxproduct.Text = "Ürün adına göre arama";
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(60, 24);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(197, 20);
            this.tbxname.TabIndex = 3;
            this.tbxname.TextChanged += new System.EventHandler(this.tbxname_TextChanged);
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Location = new System.Drawing.Point(6, 27);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(48, 13);
            this.lblproductname.TabIndex = 2;
            this.lblproductname.Text = "Ürün Adı";
            // 
            // gbxproductadd
            // 
            this.gbxproductadd.Controls.Add(this.btnremove);
            this.gbxproductadd.Controls.Add(this.btnAdd);
            this.gbxproductadd.Controls.Add(this.tbxstokadeti);
            this.gbxproductadd.Controls.Add(this.tbxbirimadeti);
            this.gbxproductadd.Controls.Add(this.tbxfiyat);
            this.gbxproductadd.Controls.Add(this.cbxkategoriadı);
            this.gbxproductadd.Controls.Add(this.tbxürünadı);
            this.gbxproductadd.Controls.Add(this.lblQuantityperunit);
            this.gbxproductadd.Controls.Add(this.lblstok);
            this.gbxproductadd.Controls.Add(this.lblUnitprice);
            this.gbxproductadd.Controls.Add(this.lblcategoryıd);
            this.gbxproductadd.Controls.Add(this.lblproductname2);
            this.gbxproductadd.Location = new System.Drawing.Point(13, 275);
            this.gbxproductadd.Name = "gbxproductadd";
            this.gbxproductadd.Size = new System.Drawing.Size(672, 123);
            this.gbxproductadd.TabIndex = 3;
            this.gbxproductadd.TabStop = false;
            this.gbxproductadd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(348, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxstokadeti
            // 
            this.tbxstokadeti.Location = new System.Drawing.Point(348, 28);
            this.tbxstokadeti.Name = "tbxstokadeti";
            this.tbxstokadeti.Size = new System.Drawing.Size(116, 20);
            this.tbxstokadeti.TabIndex = 12;
            // 
            // tbxbirimadeti
            // 
            this.tbxbirimadeti.Location = new System.Drawing.Point(348, 59);
            this.tbxbirimadeti.Name = "tbxbirimadeti";
            this.tbxbirimadeti.Size = new System.Drawing.Size(116, 20);
            this.tbxbirimadeti.TabIndex = 11;
            // 
            // tbxfiyat
            // 
            this.tbxfiyat.Location = new System.Drawing.Point(58, 91);
            this.tbxfiyat.Name = "tbxfiyat";
            this.tbxfiyat.Size = new System.Drawing.Size(121, 20);
            this.tbxfiyat.TabIndex = 10;
            // 
            // cbxkategoriadı
            // 
            this.cbxkategoriadı.FormattingEnabled = true;
            this.cbxkategoriadı.Location = new System.Drawing.Point(58, 62);
            this.cbxkategoriadı.Name = "cbxkategoriadı";
            this.cbxkategoriadı.Size = new System.Drawing.Size(121, 21);
            this.cbxkategoriadı.TabIndex = 9;
            // 
            // tbxürünadı
            // 
            this.tbxürünadı.Location = new System.Drawing.Point(57, 31);
            this.tbxürünadı.Name = "tbxürünadı";
            this.tbxürünadı.Size = new System.Drawing.Size(122, 20);
            this.tbxürünadı.TabIndex = 8;
            // 
            // lblQuantityperunit
            // 
            this.lblQuantityperunit.AutoSize = true;
            this.lblQuantityperunit.Location = new System.Drawing.Point(283, 62);
            this.lblQuantityperunit.Name = "lblQuantityperunit";
            this.lblQuantityperunit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityperunit.TabIndex = 7;
            this.lblQuantityperunit.Text = "Birim Adedi";
            // 
            // lblstok
            // 
            this.lblstok.AutoSize = true;
            this.lblstok.Location = new System.Drawing.Point(283, 31);
            this.lblstok.Name = "lblstok";
            this.lblstok.Size = new System.Drawing.Size(59, 13);
            this.lblstok.TabIndex = 6;
            this.lblstok.Text = "Stok Adedi";
            // 
            // lblUnitprice
            // 
            this.lblUnitprice.AutoSize = true;
            this.lblUnitprice.Location = new System.Drawing.Point(6, 94);
            this.lblUnitprice.Name = "lblUnitprice";
            this.lblUnitprice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitprice.TabIndex = 5;
            this.lblUnitprice.Text = "Fiyat";
            // 
            // lblcategoryıd
            // 
            this.lblcategoryıd.AutoSize = true;
            this.lblcategoryıd.Location = new System.Drawing.Point(6, 62);
            this.lblcategoryıd.Name = "lblcategoryıd";
            this.lblcategoryıd.Size = new System.Drawing.Size(46, 13);
            this.lblcategoryıd.TabIndex = 4;
            this.lblcategoryıd.Text = "Kategori";
            // 
            // lblproductname2
            // 
            this.lblproductname2.AutoSize = true;
            this.lblproductname2.Location = new System.Drawing.Point(6, 31);
            this.lblproductname2.Name = "lblproductname2";
            this.lblproductname2.Size = new System.Drawing.Size(48, 13);
            this.lblproductname2.TabIndex = 2;
            this.lblproductname2.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngüncelle);
            this.groupBox1.Controls.Add(this.tbxstokadeti2);
            this.groupBox1.Controls.Add(this.tbxbirimadeti2);
            this.groupBox1.Controls.Add(this.tbxfiyat2);
            this.groupBox1.Controls.Add(this.cbxkategoriadı2);
            this.groupBox1.Controls.Add(this.tbxürünadı2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Ekle";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(348, 91);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(116, 23);
            this.btngüncelle.TabIndex = 13;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // tbxstokadeti2
            // 
            this.tbxstokadeti2.Location = new System.Drawing.Point(348, 28);
            this.tbxstokadeti2.Name = "tbxstokadeti2";
            this.tbxstokadeti2.Size = new System.Drawing.Size(116, 20);
            this.tbxstokadeti2.TabIndex = 12;
            // 
            // tbxbirimadeti2
            // 
            this.tbxbirimadeti2.Location = new System.Drawing.Point(348, 59);
            this.tbxbirimadeti2.Name = "tbxbirimadeti2";
            this.tbxbirimadeti2.Size = new System.Drawing.Size(116, 20);
            this.tbxbirimadeti2.TabIndex = 11;
            // 
            // tbxfiyat2
            // 
            this.tbxfiyat2.Location = new System.Drawing.Point(58, 91);
            this.tbxfiyat2.Name = "tbxfiyat2";
            this.tbxfiyat2.Size = new System.Drawing.Size(121, 20);
            this.tbxfiyat2.TabIndex = 10;
            // 
            // cbxkategoriadı2
            // 
            this.cbxkategoriadı2.FormattingEnabled = true;
            this.cbxkategoriadı2.Location = new System.Drawing.Point(58, 62);
            this.cbxkategoriadı2.Name = "cbxkategoriadı2";
            this.cbxkategoriadı2.Size = new System.Drawing.Size(121, 21);
            this.cbxkategoriadı2.TabIndex = 9;
            // 
            // tbxürünadı2
            // 
            this.tbxürünadı2.Location = new System.Drawing.Point(58, 31);
            this.tbxürünadı2.Name = "tbxürünadı2";
            this.tbxürünadı2.Size = new System.Drawing.Size(121, 20);
            this.tbxürünadı2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ürün Adı";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(547, 10);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(118, 34);
            this.btnremove.TabIndex = 14;
            this.btnremove.Text = "Sil";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxproductadd);
            this.Controls.Add(this.gbxproduct);
            this.Controls.Add(this.gbxcategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxcategory.ResumeLayout(false);
            this.gbxcategory.PerformLayout();
            this.gbxproduct.ResumeLayout(false);
            this.gbxproduct.PerformLayout();
            this.gbxproductadd.ResumeLayout(false);
            this.gbxproductadd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxcategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.GroupBox gbxproduct;
        private System.Windows.Forms.ComboBox cbxcategory;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.GroupBox gbxproductadd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxstokadeti;
        private System.Windows.Forms.TextBox tbxbirimadeti;
        private System.Windows.Forms.TextBox tbxfiyat;
        private System.Windows.Forms.ComboBox cbxkategoriadı;
        private System.Windows.Forms.TextBox tbxürünadı;
        private System.Windows.Forms.Label lblQuantityperunit;
        private System.Windows.Forms.Label lblstok;
        private System.Windows.Forms.Label lblUnitprice;
        private System.Windows.Forms.Label lblcategoryıd;
        private System.Windows.Forms.Label lblproductname2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.TextBox tbxstokadeti2;
        private System.Windows.Forms.TextBox tbxbirimadeti2;
        private System.Windows.Forms.TextBox tbxfiyat2;
        private System.Windows.Forms.ComboBox cbxkategoriadı2;
        private System.Windows.Forms.TextBox tbxürünadı2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnremove;
    }
}

