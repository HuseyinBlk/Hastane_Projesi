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
    public partial class FormDoktorGiris : Form
    {
        public FormDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand girisKomut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc = @p1 and DoktorSifre = @p2",bgl.connection());
            girisKomut.Parameters.AddWithValue("@p1",tcMaskedTextBox.Text);
            girisKomut.Parameters.AddWithValue("@p2", sifreTextBox.Text);
           

            SqlDataReader rd = girisKomut.ExecuteReader();
            if (rd.Read())
            {
                FormDoktorDetay doktorDetay = new FormDoktorDetay();
                doktorDetay.TcNo = tcMaskedTextBox.Text;
                doktorDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı ad veya şifre!");
                tcMaskedTextBox.Text = "";
                sifreTextBox.Text = "";
            }
                bgl.connection().Close();
            
        }
    }
}
