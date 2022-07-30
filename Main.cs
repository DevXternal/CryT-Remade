using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Hub openform = new Hub();
            openform.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void siticoneButton4_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            WrdApi.SendLuaScript(fastColoredTextBox1.Text);
            WrdApi.SendLuaCScript(fastColoredTextBox1.Text);
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open Script Lol";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
    }
}

