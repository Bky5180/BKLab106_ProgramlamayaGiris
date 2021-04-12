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
        string[] dirsD;

        private string currentDirectory;
        private string dirPath;
        public string CurrentDirectory
        {
            get { return currentDirectory; }
            set
            {
                if (directory is null)
                    currentDirectory = "";
                else
                {
                    if (string.IsNullOrEmpty(value))
                        Directory.SetCurrentDirectory(directory.FullName);
                    else
                        Directory.SetCurrentDirectory(value);

                    currentDirectory = Directory.GetCurrentDirectory();
                }
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
        private void ListDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DriveInfo drive = new DriveInfo(listDrive.SelectedItem.ToString());
                directory = drive.RootDirectory;

                GetDirsFiles(out string[] dirsF, out string[] files);
                dirPath = null;
                ChangeDirectory();

                listDirectory.Items.Clear();
                foreach (var dirD in dirsD)
                    listDirectory.Items.Add(dirD);

                listFile.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir sürücü seçiniz!");
            }
        }
        private void ListDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetDirsFiles(out string[] dirsF, out string[] files);
                ChangeDirectory();

                listFile.Items.Clear();
                foreach (var dirF in dirsF)
                    listFile.Items.Add(dirF);

                foreach (var file in files)
                    listFile.Items.Add(file);
            }
            catch (Exception)
            {
                listFile.Items.Clear();
                lblDirectory.Text = "";
                MessageBox.Show("Lütfen bir klasör seçiniz!");
            }
        }
        private void ChangeDirectory()
        {
            CurrentDirectory = dirPath;
            lblDirectory.Text = CurrentDirectory;
        }
        private string[] GetDirsFiles(out string[] dirsF, out string[] files)
        {
            dirsD = Directory.GetDirectories(directory.FullName);

            if (listDirectory.SelectedItem != null)
            {
                dirPath = new DirectoryInfo(listDirectory.SelectedItem.ToString()).ToString();

                files = Directory.GetFiles(dirPath);
                dirsF = Directory.GetDirectories(dirPath);
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
