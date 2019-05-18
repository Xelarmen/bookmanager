namespace Kütüphane
{
    partial class menu3
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablo1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanıDataSet11 = new Kütüphane.veritabanıDataSet1();
            this.tablo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanıDataSet = new Kütüphane.veritabanıDataSet();
            this.tablo1TableAdapter = new Kütüphane.veritabanıDataSetTableAdapters.Tablo1TableAdapter();
            this.veritabanıDataSet1 = new Kütüphane.veritabanıDataSet();
            this.veritabanıDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tablo1TableAdapter1 = new Kütüphane.veritabanıDataSet1TableAdapters.Tablo1TableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanıDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanıDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label3.Location = new System.Drawing.Point(64, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "SAYFA SAYISI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "YAZAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "KİTAP ADI";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox4.Location = new System.Drawing.Point(246, 170);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 25);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox3.Location = new System.Drawing.Point(246, 124);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 25);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox2.Location = new System.Drawing.Point(246, 78);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 25);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox1.Location = new System.Drawing.Point(246, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 25);
            this.textBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapadiDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.sayfasayisiDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.siraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablo1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(68, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(712, 213);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // kitapadiDataGridViewTextBoxColumn
            // 
            this.kitapadiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kitapadiDataGridViewTextBoxColumn.DataPropertyName = "kitapadi";
            this.kitapadiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.kitapadiDataGridViewTextBoxColumn.Name = "kitapadiDataGridViewTextBoxColumn";
            this.kitapadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sayfasayisiDataGridViewTextBoxColumn
            // 
            this.sayfasayisiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sayfasayisiDataGridViewTextBoxColumn.DataPropertyName = "sayfasayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            this.sayfasayisiDataGridViewTextBoxColumn.Name = "sayfasayisiDataGridViewTextBoxColumn";
            this.sayfasayisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "İSBN";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siraDataGridViewTextBoxColumn
            // 
            this.siraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siraDataGridViewTextBoxColumn.DataPropertyName = "sira";
            this.siraDataGridViewTextBoxColumn.HeaderText = "Kayıt No";
            this.siraDataGridViewTextBoxColumn.Name = "siraDataGridViewTextBoxColumn";
            this.siraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablo1BindingSource1
            // 
            this.tablo1BindingSource1.DataMember = "Tablo1";
            this.tablo1BindingSource1.DataSource = this.veritabanıDataSet11;
            // 
            // veritabanıDataSet11
            // 
            this.veritabanıDataSet11.DataSetName = "veritabanıDataSet1";
            this.veritabanıDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablo1BindingSource
            // 
            this.tablo1BindingSource.DataMember = "Tablo1";
            this.tablo1BindingSource.DataSource = this.veritabanıDataSet;
            // 
            // veritabanıDataSet
            // 
            this.veritabanıDataSet.DataSetName = "veritabanıDataSet";
            this.veritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablo1TableAdapter
            // 
            this.tablo1TableAdapter.ClearBeforeFill = true;
            // 
            // veritabanıDataSet1
            // 
            this.veritabanıDataSet1.DataSetName = "veritabanıDataSet";
            this.veritabanıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veritabanıDataSetBindingSource
            // 
            this.veritabanıDataSetBindingSource.DataSource = this.veritabanıDataSet;
            this.veritabanıDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(547, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(547, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(547, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 39);
            this.button3.TabIndex = 20;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(547, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 39);
            this.button4.TabIndex = 21;
            this.button4.Text = "Kaydı Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tablo1TableAdapter1
            // 
            this.tablo1TableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label4.Location = new System.Drawing.Point(64, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label5.Location = new System.Drawing.Point(64, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "SIRA";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Silver;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox5.Location = new System.Drawing.Point(246, 216);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(248, 25);
            this.textBox5.TabIndex = 23;
            // 
            // menu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "menu3";
            this.Size = new System.Drawing.Size(846, 500);
            this.Load += new System.EventHandler(this.Menu3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanıDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanıDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tablo1BindingSource;
        private veritabanıDataSet veritabanıDataSet;
        private veritabanıDataSetTableAdapters.Tablo1TableAdapter tablo1TableAdapter;
        private veritabanıDataSet veritabanıDataSet1;
        private System.Windows.Forms.BindingSource veritabanıDataSetBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource tablo1BindingSource1;
        private veritabanıDataSet1 veritabanıDataSet11;
        private veritabanıDataSet1TableAdapters.Tablo1TableAdapter tablo1TableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siraDataGridViewTextBoxColumn;
    }
}
