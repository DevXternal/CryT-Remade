using DiscordRPC;
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
            RPC.rpctimestamp = Timestamps.Now;
            RPC.InitializeRPC();
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

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            RPC2.rpctimestamp = Timestamps.Now;
            RPC2.InitializeRPC();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Hub openform = new Hub();
            openform.Show();
        }
    }
}

