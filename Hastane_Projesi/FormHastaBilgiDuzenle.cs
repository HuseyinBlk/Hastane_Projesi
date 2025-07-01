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
    public partial class FormHastaBilgiDuzenle : Form
    {
        public FormHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCNo;

        SqlBaglanti bgl = new SqlBaglanti();

        private void FormHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            tcMaskedTextBox.Text = TCNo;
            SqlCommand hastaCommand = new SqlCommand("Select * from Tbl_Hastalar where HastaTc =@p1 ",bgl.connection());
            hastaCommand.Parameters.AddWithValue("@p1", tcMaskedTextBox.Text);
            SqlDataReader dr = hastaCommand.ExecuteReader();
            while (dr.Read())
            {
                adTextBox.Text = dr[1].ToString();
                soyadTextBox.Text = dr[2].ToString();
                phoneMaskedTextBox.Text = dr[4].ToString();
                passwordTextBox.Text = dr[5].ToString();
                genderComboBox.Text = dr[6].ToString();
            }
            bgl.connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand degistirCommand = new SqlCommand("update Tbl_Hastalar set HastaAd = @s1,HastaSoyad = @s2, HastaTelefon= @s3, HastaSifre=@s4,HastaCinsiyet = @s5 where HastaTc = @s6", bgl.connection());
            degistirCommand.Parameters.AddWithValue("@s1",adTextBox.Text);
            degistirCommand.Parameters.AddWithValue("@s2",soyadTextBox.Text);
            degistirCommand.Parameters.AddWithValue("@s3",phoneMaskedTextBox.Text);
            degistirCommand.Parameters.AddWithValue("@s4",passwordTextBox.Text);
            degistirCommand.Parameters.AddWithValue("@s5",genderComboBox.Text);
            degistirCommand.Parameters.AddWithValue("@s6",tcMaskedTextBox.Text);
            degistirCommand.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi.");
            this.Hide();

        }
    }
}
