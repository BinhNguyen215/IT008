namespace BT
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LI_lb_user = new System.Windows.Forms.Label();
            this.FM_lb_pw = new System.Windows.Forms.Label();
            this.LI_tb_user = new System.Windows.Forms.TextBox();
            this.LI_tb_pw = new System.Windows.Forms.TextBox();
            this.LI_bt_signin = new System.Windows.Forms.Button();
            this.LI_bt_signup = new System.Windows.Forms.Button();
            this.LI_bt_demo = new System.Windows.Forms.Button();
            this.LI_lb_nofi_nopw = new System.Windows.Forms.Label();
            this.LI_lb_nofi_nouser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // LI_lb_user
            // 
            this.LI_lb_user.AutoSize = true;
            this.LI_lb_user.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LI_lb_user.Location = new System.Drawing.Point(62, 115);
            this.LI_lb_user.Name = "LI_lb_user";
            this.LI_lb_user.Size = new System.Drawing.Size(69, 36);
            this.LI_lb_user.TabIndex = 1;
            this.LI_lb_user.Text = "User";
            // 
            // FM_lb_pw
            // 
            this.FM_lb_pw.AutoSize = true;
            this.FM_lb_pw.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FM_lb_pw.Location = new System.Drawing.Point(62, 240);
            this.FM_lb_pw.Name = "FM_lb_pw";
            this.FM_lb_pw.Size = new System.Drawing.Size(129, 36);
            this.FM_lb_pw.TabIndex = 2;
            this.FM_lb_pw.Text = "Password";
            // 
            // LI_tb_user
            // 
            this.LI_tb_user.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LI_tb_user.Location = new System.Drawing.Point(62, 175);
            this.LI_tb_user.Name = "LI_tb_user";
            this.LI_tb_user.Size = new System.Drawing.Size(464, 42);
            this.LI_tb_user.TabIndex = 3;
            this.LI_tb_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LI_tb_user_KeyDown);
            this.LI_tb_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LI_tb_user_KeyPress);
            // 
            // LI_tb_pw
            // 
            this.LI_tb_pw.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LI_tb_pw.Location = new System.Drawing.Point(62, 289);
            this.LI_tb_pw.Name = "LI_tb_pw";
            this.LI_tb_pw.Size = new System.Drawing.Size(464, 42);
            this.LI_tb_pw.TabIndex = 4;
            this.LI_tb_pw.TextChanged += new System.EventHandler(this.LI_tb_pw_TextChanged);
            this.LI_tb_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LI_tb_pw_KeyDown);
            this.LI_tb_pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LI_tb_pw_KeyPress);
            // 
            // LI_bt_signin
            // 
            this.LI_bt_signin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LI_bt_signin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LI_bt_signin.Location = new System.Drawing.Point(62, 374);
            this.LI_bt_signin.Name = "LI_bt_signin";
            this.LI_bt_signin.Size = new System.Drawing.Size(464, 54);
            this.LI_bt_signin.TabIndex = 6;
            this.LI_bt_signin.Text = "Đăng nhập";
            this.LI_bt_signin.UseVisualStyleBackColor = true;
            this.LI_bt_signin.Click += new System.EventHandler(this.LG_bt_signin_Click);
            // 
            // LI_bt_signup
            // 
            this.LI_bt_signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LI_bt_signup.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LI_bt_signup.Location = new System.Drawing.Point(62, 444);
            this.LI_bt_signup.Name = "LI_bt_signup";
            this.LI_bt_signup.Size = new System.Drawing.Size(464, 54);
            this.LI_bt_signup.TabIndex = 8;
            this.LI_bt_signup.Text = "Đăng ký";
            this.LI_bt_signup.UseVisualStyleBackColor = true;
            this.LI_bt_signup.Click += new System.EventHandler(this.LG_bt_signup_Click_1);
            // 
            // LI_bt_demo
            // 
            this.LI_bt_demo.Location = new System.Drawing.Point(184, 504);
            this.LI_bt_demo.Name = "LI_bt_demo";
            this.LI_bt_demo.Size = new System.Drawing.Size(179, 34);
            this.LI_bt_demo.TabIndex = 9;
            this.LI_bt_demo.Text = "Bỏ qua (demo).";
            this.LI_bt_demo.UseVisualStyleBackColor = true;
            this.LI_bt_demo.Click += new System.EventHandler(this.button1_Click);
            // 
            // LI_lb_nofi_nopw
            // 
            this.LI_lb_nofi_nopw.AutoSize = true;
            this.LI_lb_nofi_nopw.ForeColor = System.Drawing.Color.Red;
            this.LI_lb_nofi_nopw.Location = new System.Drawing.Point(62, 334);
            this.LI_lb_nofi_nopw.Name = "LI_lb_nofi_nopw";
            this.LI_lb_nofi_nopw.Size = new System.Drawing.Size(0, 25);
            this.LI_lb_nofi_nopw.TabIndex = 10;
            // 
            // LI_lb_nofi_nouser
            // 
            this.LI_lb_nofi_nouser.AutoSize = true;
            this.LI_lb_nofi_nouser.ForeColor = System.Drawing.Color.Red;
            this.LI_lb_nofi_nouser.Location = new System.Drawing.Point(62, 220);
            this.LI_lb_nofi_nouser.Name = "LI_lb_nofi_nouser";
            this.LI_lb_nofi_nouser.Size = new System.Drawing.Size(0, 25);
            this.LI_lb_nofi_nouser.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 608);
            this.Controls.Add(this.LI_lb_nofi_nouser);
            this.Controls.Add(this.LI_lb_nofi_nopw);
            this.Controls.Add(this.LI_bt_demo);
            this.Controls.Add(this.LI_bt_signup);
            this.Controls.Add(this.LI_bt_signin);
            this.Controls.Add(this.LI_tb_pw);
            this.Controls.Add(this.LI_tb_user);
            this.Controls.Add(this.FM_lb_pw);
            this.Controls.Add(this.LI_lb_user);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label LI_lb_user;
        private Label FM_lb_pw;
        private TextBox LI_tb_user;
        private TextBox LI_tb_pw;
        private Button LI_bt_signin;
        private Button LI_bt_signup;
        private Button LI_bt_demo;
        private Label LI_lb_nofi_nopw;
        private Label LI_lb_nofi_nouser;
    }
}