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
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FormSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sekreterGirisCommand = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre = @p2", bgl.connection());
            sekreterGirisCommand.Parameters.AddWithValue("@p1",tcMaskedTextBox.Text);
            sekreterGirisCommand.Parameters.AddWithValue("@p2",sifreTextBox.Text);

            SqlDataReader reader =  sekreterGirisCommand.ExecuteReader();
            if (reader.Read())
            {
                FormSekreterDetay sekreterDetay = new FormSekreterDetay();
                sekreterDetay.TCno = tcMaskedTextBox.Text;
                sekreterDetay.Show();             
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı Tc ve Şifre bilgisi girişi!!");
            }
            bgl.connection().Close();
            
        }
    }
}
