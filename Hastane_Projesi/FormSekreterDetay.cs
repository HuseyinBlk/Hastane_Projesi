using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }
        public String TCno;
        SqlBaglanti bgl = new SqlBaglanti();
        
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand olusturCommand = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat, RandevuBrans,RandevuDoktor,RandevuDurum) values (@s1,@s2,@s3,@s4,@s5)",bgl.connection());
            olusturCommand.Parameters.AddWithValue("@s1", maskedTextBox1.Text);
            olusturCommand.Parameters.AddWithValue("@s2", maskedTextBox2.Text);
            olusturCommand.Parameters.AddWithValue("@s3", comboBox1.Text);
            olusturCommand.Parameters.AddWithValue("@s4", comboBox2.Text);
            olusturCommand.Parameters.AddWithValue("@s5", 0);

            olusturCommand.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            //Branşları  combobox a çekme
            SqlCommand bransComboBox = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.connection());
            SqlDataReader reader1 = bransComboBox.ExecuteReader();
            while (reader1.Read())
            {
                comboBox1.Items.Add(reader1[0].ToString());
            }
            bgl.connection().Close();


            //Tc Listeleme
            tcLabel.Text = TCno;

            //Ad Soyad Listeleme
            SqlCommand isimCommand = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTc = @p1",bgl.connection());
            isimCommand.Parameters.AddWithValue("@p1",tcLabel.Text);
            SqlDataReader reader = isimCommand.ExecuteReader();
            while (reader.Read())
            {
                isimLabel.Text = reader[0].ToString();
            }
            bgl.connection().Close();

            //Branşları DataGride Ekleme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd From Tbl_Branslar", bgl.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.connection().Close();

            //doktorları DataGride Ekleme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.connection());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.connection().Close();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            //Doktorları comboboxa cekme
            SqlCommand doktorComboBox = new SqlCommand("Select (DoktorAd+' '+DoktorSoyad) from Tbl_Doktorlar where DoktorBrans = @p2", bgl.connection());
            doktorComboBox.Parameters.Add("@p2", comboBox1.Text);
            SqlDataReader doktorDataReader = doktorComboBox.ExecuteReader();
            while (doktorDataReader.Read())
            {
                comboBox2.Items.Add(doktorDataReader[0].ToString());
            }
            bgl.connection().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand duyuruOlustur = new SqlCommand("insert into Tbl_Duyurular (Duyuruicerik) values (@p3)", bgl.connection());
            duyuruOlustur.Parameters.AddWithValue("@p3",richTextBox1.Text);
            duyuruOlustur.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Duyuru Başarı ile oluşturuldu!");
            richTextBox1.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDoktorPaneli doktorPaneli = new FormDoktorPaneli();
            doktorPaneli.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBransPaneli bransPaneli = new FormBransPaneli();
            bransPaneli.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormRandevuListesi randevuListesi = new FormRandevuListesi();
            randevuListesi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDuyurular duyurular = new FormDuyurular();
            duyurular.Show();
        }
    }
}
