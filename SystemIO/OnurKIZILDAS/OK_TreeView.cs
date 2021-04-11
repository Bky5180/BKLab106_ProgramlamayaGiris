using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SystemIO.Onur_KIZILDAŞ
{
    public partial class OK_TreeView : Form
    {
        public OK_TreeView()
        {
            InitializeComponent();
        }
        private void btnYukle_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            toolTip1.ShowAlways = true;

        }
    }
}
