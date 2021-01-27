
namespace YTM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gelirEkleBtn = new System.Windows.Forms.Button();
            this.giderEkleBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGelirTutar = new System.Windows.Forms.TextBox();
            this.txtGelirTanim = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiderTutar = new System.Windows.Forms.TextBox();
            this.txtGiderTanim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridGelir = new System.Windows.Forms.DataGridView();
            this.dataGridGider = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGenelDurum = new System.Windows.Forms.Label();
            this.lblGenelGiderToplam = new System.Windows.Forms.Label();
            this.lblGenelGelirToplam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGelirGiderSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonthSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.giderSearchBtn = new System.Windows.Forms.Button();
            this.bitisPicker = new System.Windows.Forms.DateTimePicker();
            this.baslangicPicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSearchGelirToplam = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSearchGiderToplam = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSearchDurum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGelirDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGelirId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtGiderDescription = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGiderId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGelir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGider)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gelirEkleBtn
            // 
            this.gelirEkleBtn.Location = new System.Drawing.Point(4, 111);
            this.gelirEkleBtn.Name = "gelirEkleBtn";
            this.gelirEkleBtn.Size = new System.Drawing.Size(100, 40);
            this.gelirEkleBtn.TabIndex = 3;
            this.gelirEkleBtn.Text = "Gelir Ekle";
            this.gelirEkleBtn.UseVisualStyleBackColor = true;
            this.gelirEkleBtn.Click += new System.EventHandler(this.gelirEkleBtn_Click);
            // 
            // giderEkleBtn
            // 
            this.giderEkleBtn.Location = new System.Drawing.Point(162, 111);
            this.giderEkleBtn.Name = "giderEkleBtn";
            this.giderEkleBtn.Size = new System.Drawing.Size(100, 40);
            this.giderEkleBtn.TabIndex = 6;
            this.giderEkleBtn.Text = "Gider Ekle";
            this.giderEkleBtn.UseVisualStyleBackColor = true;
            this.giderEkleBtn.Click += new System.EventHandler(this.giderEkleBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGelirTutar);
            this.panel1.Controls.Add(this.txtGelirTanim);
            this.panel1.Controls.Add(this.gelirEkleBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 162);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gelir Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gelir Tanım";
            // 
            // txtGelirTutar
            // 
            this.txtGelirTutar.Location = new System.Drawing.Point(111, 128);
            this.txtGelirTutar.Name = "txtGelirTutar";
            this.txtGelirTutar.Size = new System.Drawing.Size(148, 22);
            this.txtGelirTutar.TabIndex = 2;
            this.txtGelirTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGelirTutar_KeyPress);
            // 
            // txtGelirTanim
            // 
            this.txtGelirTanim.Location = new System.Drawing.Point(111, 25);
            this.txtGelirTanim.Multiline = true;
            this.txtGelirTanim.Name = "txtGelirTanim";
            this.txtGelirTanim.Size = new System.Drawing.Size(148, 67);
            this.txtGelirTanim.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtGiderTutar);
            this.panel2.Controls.Add(this.giderEkleBtn);
            this.panel2.Controls.Add(this.txtGiderTanim);
            this.panel2.Location = new System.Drawing.Point(906, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 162);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gider Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gider Tanım";
            // 
            // txtGiderTutar
            // 
            this.txtGiderTutar.Location = new System.Drawing.Point(4, 128);
            this.txtGiderTutar.Name = "txtGiderTutar";
            this.txtGiderTutar.Size = new System.Drawing.Size(148, 22);
            this.txtGiderTutar.TabIndex = 5;
            this.txtGiderTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiderTutar_KeyPress);
            // 
            // txtGiderTanim
            // 
            this.txtGiderTanim.Location = new System.Drawing.Point(4, 24);
            this.txtGiderTanim.Multiline = true;
            this.txtGiderTanim.Name = "txtGiderTanim";
            this.txtGiderTanim.Size = new System.Drawing.Size(148, 67);
            this.txtGiderTanim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(366, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Genel Durum";
            // 
            // dataGridGelir
            // 
            this.dataGridGelir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGelir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGelir.Location = new System.Drawing.Point(12, 299);
            this.dataGridGelir.Name = "dataGridGelir";
            this.dataGridGelir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGelir.Size = new System.Drawing.Size(565, 300);
            this.dataGridGelir.TabIndex = 7;
            this.dataGridGelir.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGelir_CellDoubleClick);
            // 
            // dataGridGider
            // 
            this.dataGridGider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGider.Location = new System.Drawing.Point(618, 299);
            this.dataGridGider.Name = "dataGridGider";
            this.dataGridGider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGider.Size = new System.Drawing.Size(565, 300);
            this.dataGridGider.TabIndex = 8;
            this.dataGridGider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGider_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lblGenelDurum);
            this.panel3.Controls.Add(this.lblGenelGiderToplam);
            this.panel3.Controls.Add(this.lblGenelGelirToplam);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(284, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 57);
            this.panel3.TabIndex = 9;
            // 
            // lblGenelDurum
            // 
            this.lblGenelDurum.AutoSize = true;
            this.lblGenelDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelDurum.Location = new System.Drawing.Point(385, 33);
            this.lblGenelDurum.Name = "lblGenelDurum";
            this.lblGenelDurum.Size = new System.Drawing.Size(67, 20);
            this.lblGenelDurum.TabIndex = 11;
            this.lblGenelDurum.Text = "label10";
            // 
            // lblGenelGiderToplam
            // 
            this.lblGenelGiderToplam.AutoSize = true;
            this.lblGenelGiderToplam.Location = new System.Drawing.Point(131, 33);
            this.lblGenelGiderToplam.Name = "lblGenelGiderToplam";
            this.lblGenelGiderToplam.Size = new System.Drawing.Size(51, 16);
            this.lblGenelGiderToplam.TabIndex = 10;
            this.lblGenelGiderToplam.Text = "label9";
            // 
            // lblGenelGelirToplam
            // 
            this.lblGenelGelirToplam.AutoSize = true;
            this.lblGenelGelirToplam.Location = new System.Drawing.Point(131, 7);
            this.lblGenelGelirToplam.Name = "lblGenelGelirToplam";
            this.lblGenelGelirToplam.Size = new System.Drawing.Size(51, 16);
            this.lblGenelGelirToplam.TabIndex = 9;
            this.lblGenelGelirToplam.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Toplam Gider";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Toplam Gelir";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtGelirGiderSearch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMonthSearch);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.giderSearchBtn);
            this.groupBox1.Controls.Add(this.bitisPicker);
            this.groupBox1.Controls.Add(this.baslangicPicker);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(284, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // txtGelirGiderSearch
            // 
            this.txtGelirGiderSearch.Location = new System.Drawing.Point(432, 87);
            this.txtGelirGiderSearch.Name = "txtGelirGiderSearch";
            this.txtGelirGiderSearch.Size = new System.Drawing.Size(153, 22);
            this.txtGelirGiderSearch.TabIndex = 9;
            this.txtGelirGiderSearch.TextChanged += new System.EventHandler(this.txtGelirGiderSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "GelirGiderArama";
            // 
            // txtMonthSearch
            // 
            this.txtMonthSearch.Location = new System.Drawing.Point(432, 32);
            this.txtMonthSearch.Name = "txtMonthSearch";
            this.txtMonthSearch.Size = new System.Drawing.Size(153, 22);
            this.txtMonthSearch.TabIndex = 7;
            this.txtMonthSearch.TextChanged += new System.EventHandler(this.txtMonthSearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(458, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Aya Göre Yap";
            // 
            // giderSearchBtn
            // 
            this.giderSearchBtn.Location = new System.Drawing.Point(60, 74);
            this.giderSearchBtn.Name = "giderSearchBtn";
            this.giderSearchBtn.Size = new System.Drawing.Size(225, 35);
            this.giderSearchBtn.TabIndex = 4;
            this.giderSearchBtn.Text = "Tarihe Göre Arama";
            this.giderSearchBtn.UseVisualStyleBackColor = true;
            this.giderSearchBtn.Click += new System.EventHandler(this.giderSearchBtn_Click);
            // 
            // bitisPicker
            // 
            this.bitisPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bitisPicker.Location = new System.Drawing.Point(189, 39);
            this.bitisPicker.Name = "bitisPicker";
            this.bitisPicker.Size = new System.Drawing.Size(123, 22);
            this.bitisPicker.TabIndex = 3;
            // 
            // baslangicPicker
            // 
            this.baslangicPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baslangicPicker.Location = new System.Drawing.Point(39, 39);
            this.baslangicPicker.Name = "baslangicPicker";
            this.baslangicPicker.Size = new System.Drawing.Size(123, 22);
            this.baslangicPicker.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Bitiş Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Başlangıç Tarihi";
            // 
            // lblSearchGelirToplam
            // 
            this.lblSearchGelirToplam.AutoSize = true;
            this.lblSearchGelirToplam.Location = new System.Drawing.Point(119, 25);
            this.lblSearchGelirToplam.Name = "lblSearchGelirToplam";
            this.lblSearchGelirToplam.Size = new System.Drawing.Size(38, 16);
            this.lblSearchGelirToplam.TabIndex = 2;
            this.lblSearchGelirToplam.Text = "0 TL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Gelir Toplam:";
            // 
            // lblSearchGiderToplam
            // 
            this.lblSearchGiderToplam.AutoSize = true;
            this.lblSearchGiderToplam.Location = new System.Drawing.Point(119, 51);
            this.lblSearchGiderToplam.Name = "lblSearchGiderToplam";
            this.lblSearchGiderToplam.Size = new System.Drawing.Size(38, 16);
            this.lblSearchGiderToplam.TabIndex = 3;
            this.lblSearchGiderToplam.Text = "0 TL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Gider Toplam:";
            // 
            // lblSearchDurum
            // 
            this.lblSearchDurum.AutoSize = true;
            this.lblSearchDurum.Location = new System.Drawing.Point(425, 51);
            this.lblSearchDurum.Name = "lblSearchDurum";
            this.lblSearchDurum.Size = new System.Drawing.Size(38, 16);
            this.lblSearchDurum.TabIndex = 1;
            this.lblSearchDurum.Text = "0 TL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSearchDurum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblSearchGiderToplam);
            this.groupBox2.Controls.Add(this.lblSearchGelirToplam);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(284, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 89);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Sonucu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Aramaya Göre Genel Durum";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.txtGelirDescription);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.txtGelirId);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(12, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 113);
            this.panel5.TabIndex = 16;
            // 
            // txtGelirDescription
            // 
            this.txtGelirDescription.Location = new System.Drawing.Point(88, 34);
            this.txtGelirDescription.Multiline = true;
            this.txtGelirDescription.Name = "txtGelirDescription";
            this.txtGelirDescription.Size = new System.Drawing.Size(171, 70);
            this.txtGelirDescription.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tanım";
            // 
            // txtGelirId
            // 
            this.txtGelirId.Location = new System.Drawing.Point(88, 4);
            this.txtGelirId.Name = "txtGelirId";
            this.txtGelirId.Size = new System.Drawing.Size(171, 22);
            this.txtGelirId.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.txtGiderDescription);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.txtGiderId);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Location = new System.Drawing.Point(906, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 113);
            this.panel6.TabIndex = 17;
            // 
            // txtGiderDescription
            // 
            this.txtGiderDescription.Location = new System.Drawing.Point(4, 31);
            this.txtGiderDescription.Multiline = true;
            this.txtGiderDescription.Name = "txtGiderDescription";
            this.txtGiderDescription.Size = new System.Drawing.Size(171, 69);
            this.txtGiderDescription.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(189, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Tanım";
            // 
            // txtGiderId
            // 
            this.txtGiderId.Location = new System.Drawing.Point(4, 4);
            this.txtGiderId.Name = "txtGiderId";
            this.txtGiderId.Size = new System.Drawing.Size(171, 22);
            this.txtGiderId.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(189, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridGider);
            this.Controls.Add(this.dataGridGelir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YTM Gelir Gider Masaüstü Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGelir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button gelirEkleBtn;
        private System.Windows.Forms.Button giderEkleBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridGelir;
        private System.Windows.Forms.DataGridView dataGridGider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGelirTutar;
        private System.Windows.Forms.TextBox txtGelirTanim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiderTutar;
        private System.Windows.Forms.TextBox txtGiderTanim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGenelDurum;
        private System.Windows.Forms.Label lblGenelGiderToplam;
        private System.Windows.Forms.Label lblGenelGelirToplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMonthSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button giderSearchBtn;
        private System.Windows.Forms.DateTimePicker bitisPicker;
        private System.Windows.Forms.DateTimePicker baslangicPicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSearchDurum;
        private System.Windows.Forms.Label lblSearchGelirToplam;
        private System.Windows.Forms.Label lblSearchGiderToplam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGelirGiderSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGelirDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGelirId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtGiderDescription;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGiderId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button3;
    }
}

