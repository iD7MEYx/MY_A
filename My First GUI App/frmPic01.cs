using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_GUI_App
{
    public partial class frmPic01 : Form
    {
        public frmPic01()
        {
            InitializeComponent();
        }

        private void btnFromF_Click(object sender, EventArgs e)
        {
            PicTry.Image = Image.FromFile("C:\\Users\\MSI\\Desktop\\LFC.jpg");
            MessageBox.Show("Image file found!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnFromR_Click(object sender, EventArgs e)
        {

        }
    }
}
