using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace CryT_Remade
{
    public partial class Main : Form
    {
        WeAreDevs_API.ExploitAPI WrdApi = new ExploitAPI();


        public Main()
        {
            InitializeComponent();
        }

        private void EasyXploitRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DevXternal/CryT");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

