using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpaceFightServer
{
    public partial class MapsControl : UserControl
    {
        public MapsControl()
        {
            InitializeComponent();
        }

        private void mapUpdate_Tick(object sender, EventArgs e)
        {
            textMap.Text = Map1.toString();
        }

        private void map1But_Click(object sender, EventArgs e)
        {
            mapUpdate.Start();
        }
    }
}
