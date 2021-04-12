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

            //TreeNode anaDugum = new TreeNode();
            //anaDugum.Text = "This PC";

            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (var driver in drivers)
            {
                treeView1.Nodes.Add(driver.Name);
                Klasoryukle(driver.Name);
            }
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        public void Klasoryukle(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            //DosyaYukle(Dir, tds);
            //AltKlasorYukle(Dir, tds);
        }
        private void AltKlasorYukle(string dir, TreeNode td)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(dir);

            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                DosyaYukle(subdirectory, tds);
                AltKlasorYukle(subdirectory, tds);
            }
        }
        private void DosyaYukle(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
            }
        }
    }
}
