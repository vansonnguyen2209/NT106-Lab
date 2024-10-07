using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {

                TreeNode selectedNode = treeView1.SelectedNode;
                string selectedPath =  selectedNode.FullPath;
                switch(Path.GetExtension(selectedPath))
                {
                    case ".txt":
                    case ".doc":
                    case ".docx":
                        richTextBox1.BringToFront();
                        using (FileStream file = System.IO.File.Open(Path.GetFullPath(selectedPath), FileMode.Open))
                        {
                            StreamReader text = new StreamReader(file);
                            this.richTextBox1.Text = text.ReadToEnd();
                        }
                        break;
                    case ".png":
                    case ".ico":
                    case ".jpg":
                        pictureBox1.BringToFront();
                        pictureBox1.Load(selectedPath);
                        break;
                    default:
                        richTextBox1.Clear();
                        pictureBox1.Image = null;
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                DriveInfo driveinfo = new DriveInfo(drive);
                if (driveinfo.IsReady)
                {
                    TreeNode root = new TreeNode(driveinfo.Name);
                    treeView1.Nodes.Add(root);

                    var folders = new DirectoryInfo(drive).GetDirectories();
                    foreach(DirectoryInfo folder in folders)
                    {
                        if (Directory.Exists(folder.FullName))
                        {
                            TreeNode node = new TreeNode(folder.Name);
                            root.Nodes.Add(node);
                            LoadFolder(node);
                            LoadFile(node);
                        }
                    }
                }
            }



        }
        private void LoadFolder(TreeNode root)
        {
            if (root == null) return;
            try
            {
                var folders = new DirectoryInfo(root.FullPath).GetDirectories();
                if (folders.Count() == 0) return;    
                foreach (DirectoryInfo folder in folders)
                {
                    if (Directory.Exists(folder.FullName)) {
                        TreeNode node = new TreeNode(folder.Name);
                        root.Nodes.Add(node);
                        LoadFolder(node);
                    }
                }
            }
            catch
            {
                return;
            };


        }


            private void LoadFile(TreeNode root)
        {
            if (root == null) return;
            try
            {
                var files = new DirectoryInfo(root.FullPath).GetFiles();
                if (files.Count() == 0) return;
                foreach (FileInfo file in files)
                {
                    if (System.IO.File.Exists(file.FullName))
                    {
                        TreeNode node = new TreeNode(file.Name);
                        root.Nodes.Add(node);
                        LoadFile(node);
                    }
                }
            }
            catch
            {
                return;
            };
        }
    }
}
