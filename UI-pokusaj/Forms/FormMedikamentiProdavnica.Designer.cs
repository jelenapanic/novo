﻿
namespace UI_pokusaj.Forms
{
    partial class FormMedikamentiProdavnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedikamentiProdavnica));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProizvodi = new System.Windows.Forms.ComboBox();
            this.bindingSourceShop1 = new System.Windows.Forms.BindingSource(this.components);
            this.vetSet11 = new UI_pokusaj.VetSet1();
            this.textBoxTrenutnaKolicina = new System.Windows.Forms.TextBox();
            this.btnSmanjiKolicinu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPovecajKolicinu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCENA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPoruci = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxADRESA = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMejl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.btnOtkaziKupovinu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOnline = new System.Windows.Forms.RadioButton();
            this.radioButtonPouzecem = new System.Windows.Forms.RadioButton();
            this.comboBoxCena = new System.Windows.Forms.ComboBox();
            this.bindingSourceCena1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopTableAdapter1 = new UI_pokusaj.VetSet1TableAdapters.ShopTableAdapter();
            this.bindingSourcePorudzbina = new System.Windows.Forms.BindingSource(this.components);
            this.porudzbineTableAdapter = new UI_pokusaj.VetSet1TableAdapters.PorudzbineTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceShop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCena1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePorudzbina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvodi";
            // 
            // comboBoxProizvodi
            // 
            this.comboBoxProizvodi.DataSource = this.bindingSourceShop1;
            this.comboBoxProizvodi.DisplayMember = "Proizvod";
            this.comboBoxProizvodi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProizvodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProizvodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProizvodi.FormattingEnabled = true;
            this.comboBoxProizvodi.Location = new System.Drawing.Point(181, 13);
            this.comboBoxProizvodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProizvodi.Name = "comboBoxProizvodi";
            this.comboBoxProizvodi.Size = new System.Drawing.Size(395, 28);
            this.comboBoxProizvodi.TabIndex = 1;
            this.comboBoxProizvodi.ValueMember = "ShopID";
            this.comboBoxProizvodi.SelectedIndexChanged += new System.EventHandler(this.comboBoxProizvodi_SelectedIndexChanged);
            // 
            // bindingSourceShop1
            // 
            this.bindingSourceShop1.DataMember = "Shop";
            this.bindingSourceShop1.DataSource = this.vetSet11;
            // 
            // vetSet11
            // 
            this.vetSet11.DataSetName = "VetSet1";
            this.vetSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxTrenutnaKolicina
            // 
            this.textBoxTrenutnaKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrenutnaKolicina.Location = new System.Drawing.Point(460, 57);
            this.textBoxTrenutnaKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTrenutnaKolicina.Name = "textBoxTrenutnaKolicina";
            this.textBoxTrenutnaKolicina.Size = new System.Drawing.Size(59, 27);
            this.textBoxTrenutnaKolicina.TabIndex = 2;
            this.textBoxTrenutnaKolicina.Text = "0";
            // 
            // btnSmanjiKolicinu
            // 
            this.btnSmanjiKolicinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmanjiKolicinu.Location = new System.Drawing.Point(404, 57);
            this.btnSmanjiKolicinu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSmanjiKolicinu.Name = "btnSmanjiKolicinu";
            this.btnSmanjiKolicinu.Size = new System.Drawing.Size(51, 25);
            this.btnSmanjiKolicinu.TabIndex = 3;
            this.btnSmanjiKolicinu.Text = "-";
            this.btnSmanjiKolicinu.UseVisualStyleBackColor = true;
            this.btnSmanjiKolicinu.Click += new System.EventHandler(this.btnSmanjiKolicinu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kolicina";
            // 
            // btnPovecajKolicinu
            // 
            this.btnPovecajKolicinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovecajKolicinu.Location = new System.Drawing.Point(525, 55);
            this.btnPovecajKolicinu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPovecajKolicinu.Name = "btnPovecajKolicinu";
            this.btnPovecajKolicinu.Size = new System.Drawing.Size(51, 26);
            this.btnPovecajKolicinu.TabIndex = 5;
            this.btnPovecajKolicinu.Text = "+";
            this.btnPovecajKolicinu.UseVisualStyleBackColor = true;
            this.btnPovecajKolicinu.Click += new System.EventHandler(this.buttonPovecajKolicinu);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena";
            // 
            // textBoxCENA
            // 
            this.textBoxCENA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCENA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCENA.Location = new System.Drawing.Point(363, 95);
            this.textBoxCENA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCENA.Name = "textBoxCENA";
            this.textBoxCENA.Size = new System.Drawing.Size(171, 21);
            this.textBoxCENA.TabIndex = 7;
            this.textBoxCENA.TextChanged += new System.EventHandler(this.textBoxCENA_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(541, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "din.";
            // 
            // btnPoruci
            // 
            this.btnPoruci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoruci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoruci.Location = new System.Drawing.Point(409, 390);
            this.btnPoruci.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoruci.Name = "btnPoruci";
            this.btnPoruci.Size = new System.Drawing.Size(167, 52);
            this.btnPoruci.TabIndex = 9;
            this.btnPoruci.Text = "Poruči";
            this.btnPoruci.UseVisualStyleBackColor = true;
            this.btnPoruci.Click += new System.EventHandler(this.buttonPoruci_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adresa";
            // 
            // richTextBoxADRESA
            // 
            this.richTextBoxADRESA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxADRESA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxADRESA.Location = new System.Drawing.Point(180, 145);
            this.richTextBoxADRESA.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxADRESA.Name = "richTextBoxADRESA";
            this.richTextBoxADRESA.Size = new System.Drawing.Size(395, 69);
            this.richTextBoxADRESA.TabIndex = 12;
            this.richTextBoxADRESA.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mail";
            // 
            // textBoxMejl
            // 
            this.textBoxMejl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMejl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMejl.Location = new System.Drawing.Point(181, 327);
            this.textBoxMejl.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMejl.Name = "textBoxMejl";
            this.textBoxMejl.Size = new System.Drawing.Size(395, 21);
            this.textBoxMejl.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 349);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Grad";
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrad.Location = new System.Drawing.Point(181, 352);
            this.textBoxGrad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(395, 21);
            this.textBoxGrad.TabIndex = 24;
            // 
            // btnOtkaziKupovinu
            // 
            this.btnOtkaziKupovinu.BackColor = System.Drawing.Color.Aquamarine;
            this.btnOtkaziKupovinu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkaziKupovinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkaziKupovinu.Location = new System.Drawing.Point(235, 390);
            this.btnOtkaziKupovinu.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtkaziKupovinu.Name = "btnOtkaziKupovinu";
            this.btnOtkaziKupovinu.Size = new System.Drawing.Size(166, 52);
            this.btnOtkaziKupovinu.TabIndex = 25;
            this.btnOtkaziKupovinu.Text = "Otkaži";
            this.btnOtkaziKupovinu.UseVisualStyleBackColor = false;
            this.btnOtkaziKupovinu.Click += new System.EventHandler(this.btnOtkaziKupovinu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOnline);
            this.groupBox1.Controls.Add(this.radioButtonPouzecem);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 220);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(556, 99);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Način plaćanja";
            // 
            // radioButtonOnline
            // 
            this.radioButtonOnline.AutoSize = true;
            this.radioButtonOnline.Location = new System.Drawing.Point(160, 53);
            this.radioButtonOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonOnline.Name = "radioButtonOnline";
            this.radioButtonOnline.Size = new System.Drawing.Size(87, 28);
            this.radioButtonOnline.TabIndex = 17;
            this.radioButtonOnline.TabStop = true;
            this.radioButtonOnline.Text = "Online";
            this.radioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // radioButtonPouzecem
            // 
            this.radioButtonPouzecem.AutoSize = true;
            this.radioButtonPouzecem.Location = new System.Drawing.Point(160, 23);
            this.radioButtonPouzecem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPouzecem.Name = "radioButtonPouzecem";
            this.radioButtonPouzecem.Size = new System.Drawing.Size(122, 28);
            this.radioButtonPouzecem.TabIndex = 16;
            this.radioButtonPouzecem.TabStop = true;
            this.radioButtonPouzecem.Text = "Pouzecem";
            this.radioButtonPouzecem.UseVisualStyleBackColor = true;
            // 
            // comboBoxCena
            // 
            this.comboBoxCena.DataSource = this.bindingSourceCena1;
            this.comboBoxCena.DisplayMember = "Cena";
            this.comboBoxCena.FormattingEnabled = true;
            this.comboBoxCena.Location = new System.Drawing.Point(661, 97);
            this.comboBoxCena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCena.Name = "comboBoxCena";
            this.comboBoxCena.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCena.TabIndex = 27;
            this.comboBoxCena.ValueMember = "ShopID";
            this.comboBoxCena.SelectedIndexChanged += new System.EventHandler(this.comboBoxCena_SelectedIndexChanged);
            // 
            // bindingSourceCena1
            // 
            this.bindingSourceCena1.DataMember = "Shop";
            this.bindingSourceCena1.DataSource = this.vetSet11;
            // 
            // shopTableAdapter1
            // 
            this.shopTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSourcePorudzbina
            // 
            this.bindingSourcePorudzbina.DataMember = "Porudzbine";
            this.bindingSourcePorudzbina.DataSource = this.vetSet11;
            // 
            // porudzbineTableAdapter
            // 
            this.porudzbineTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(582, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // FormMedikamentiProdavnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(926, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxCena);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOtkaziKupovinu);
            this.Controls.Add(this.textBoxGrad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxMejl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBoxADRESA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPoruci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCENA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPovecajKolicinu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSmanjiKolicinu);
            this.Controls.Add(this.textBoxTrenutnaKolicina);
            this.Controls.Add(this.comboBoxProizvodi);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMedikamentiProdavnica";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormMedikamentiProdavnica_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceShop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCena1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePorudzbina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProizvodi;
        private System.Windows.Forms.TextBox textBoxTrenutnaKolicina;
        private System.Windows.Forms.Button btnSmanjiKolicinu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPovecajKolicinu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCENA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPoruci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxADRESA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMejl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxGrad;
        private System.Windows.Forms.Button btnOtkaziKupovinu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCena;
        private System.Windows.Forms.RadioButton radioButtonOnline;
        private System.Windows.Forms.RadioButton radioButtonPouzecem;
        private VetSet1 vetSet11;
        private System.Windows.Forms.BindingSource bindingSourceShop1;
        private VetSet1TableAdapters.ShopTableAdapter shopTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSourceCena1;
        private System.Windows.Forms.BindingSource bindingSourcePorudzbina;
        private VetSet1TableAdapters.PorudzbineTableAdapter porudzbineTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}