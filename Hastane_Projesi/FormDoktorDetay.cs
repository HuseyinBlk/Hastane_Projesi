using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class FormDoktorDetay : Form
    {
        public string TcNo;
        public FormDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            tcLabel.Text = TcNo;
            //isim soy isim getirme
            SqlCommand isimSoyisimKomut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc = @p1",bgl.connection());
            isimSoyisimKomut.Parameters.AddWithValue("@p1",tcLabel.Text);
            SqlDataReader rd = isimSoyisimKomut.ExecuteReader();
            while (rd.Read())
            {
                isimLabel.Text = rd[0].ToString();
                soyisimLabel.Text = rd[1].ToString();
            }
            bgl.connection().Close();

            //Randevuları  çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select RandevuTarih,RandevuSaat,HastaTC,HastaSikayet From Tbl_Randevular where RandevuDurum = 1 and RandevuDoktor = '"+isimLabel.Text+' '+soyisimLabel.Text+"'",bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connection().Close();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string hastaAd;
            string hastaSoyad;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand hastaBilgiKomut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar Where HastaTC = '"+ dataGridView1.Rows[secilen].Cells[2].Value.ToString() + "'",bgl.connection());
            SqlDataReader dr = hastaBilgiKomut.ExecuteReader();
            while (dr.Read())
            {
                hastaAd = dr[0].ToString();
                hastaSoyad = dr[1].ToString();
                richTextBox1.Text = hastaAd + " " + hastaSoyad + "\n" + dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDoktorBilgiDuzenle doktorBilgiDuzenle = new FormDoktorBilgiDuzenle();
            doktorBilgiDuzenle.TcNo = tcLabel.Text;
            doktorBilgiDuzenle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDuyurular duyurular = new FormDuyurular();
            duyurular.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDoktorGiris doktorGiris = new FormDoktorGiris();
            doktorGiris.Show();
            this.Hide();
        }
    }
}
