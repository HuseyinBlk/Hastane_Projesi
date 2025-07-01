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
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }
        public string Tc;
        SqlBaglanti bgl = new SqlBaglanti();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormHastaDetay_Load(object sender, EventArgs e)
        {
            tcLabel.Text = Tc;
            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC = @p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1", tcLabel.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                isimLabel.Text = dr[0].ToString();
                soyisimLabel.Text = dr[1].ToString();
            }

            bgl.connection().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTC = "+Tc,bgl.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.connection().Close();


            //Randevu Listesi
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDurum =1 and HastaTC=" + Tc, bgl.connection());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            bgl.connection().Close();

            //Branş Çekme
            SqlCommand bransCommand = new SqlCommand("Select BransAd from Tbl_Branslar",bgl.connection());
            SqlDataReader dr2 = bransCommand.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0].ToString());
            }
            bgl.connection().Close();

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            //Doktor Çekme
            SqlCommand doktorCommand = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans= @b1", bgl.connection());
            doktorCommand.Parameters.AddWithValue("@b1", comboBox1.Text);
            SqlDataReader dr3 = doktorCommand.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0]+ " " + dr3[1]);
            }
            bgl.connection().Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans = '"+ comboBox1.Text+"'", bgl.connection());
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            bgl.connection().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaBilgiDuzenle bilgiduzenle = new FormHastaBilgiDuzenle();
            bilgiduzenle.TCNo = tcLabel.Text;
            bilgiduzenle.Show();
            

        }
    }
}
