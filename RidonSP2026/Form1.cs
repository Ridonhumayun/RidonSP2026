using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RidonSP2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Event procedure that will run when the user clicks pn the calculate button
        private void btnCalc_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDogOwner.Clear();
            txtNumOfWalksPerWeek.Clear();
            lstOut.Items.Clear();
        }
    }//End of Form1
} // end of namespace
