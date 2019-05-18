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
    public partial class Menu2 : UserControl
    {
        
        public Menu2()
        {
            InitializeComponent();
        }
       
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
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

        }
    }
}
