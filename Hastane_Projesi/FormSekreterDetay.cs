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
            SqlCommand olusturCommand = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat, RandevuBrans,RandevuDoktor) values (@s1,@s2,@s3,@s4)");
            olusturCommand.Parameters.AddWithValue("@s1", maskedTextBox1.Text);
            olusturCommand.Parameters.AddWithValue("@s2", maskedTextBox2.Text);
            olusturCommand.Parameters.AddWithValue("@s3", comboBox1.Text);
            olusturCommand.Parameters.AddWithValue("@s4", comboBox2.Text);

        }

        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
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


    }
}
