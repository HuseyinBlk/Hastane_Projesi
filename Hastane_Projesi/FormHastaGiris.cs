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
    public partial class FormHastaGiris : Form
    {
        public FormHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FormHastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void üyeOlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayit formHastaKayit = new FormHastaKayit();
            formHastaKayit.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand girisCommand = new SqlCommand("Select * from Tbl_Hastalar where HastaTC = @lTC and HastaSifre = @lSifre",bgl.connection());
            girisCommand.Parameters.AddWithValue("@lTC", tcMaskedTextBox.Text);
            girisCommand.Parameters.AddWithValue("@lSifre",sifreTextBox.Text);
            
            SqlDataReader reader = girisCommand.ExecuteReader();
            if (reader.Read())
            {
                FormHastaDetay hastaDetay = new FormHastaDetay();
                hastaDetay.Tc = tcMaskedTextBox.Text;
                hastaDetay.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre!!");
            }

            bgl.connection().Close();

        }

        
    }
}
