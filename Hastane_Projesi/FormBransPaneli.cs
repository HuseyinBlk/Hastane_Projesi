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
    public partial class FormBransPaneli : Form
    {
        public FormBransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void FormBransPaneli_Load(object sender, EventArgs e)
        {
            //Bransları Listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.connection());
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connection().Close();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            SqlCommand bransEkleKomut = new SqlCommand("Insert into Tbl_Branslar (BransAd) values (@p1)",bgl.connection());
            bransEkleKomut.Parameters.AddWithValue("@p1",adTextbox.Text);
            bransEkleKomut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt başarıyla oluşturuldu");
            adTextbox.Text = "";
            
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            SqlCommand bransSilKomut = new SqlCommand("Delete from Tbl_Branslar Where Bransid = '"+idTextbox.Text+"'", bgl.connection());
            bransSilKomut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Branş başarıyla silindi.");
            idTextbox.Text = "";
            adTextbox.Text = "";


        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand bransGuncelleKomut = new SqlCommand("Update Tbl_Branslar set BransAd= @p2 where Bransid = @p3", bgl.connection());
            bransGuncelleKomut.Parameters.AddWithValue("@p2",adTextbox.Text);
            bransGuncelleKomut.Parameters.AddWithValue("@p3",idTextbox.Text);
            bransGuncelleKomut.ExecuteNonQuery();
            MessageBox.Show("Brans başarıyla güncellendi");
            idTextbox.Text = "";
            adTextbox.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            idTextbox.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adTextbox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }
    }
}
