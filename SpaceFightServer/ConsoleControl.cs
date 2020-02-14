using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public partial class ConsoleControl : UserControl
    {
        SwayStation station;
        public ConsoleControl(SwayStation sway)
        {
            InitializeComponent();
            station = sway;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConsoleControl_Load(object sender, EventArgs e)
        {

        }

        public TextBox GetLogTextBox()
        {
            return ConsoleLog;
        }

        private void dumpToFile_Click(object sender, EventArgs e)
        {
            station.LogToFile();
        }
    }
}
