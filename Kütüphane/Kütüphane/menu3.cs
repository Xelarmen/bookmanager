using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane
{
    public partial class menu3 : UserControl
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabanı.mdb");
        OleDbDataAdapter da;
        DataTable dt;
        string sql = "SELECT * FROM Tablo1";
        void Listele(string aranan)
        {
            da = new OleDbDataAdapter(sql, con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        
        public menu3()
        {
            InitializeComponent();
        }

        private void Menu3_Load(object sender, EventArgs e)
        {
            Listele(sql);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tablo1TableAdapter.FillBy(this.veritabanıDataSet.Tablo1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Listele(sql);//Listeyi güncelle
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabanı.mdb");//bağlantı tanımlandı
            con.Open();//baplantı açıldı
            string sql = "INSERT into  Tablo1(kitapadi, yazar, sayfasayisi, isbn) VALUES(@kitapadi,@yazar,@sayfasayisi,@isbn)";//sql sorgusu hazırlandı
            OleDbCommand komut = new OleDbCommand(sql, con); //sql komutu tanımlandı
            komut.Parameters.AddWithValue("@kitapadi", textBox1.Text);//değer olarak atıyoruz ki sql komutlarında kullanabilelim 
            komut.Parameters.AddWithValue("@yazar", textBox2.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", textBox3.Text);
            komut.Parameters.AddWithValue("@isbn", textBox4.Text);
            komut.ExecuteNonQuery();//eylemi tamamlayıp sonlandırıyor
            con.Close();//Bağlantı kesildi
            Listele(sql);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabanı.mdb");//bağlantı tanımlandı
            con.Open();//baplantı açıldı
            string sql = "DELETE FROM Tablo1 WHERE sira  =  @sira";//sql sorgusu hazırlandı
            OleDbCommand komut = new OleDbCommand(sql, con); //sql komutu tanımlandı
            komut.Parameters.AddWithValue("@sira", textBox5.Text);//değer olarak atıyoruz ki sql komutlarında kullanabilelim 
            komut.ExecuteNonQuery();//eylemi tamamlayıp sonlandırıyor
            con.Close();//Bağlantı kesildi
            Listele(sql);
        }
        int rowIndex;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if(rowIndex<0)//üstteki tablo seçeneklerine tıklayınca -1 indexi yüzünden oluşan bug'u fixledim
            {
                rowIndex = 0;
            }
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            textBox1.Text =  selectedRow.Cells[0].Value.ToString();//tabloda seçilen satırı textboxlara koydum
            textBox2.Text =  selectedRow.Cells[1].Value.ToString();
            textBox3.Text =  selectedRow.Cells[2].Value.ToString();
            textBox4.Text =  selectedRow.Cells[3].Value.ToString();
            textBox5.Text =  selectedRow.Cells[4].Value.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabanı.mdb");//bağlantı tanımlandı
            con.Open();//baplantı açıldı
            string sql = "Update Tablo1 set kitapadi = @kitapadi, yazar = @yazar, sayfasayisi  = @sayfasayisi , isbn = @isbn WHERE sira = @sira;";//sql sorgusu hazırlandı
            OleDbCommand komut = new OleDbCommand(sql, con); //sql komutu tanımlandı
            komut.Parameters.AddWithValue("@kitapadi", textBox1.Text);//değer olarak atıyoruz ki sql komutlarında kullanabilelim 
            komut.Parameters.AddWithValue("@yazar", textBox2.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", textBox3.Text);
            komut.Parameters.AddWithValue("@isbn", textBox4.Text);
            komut.Parameters.AddWithValue("@sira", textBox5.Text);
            komut.ExecuteNonQuery();//eylemi tamamlayıp sonlandırıyor
            con.Close();//Bağlantı kesildi
            Listele(sql);
            Listele(sql);
        }
    }
}
