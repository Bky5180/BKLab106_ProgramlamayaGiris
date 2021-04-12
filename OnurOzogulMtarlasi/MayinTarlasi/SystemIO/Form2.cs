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
            // Drive info : surucu bilgilerine erisim icin kullanilir 

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                string bilgi = $"Isim: {item.Name} \nBos alan : {item.TotalFreeSpace} \n Toplam Alan : {item.TotalSize}";
                //MessageBox.Show(bilgi); 
                listBox1.Items.Add(bilgi);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo drive = new DriveInfo(listBox1.SelectedItem.ToString());
            DirectoryInfo directory= drive.RootDirectory;

            string[] liste = Directory.GetDirectories(directory.FullName);

            foreach (var item in liste)
            {
                listBox2.Items.Add(item); 
            }
        }
        void button2_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode();
            node.Text = "Elektronik";

            TreeNode digernode = new TreeNode();
            digernode.Text = "Bilgisayar";

            node.Nodes.Add(digernode);

            digernode = new TreeNode();
            digernode.Text = "Beyaz Esya";
            node.Nodes.Add(digernode);

            treeView1.Nodes.Add(node); 
        }
    }
}
