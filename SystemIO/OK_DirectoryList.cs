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

namespace SystemIO
{
    public partial class OK_DirectoryList : Form
    {
        DirectoryInfo directory;
        public OK_DirectoryList()
        {
            InitializeComponent();
        }

        private void OK_DirectoryList_Load(object sender, EventArgs e)
        {
            //lblDirectory.Text = Directory.GetCurrentDirectory();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
                listDrive.Items.Add(drive.Name);
        }
        private void listDrive_Click(object sender, EventArgs e)
        {
            DriveInfo drive = new DriveInfo(listDrive.SelectedItem.ToString());
            directory = drive.RootDirectory;
            CurrentDirectory();

            string[] dirs = Directory.GetDirectories(directory.FullName);

            listDirectory.Items.Clear();
            foreach (var dir in dirs)
                listDirectory.Items.Add(Path.GetFileName(dir));
        }
        private void listDirectory_Click(object sender, EventArgs e)
        {

        }
        private string CurrentDirectory()
        {
            lblDirectory.Text = directory.ToString();
            return lblDirectory.Text;
        }
    }
}
