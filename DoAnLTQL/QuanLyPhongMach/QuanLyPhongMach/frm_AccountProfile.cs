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
    public partial class frm_AccountProfile : Form
    {
        public frm_AccountProfile()
        {
            InitializeComponent();
        }

        private void chkChangePass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkChangePass.Checked==true)
            {
                panel4.Visible = true;
                panel5.Visible = true;
            }    
            if(chkChangePass.Checked==false)
            {
                panel4.Visible = false;
                panel5.Visible = false;
            }    
        }
    }
}
