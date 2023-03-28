namespace NküOtomasyon
{
    partial class added
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.yayinEvi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baski = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nerede = new System.Windows.Forms.ComboBox();
            this.kYazar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gorntu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 355);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView2.Size = new System.Drawing.Size(776, 385);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(63, 284);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(133, 23);
            this.search.TabIndex = 19;
            this.search.Text = "EKLE";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // yayinEvi
            // 
            this.yayinEvi.Location = new System.Drawing.Point(501, 105);
            this.yayinEvi.Name = "yayinEvi";
            this.yayinEvi.Size = new System.Drawing.Size(206, 22);
            this.yayinEvi.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yayın Evi:";
            // 
            // idNo
            // 
            this.idNo.Enabled = false;
            this.idNo.Location = new System.Drawing.Point(151, 50);
            this.idNo.Name = "idNo";
            this.idNo.Size = new System.Drawing.Size(206, 22);
            this.idNo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID:";
            // 
            // tur
            // 
            this.tur.Location = new System.Drawing.Point(151, 168);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(206, 22);
            this.tur.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kitap Türü:";
            // 
            // kitapAdi
            // 
            this.kitapAdi.Location = new System.Drawing.Point(151, 108);
            this.kitapAdi.Name = "kitapAdi";
            this.kitapAdi.Size = new System.Drawing.Size(206, 22);
            this.kitapAdi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kitap Adı:";
            // 
            // baski
            // 
            this.baski.Location = new System.Drawing.Point(151, 225);
            this.baski.Name = "baski";
            this.baski.Size = new System.Drawing.Size(206, 22);
            this.baski.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Baskı Yılı:";
            // 
            // sayfa
            // 
            this.sayfa.Location = new System.Drawing.Point(501, 168);
            this.sayfa.Name = "sayfa";
            this.sayfa.Size = new System.Drawing.Size(206, 22);
            this.sayfa.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nerede:";
            // 
            // nerede
            // 
            this.nerede.FormattingEnabled = true;
            this.nerede.Items.AddRange(new object[] {
            "",
            "Raf",
            "Okuyucu"});
            this.nerede.Location = new System.Drawing.Point(505, 225);
            this.nerede.Name = "nerede";
            this.nerede.Size = new System.Drawing.Size(153, 24);
            this.nerede.TabIndex = 29;
            this.nerede.SelectedIndexChanged += new System.EventHandler(this.nerede_SelectedIndexChanged);
            // 
            // kYazar
            // 
            this.kYazar.Location = new System.Drawing.Point(501, 50);
            this.kYazar.Name = "kYazar";
            this.kYazar.Size = new System.Drawing.Size(206, 22);
            this.kYazar.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Kitap Yazarı:";
            // 
            // gorntu
            // 
            this.gorntu.Location = new System.Drawing.Point(598, 284);
            this.gorntu.Name = "gorntu";
            this.gorntu.Size = new System.Drawing.Size(133, 23);
            this.gorntu.TabIndex = 32;
            this.gorntu.Text = "GÖRÜNTÜLE";
            this.gorntu.UseVisualStyleBackColor = true;
            this.gorntu.Click += new System.EventHandler(this.gorntu_Click);
            // 
            // added
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gorntu);
            this.Controls.Add(this.kYazar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nerede);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sayfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.baski);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.yayinEvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitapAdi);
            this.Controls.Add(this.label1);
            this.Name = "added";
            this.Size = new System.Drawing.Size(853, 762);
            this.Load += new System.EventHandler(this.added_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox yayinEvi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baski;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sayfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox nerede;
        private System.Windows.Forms.TextBox kYazar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button gorntu;
    }
}
