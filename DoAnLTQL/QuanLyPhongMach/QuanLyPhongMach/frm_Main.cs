using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMach
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AccountProfile f = new frm_AccountProfile();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Admin f = new frm_Admin();
            f.ShowDialog();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            frm_ExaminationForm f = new frm_ExaminationForm();
            f.ShowDialog();
        }
    }
}
