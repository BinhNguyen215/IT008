using System.Runtime.CompilerServices;

namespace BT
{
    public partial class Form1 : Form
    {
        public string filepath=null;
        private Login login;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void bt_OpenFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_PathFile form_PathFile= new Form_PathFile();
            form_PathFile.ShowDialog();
            this.FM_richtext.Text = form_PathFile.FileContent;
            this.filepath = form_PathFile.filepath;
            FM_lb_filepath_now.Text = filepath;
            form_PathFile = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)//Luu File
        {
            
            if (filepath == null)
            {
                MessageBox.Show("Bạn chưa nhập đường dẫn");
                Form_PathFile form_PathFile=new Form_PathFile();
                form_PathFile.ShowDialog();
                filepath = form_PathFile.filepath;
            }
            if (filepath != null)
            { 
                File.WriteAllText(filepath, FM_richtext.Text);
                MessageBox.Show("Lưu thành công");
            }
            FM_lb_filepath_now.Text = filepath;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_PathFile form_PathFile = new Form_PathFile();
            form_PathFile.ShowDialog();
            filepath = form_PathFile.filepath;
            try
            {
                using (FileStream fs = File.Create(filepath))
                {
                    // Chuyển nội dung thành mảng bytes
                    byte[] contentBytes = System.Text.Encoding.UTF8.GetBytes(FM_richtext.Text);

                    // Ghi nội dung vào tệp
                    fs.Write(contentBytes, 0, contentBytes.Length);
                }
                MessageBox.Show("Tệp đã được tạo thành công.");
                FM_lb_filepath_now.Text = filepath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đường dẫn không tồn tại. Lỗi {ex.Message}");
            }
            
            //if(flag!="SA")// save as
           

        }

        private void FM_lb_filepath_now_Click(object sender, EventArgs e)
        {

        }

        private void FM_tb_SAF_Click(object sender, EventArgs e)
        {
            bool flag1 = false,flag2=false;
            Form_PathFile form_PathFile = new Form_PathFile();
            form_PathFile.ShowDialog();
            filepath = form_PathFile.filepath;
            try
            {
                using (FileStream fs = File.Create(filepath))
                {
                    // Chuyển nội dung thành mảng bytes
                    byte[] contentBytes = System.Text.Encoding.UTF8.GetBytes(FM_richtext.Text);

                    // Ghi nội dung vào tệp
                    fs.Write(contentBytes, 0, contentBytes.Length);
                }
                flag1 = true;
                //MessageBox.Show("Tệp đã được tạo thành công.");
                FM_lb_filepath_now.Text = filepath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đường dẫn không tồn tại. Lỗi {ex.Message}");
            }
            File.WriteAllText(filepath, FM_richtext.Text);
            MessageBox.Show("Lưu thành công");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            login=new Login();
            this.Show();
            login.FormClosed += FormLogin_FormClosed;
          /*  login.Owner= this;*/
            login.ShowDialog();

        }
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login formLogin = (Login)sender;
            if (!formLogin.userLoggedIn)
            {
                this.Close();
            }
            else
            {
                this.FM_lb_userLogIn.ForeColor = Color.ForestGreen;
                this.FM_lb_userLogIn.Location =new Point (975, 9);
                this.FM_lb_userLogIn.Text = $"Đăng nhập thành công, chào {formLogin.GetTextBox_user().Text}";
            }
        }
       
    }
}
