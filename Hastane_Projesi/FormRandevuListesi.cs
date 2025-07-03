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
    public partial class FormRandevuListesi : Form
    {
        public FormRandevuListesi()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
       
        private void FormRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From Tbl_Randevular",bgl.connection());
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connection().Close();
        }
        public int secilen;
        public string index;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            index = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

    }
}
