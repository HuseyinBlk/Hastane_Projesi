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
    public partial class FormHastaKayit : Form
    {
        public FormHastaKayit()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void FormHastaKayit_Load(object sender, EventArgs e)
        {
            genderComboBox.Items.Add("Erkek");
            genderComboBox.Items.Add("Kadın");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kayitCommand = new SqlCommand("insert into Tbl_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet) values (@cAd,@cSoyad,@cTC,@cTelefon,@cSifre, @cCinsiyet)",bgl.connection());
            kayitCommand.Parameters.AddWithValue("@cAd",adTextBox.Text);
            kayitCommand.Parameters.AddWithValue("@cSoyad", soyadTextBox.Text);
            kayitCommand.Parameters.AddWithValue("@cTC", tcMaskedTextBox.Text);
            kayitCommand.Parameters.AddWithValue("@cTelefon", telefonMaskedTextBox.Text);
            kayitCommand.Parameters.AddWithValue("@cSifre", passwordTextBox.Text);
            kayitCommand.Parameters.AddWithValue("@cCinsiyet", genderComboBox.Text);

            kayitCommand.ExecuteNonQuery();
            bgl.connection().Close();

            MessageBox.Show("Kayıt başarıyla oluşturuldu.");
            FormHastaGiris hastaGiris = new FormHastaGiris();
            hastaGiris.Show();
            this.Hide();



        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
