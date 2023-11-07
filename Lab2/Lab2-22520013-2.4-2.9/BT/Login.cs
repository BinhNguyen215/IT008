using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT
{
    public partial class Login : Form
    {
        private int solan = 5, solansai = 0;
        public bool userLoggedIn=false;
        public TextBox GetTextBox_user()
        {
            return LI_tb_user;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void LI_tb_pw_TextChanged(object sender, EventArgs e)
        {
            LI_tb_pw.PasswordChar = '*';
        }

     

        private void LG_bt_signin_Click(object sender, EventArgs e)
        {
            if (LI_tb_user.Text == "" || LI_tb_pw.Text == "")
            {
                if (LI_tb_pw.Text == "")
                {
                    LI_tb_pw.Focus();
                    LI_lb_nofi_nopw.Text = "*Bạn chưa nhập mật khẩu";
                }
                if (LI_tb_user.Text == "")
                {
                    LI_tb_user.Focus();
                    LI_lb_nofi_nouser.Text = "*Bạn chưa nhập user";
                }

            }
            else
            {
                if (MyFunction.check_login(LI_tb_user.Text, LI_tb_pw.Text, "D:\\user.txt"))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    userLoggedIn = true;
                    solansai = 0;
                    this.Close();
                }    
                else
                {
                    solansai++;
                    LI_lb_nofi_nopw.Text=$"Nhập sai mật khẩu hoặc tài khoản {solan} lần sẽ bị khóa ({solansai}/{solan})";
                    if (solansai == solan)
                    {
                        this.Close() ;
                         
                    }
                    LI_lb_user.Focus();
                }

            } 
             
        }

        private void LG_bt_signup_Click_1(object sender, EventArgs e)
        {
            SignUp signup= new SignUp();   
            signup.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userLoggedIn = true;
            LI_tb_user.Text = "userDemo";
            this.Close();

        }

        private void LI_tb_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (LI_tb_user.Text == "")
            {
                LI_tb_user.Focus();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (LI_tb_user.Text == "")
                {
                    LI_tb_user.Focus();
                    LI_lb_nofi_nouser.Text = "*Bạn chưa nhập user";
                    if (LI_lb_nofi_nopw.Text =="") 
                    LI_lb_nofi_nopw.Text = "*Bạn chưa nhập mật khẩu";
                }
                else
                {
                    LG_bt_signin_Click(sender, new EventArgs());
                } 
                    
            }

        }
        
        private void LI_tb_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (LI_tb_user.Focused && LI_lb_nofi_nouser.Text != "")
            {

                LI_lb_nofi_nouser.Text = "";
                e.Handled = true; // Đánh dấu sự kiện đã được xử lý
            }
        }

        private void LI_tb_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (LI_tb_pw.Focused && LI_lb_nofi_nopw.Text != "")
            {

                LI_lb_nofi_nopw.Text = "";
                e.Handled = true; // Đánh dấu sự kiện đã được xử lý
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* if (this.Owner is Form1 form_main)
            {
                if (!userLoggedIn)
                    form_main.Close();
            }*/
        }

        private void LI_tb_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn việc xuống dòng tự động
                if(LI_tb_user.Text=="")
                {
                    LI_tb_user.Focus();
                    LI_lb_nofi_nouser.Text = "*Bạn chưa nhập user";
                    if (LI_tb_pw.Text == "")
                    {
                        LI_lb_nofi_nopw.Text = "*Bạn chưa nhập mật khẩu";
                    }
                }
                else
                {
                    LG_bt_signin_Click(sender, new EventArgs());
                } 
                    
            }
        }
    }
}
