using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Projesi
{
    public partial class FormDoktorPaneli : Form
    {
        public FormDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
   

        private void FormDoktorPaneli_Load(object sender, EventArgs e)
        {
            //combobox bransları ekleme
            SqlCommand branslistele = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.connection());
            SqlDataReader reader1 = branslistele.ExecuteReader();
            while (reader1.Read())
            {
                bransComboBox.Items.Add(reader1[0].ToString());
            }
            bgl.connection().Close();

            //Tabloda doktor listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktorlar ",bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connection().Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekleCommand = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.connection());
            ekleCommand.Parameters.AddWithValue("@p1",adTextbox.Text);
            ekleCommand.Parameters.AddWithValue("@p2",soyadTextBox.Text);
            ekleCommand.Parameters.AddWithValue("@p3",bransComboBox.Text);
            ekleCommand.Parameters.AddWithValue("@p4",tcMaskedTextBox.Text);
            ekleCommand.Parameters.AddWithValue("@p5",sifreTextBox.Text);
            ekleCommand.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doktor başarı ile eklendi.");
            adTextbox.Clear();
            soyadTextBox.Clear();
            bransComboBox.Text = "";
            tcMaskedTextBox.Clear();
            sifreTextBox.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;  
            adTextbox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadTextBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            bransComboBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tcMaskedTextBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            sifreTextBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand silCommand = new SqlCommand("delete from Tbl_Doktorlar where DoktorTc = '"+tcMaskedTextBox.Text+"'",bgl.connection());
            silCommand.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doktor kaydı başarı ile silindi.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand guncelleCommand = new SqlCommand("update Tbl_Doktorlar set DoktorAd = @d1,DoktorSoyad = @d2,DoktorBrans = @d3,DoktorSifre = @d4 where DoktorTc = @d5"  , bgl.connection());
            guncelleCommand.Parameters.AddWithValue("@d1",adTextbox.Text);
            guncelleCommand.Parameters.AddWithValue("@d2",soyadTextBox.Text);
            guncelleCommand.Parameters.AddWithValue("@d3", bransComboBox.Text);
            guncelleCommand.Parameters.AddWithValue("@d4", sifreTextBox.Text);
            guncelleCommand.Parameters.AddWithValue("@d5", tcMaskedTextBox.Text);

            guncelleCommand.ExecuteNonQuery();

            bgl.connection().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi.");



        }
    }
}
