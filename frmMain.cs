using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhânSự
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuDanhsach_Click(object sender, EventArgs e)
        {
            frmDanhsach frmDanhsach = new frmDanhsach();
            frmDanhsach.Show();
            this.Hide();
        }

        private void mnuBietphai_Click(object sender, EventArgs e)
        {
            frmBietphai frmBietphai = new frmBietphai();
            frmBietphai.Show();
            this.Hide();
        }

        private void mnuCudihoc_Click(object sender, EventArgs e)
        {
            frmCudihoc frmCudihoc = new frmCudihoc();
            frmCudihoc.Show();
            this.Hide();
        }
    }
}
