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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Projesi
{
    public partial class FormDoktorBilgiDuzenle : Form
    {
        public FormDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string TcNo;
        private void FormDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            tcMaskedTextBox.Text = TcNo;
            //Branş Combobox ekleme
            
            SqlCommand bransCommand = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.connection());
            SqlDataReader dr2 = bransCommand.ExecuteReader();
            while (dr2.Read())
            {
                bransComboBox.Items.Add(dr2[0].ToString());
            }
            bgl.connection().Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand degistirCommand = new SqlCommand("update Tbl_Doktorlar set DoktorAd = @s1,DoktorSoyad = @s2, DoktorBrans = @s3, DoktorSifre = @s4 where DoktorTC = @s6", bgl.connection());
            degistirCommand.Parameters.AddWithValue("@s1",adTextBox.Text);
            degistirCommand.Parameters.AddWithValue("@s2",soyadTextBox.Text);
            degistirCommand.Parameters.AddWithValue("@s3",bransComboBox.Text);
            degistirCommand.Parameters.AddWithValue("@s4",passwordTextBox.Text);
            degistirCommand.Parameters.AddWithValue("@s6",tcMaskedTextBox.Text);


            degistirCommand.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi.");
            this.Hide();
        }

        
    }
}
