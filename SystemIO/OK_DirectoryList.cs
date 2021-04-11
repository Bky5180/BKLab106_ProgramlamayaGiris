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
using System.Security.AccessControl;

namespace SystemIO
{
    public partial class OK_DirectoryList : Form
    {
        DirectoryInfo directory, dirPath;
        string[] dirsD;
        private string currentDirectory;
        public string CurrentDirectory
        {
            get { return currentDirectory; }
            set
            {
                currentDirectory =
                    value.Replace(value, directory.ToString());
            }
        }
        public OK_DirectoryList()
        {
            InitializeComponent();
        }
        private void OK_DirectoryList_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
                listDrive.Items.Add(drive.Name);
        }
        private void listDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DriveInfo drive = new DriveInfo(listDrive.SelectedItem.ToString());
                directory = drive.RootDirectory;
                //ChangeDirectory();
                //ChangeDirectory2();

                GetDirsFiles(out string[] dirsF, out string[] files);

                listDirectory.Items.Clear();
                listFile.Items.Clear();
                foreach (var dirD in dirsD)
                    listDirectory.Items.Add(dirD);
                //listDirectory.Items.Add(Path.GetFileName(dirD));
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir sürücü seçiniz!");
            }
        }
        private void listDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetDirsFiles(out string[] dirsF, out string[] files);

                listFile.Items.Clear();
                foreach (var dirF in dirsF)
                    listFile.Items.Add(dirF);
                //listFile.Items.Add(Path.GetFileName(dirF));

                foreach (var file in files)
                    listFile.Items.Add(file);
                //listFile.Items.Add(Path.GetFileName(file));
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir klasör seçiniz!");
            }
        }
        private void ChangeDirectory()
        {
            CurrentDirectory = Directory.GetCurrentDirectory();
            lblDirectory.Text = CurrentDirectory;
        }
        private void ChangeDirectory2()
        {
            Directory.SetCurrentDirectory(directory.FullName);
            lblDirectory.Text = Directory.GetCurrentDirectory();
        }
        private string[] GetDirsFiles(out string[] dirsF, out string[] files)
        {
            dirsD = Directory.GetDirectories(directory.FullName);

            if (listDirectory.SelectedItem != null)
            {
                dirPath = new DirectoryInfo(listDirectory.SelectedItem.ToString());
                DirectorySecurity dirSecurity = dirPath.GetAccessControl(AccessControlSections.All);
                dirPath.SetAccessControl(dirSecurity);

                files = Directory.GetFiles(dirPath.ToString());
                dirsF = Directory.GetDirectories(dirPath.ToString());
            }
            else
            {
                files = null;
                dirsF = null;
            }
            return dirsD;
        }
    }
}
