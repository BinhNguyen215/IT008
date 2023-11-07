using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> wantToCopyFiles = new List<string>();
        List<string> wantToCutFiles = new List<string>();
        bool isCutting = false;
        bool isCopying = false;
        public Form1()
        {

            InitializeComponent();
            var dir = Directory.GetLogicalDrives();
            foreach (var item in dir)
            {
                treeView1.Nodes.Add(item[0] + ":");
                treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Add("*");
            }
            comboBox2.SelectedIndex = 1;
            textBox1.ReadOnly = true;
            pasteToolStripMenuItem.Enabled = false;
            panel1.SendToBack();
            renameToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            pasteToolStripMenuItem.Enabled = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 3)
                return;
            int index = textBox1.Text.LastIndexOf('\\');
            if (index > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, index);
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.LastIndexOf('/') + 1);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox2.Text;
        }
        List<string> listFile = new List<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (listView1.View == View.Details)
                detailToolStripMenuItem.PerformClick();
            if (listView1.View == View.List)
                listToolStripMenuItem.PerformClick();
            if (listView1.View == View.LargeIcon)
                largeIconToolStripMenuItem.PerformClick();
            if (listView1.View == View.SmallIcon)
                smallIconToolStripMenuItem.PerformClick();
        }
        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Items.Clear();
            listFile.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name", 120); // Column title and width
            listView1.Columns.Add("Date Modify", 80);
            listView1.Columns.Add("Type", 150);
            foreach (var item in Directory.GetFiles(textBox1.Text))
            {
                FileInfo fi = new FileInfo(item);
                ListViewItem _item = new ListViewItem(fi.Name);
                _item.SubItems.Add(fi.LastAccessTime.ToString());
                _item.SubItems.Add("File");
                listFile.Add(fi.FullName);
                listView1.Items.Add(_item);
            }
            foreach (string item in Directory.GetDirectories(textBox1.Text))
            {
                FileInfo fi = new FileInfo(item);
                ListViewItem _item = new ListViewItem(fi.Name);
                _item.SubItems.Add(fi.LastAccessTime.ToString());
                _item.SubItems.Add("Folder");
                listFile.Add(fi.FullName);
                listView1.Items.Add(_item);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
            listView1.Clear();
            listFile.Clear();
            imageList1.Images.Clear();
            foreach (string item in Directory.GetFiles(textBox1.Text))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo fi = new FileInfo(item);
                listFile.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
            foreach (string item in Directory.GetDirectories(textBox1.Text))
            {
                imageList1.Images.Add(Resources.folder_48px);
                FileInfo fi = new FileInfo(item);
                listFile.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
        }
        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            listView1.Clear();
            listFile.Clear();
            imageList2.Images.Clear();
            listView1.LargeImageList = imageList2;
            foreach (string item in Directory.GetFiles(textBox1.Text))
            {
                imageList2.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo fi = new FileInfo(item);
                listFile.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList2.Images.Count - 1);
            }
            foreach (string item in Directory.GetDirectories(textBox1.Text))
            {
                imageList2.Images.Add(Resources.folder_48px);
                FileInfo fi = new FileInfo(item);
                listFile.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList2.Images.Count - 1);
            }
        }
        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView1.Clear();
            listFile.Clear();
            imageList1.Images.Clear();
            listView1.SmallImageList = imageList1;
            foreach (string item in Directory.GetFiles(textBox1.Text))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo fi = new FileInfo(item);
                listFile.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
            foreach (string item in Directory.GetDirectories(textBox1.Text))
            {
                imageList1.Images.Add(Resources.folder_48px);
                FileInfo fi = new FileInfo(item);
                listFile.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                FileAttributes attr = File.GetAttributes(listFile[listView1.FocusedItem.Index]);
                if (attr.HasFlag(FileAttributes.Directory))
                {
                    if (textBox1.Text == @"C:/" || textBox1.Text == @"D:/")
                        textBox1.Text = textBox1.Text + listView1.FocusedItem.Text;
                    else
                        textBox1.Text = textBox1.Text + @"\" + listView1.FocusedItem.Text;
                }
                else
                    Process.Start(listFile[listView1.FocusedItem.Index]);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringCollection listSelectedPath = new StringCollection();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                wantToCopyFiles.Add(listFile[listView1.Items.IndexOf(item)]);

            }
            isCopying = true;
            isCutting = false;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringCollection listSelectedPath = new StringCollection();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                wantToCutFiles.Add(listFile[listView1.Items.IndexOf(item)]);
            }
            isCopying = false;
            isCutting = true;
        }

        private void pastsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isCopying)
            {
                foreach (string file in wantToCopyFiles)
                {
                    FileInfo fi = new FileInfo(file);
                    File.Copy(fi.FullName, textBox1.Text + "/" + fi.Name, true);
                }
                isCopying = false;
                textBox1_TextChanged(sender, e);
            }
            if (isCutting)
            {
                foreach (string file in wantToCutFiles)
                {
                    FileInfo fi = new FileInfo(file);
                    File.Copy(fi.FullName, textBox1.Text + "/" + fi.Name, true);
                    File.Delete(fi.FullName);
                }
                isCutting = false;
                wantToCopyFiles.Clear();
                textBox1_TextChanged(sender, e);
            }

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringCollection listSelectedPath = new StringCollection();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                File.Delete(listFile[listView1.Items.IndexOf(item)]);
            }
            textBox1_TextChanged(sender, e);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                pasteToolStripMenuItem.Enabled = false;
            else
                pasteToolStripMenuItem.Enabled = true;
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
            }
            if (wantToCopyFiles.Count == 0 && wantToCutFiles.Count == 0)
            {
                pasteToolStripMenuItem.Enabled = false;
            }
            else
                pasteToolStripMenuItem.Enabled = true;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // List directories inside a directory in the treeview
            List<string> files = new List<string>();
            string path = e.Node.FullPath + "\\";
            e.Node.Nodes.Clear();
            treeView1.SelectedNode = e.Node;
            try
            {
                if (Directory.Exists(path))
                {
                    files.AddRange(Directory.EnumerateDirectories(path));
                    string[] buff = null;
                    for (int i = 0; i < files.Count; i++)
                    {
                        buff = files[i].Split('\\');
                        e.Node.Nodes.Add(buff[buff.Length - 1]);
                        e.Node.Nodes[e.Node.Nodes.Count - 1].Nodes.Add("*");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not list files in the given directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            listView1.Items.Clear();
            if (Directory.Exists(e.Node.FullPath))
            {
                if (e.Node.FullPath.Length == 2)
                    textBox1.Text = e.Node.FullPath + "/";
                else
                    textBox1.Text = e.Node.FullPath;
            }

        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            nameBox.Text = listView1.SelectedItems[0].Text.ToString();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                deleteToolStripMenuItem.Enabled = false;
                renameToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    renameToolStripMenuItem.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                }
                else
                    deleteToolStripMenuItem.Enabled = true;

            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(listFile[listView1.Items.IndexOf(listView1.SelectedItems[0])]);
            File.Move(fi.FullName, textBox1.Text + "/" + nameBox.Text);
            File.Delete(fi.FullName);
            panel1.SendToBack();
            textBox1_TextChanged(sender, e);
        }
    }
}
