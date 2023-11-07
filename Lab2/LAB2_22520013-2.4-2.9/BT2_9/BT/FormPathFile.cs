using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT
{
   
    public partial class Form_PathFile : Form
    {
        public string FileContent;
        public string filepath;
        public Form_PathFile( )
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            filepath = FPF_tb_path.Text;
            FileContent=File.ReadAllText(filepath);
            this.Close();
            
        }

        private void FPF_tb_path_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true; // Ngăn việc xuống dòng tự động
                    bt_xacnhan.Focus();
                }
            
        }
    }
}
