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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SU_bt_signup_Click(object sender, EventArgs e)
        {
            string key = "MySecretKey12345";
            string iv = "InitializationVe";
            string E_user = MyFunction.Encrypt(SU_tb_user.Text, key, iv);
            string E_pw = MyFunction.Encrypt(SU_tb_pw.Text, key, iv);
            MyFunction.SaveAccountInfo(E_user, E_pw,"D:\\user.txt");
            MessageBox.Show("Đăng ký thành công");
            this.Close();
        }

        private void SU_tb_pw_TextChanged(object sender, EventArgs e)
        {
            SU_tb_pw.PasswordChar= '*';
        }

        private void SU_tb_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
