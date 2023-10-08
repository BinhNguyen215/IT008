using System.Diagnostics;
using System.Reflection.Metadata;

namespace Lab1_1._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView.Scrollable = true;
            listView.View = View.Tile;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(textBox.Text);

            try
            {
                foreach (string file in files)
                {
                    listView.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No file in such directory" + ex);
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Selected == true)
                {
                    //MessageBox.Show();
                    Process.Start("explorer.exe", item.Text);
                }
            }
        }
    }
}