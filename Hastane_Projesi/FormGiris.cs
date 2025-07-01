using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void hastaButton_Click(object sender, EventArgs e)
        {
            FormHastaGiris hastagiris = new FormHastaGiris();
            hastagiris.Show();
            this.Hide();
        }

        private void sekreterButton_Click(object sender, EventArgs e)
        {
            FormSekreterGiris sekreterGiris = new FormSekreterGiris();
            sekreterGiris.Show();
            this.Hide();
        }

        private void doktorButton_Click(object sender, EventArgs e)
        {
            FormDoktorGiris doktorGiris = new FormDoktorGiris();
            doktorGiris.Show();
            this.Hide();
        }
    }
}
