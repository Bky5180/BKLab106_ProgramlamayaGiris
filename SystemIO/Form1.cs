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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// DriveInfo : surucu bilgilerine erisim icin kullanilir

            //DriveInfo[] drives= DriveInfo.GetDrives();
            //foreach (var item in drives)
            //{
            //    string bilgi = $"Isim:{item.Name} \nBoş Alan:{item.TotalFreeSpace} \n Toplam Alan:{item.TotalSize}";
            //    MessageBox.Show(bilgi);
            //}
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                //string bilgi = $"Isim:{item.Name} \nBoş Alan:{item.TotalFreeSpace} \n Toplam Alan:{item.TotalSize}";
                listDrive.Items.Add(item.Name);
            }
        }

        private void listDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo drive = new DriveInfo(listDrive.SelectedItem.ToString());
            DirectoryInfo directory = drive.RootDirectory;

            string[] liste = Directory.GetDirectories(directory.FullName);

            foreach (var item in liste)
            {
                listDirectory.Items.Add(item);
            }
        }

        private void listDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listFile.Items.Clear();
            string[] liste = Directory.GetFiles(listDirectory.SelectedItem.ToString());

            foreach (var item in liste)
            {
                listFile.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode();
            node.Text = "Elektronik";
            TreeNode digernode = new TreeNode();
            
            digernode.Text = "bilisayar";
            node.Nodes.Add(digernode);


            digernode = new TreeNode();
            digernode.Text = "Beyaz Esya";
            node.Nodes.Add(digernode);


            digernode = new TreeNode();
            digernode.Text = "Cep Telefonu";
            node.Nodes.Add(digernode);




            treeView1.Nodes.Add(node);
        }
    }
}
