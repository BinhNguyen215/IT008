namespace BT
{
    partial class SignUp
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
            this.SU_bt_signup = new System.Windows.Forms.Button();
            this.SU_tb_pw = new System.Windows.Forms.TextBox();
            this.SU_tb_user = new System.Windows.Forms.TextBox();
            this.FM_lb_pw = new System.Windows.Forms.Label();
            this.LI_lb_user = new System.Windows.Forms.Label();
            this.lb_signup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SU_bt_signup
            // 
            this.SU_bt_signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_bt_signup.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SU_bt_signup.Location = new System.Drawing.Point(67, 366);
            this.SU_bt_signup.Name = "SU_bt_signup";
            this.SU_bt_signup.Size = new System.Drawing.Size(464, 54);
            this.SU_bt_signup.TabIndex = 17;
            this.SU_bt_signup.Text = "Đăng ký";
            this.SU_bt_signup.UseVisualStyleBackColor = true;
            this.SU_bt_signup.Click += new System.EventHandler(this.SU_bt_signup_Click);
            // 
            // SU_tb_pw
            // 
            this.SU_tb_pw.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_tb_pw.Location = new System.Drawing.Point(67, 258);
            this.SU_tb_pw.Name = "SU_tb_pw";
            this.SU_tb_pw.Size = new System.Drawing.Size(464, 42);
            this.SU_tb_pw.TabIndex = 13;
            this.SU_tb_pw.TextChanged += new System.EventHandler(this.SU_tb_pw_TextChanged);
            // 
            // SU_tb_user
            // 
            this.SU_tb_user.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_tb_user.Location = new System.Drawing.Point(67, 144);
            this.SU_tb_user.Name = "SU_tb_user";
            this.SU_tb_user.Size = new System.Drawing.Size(464, 42);
            this.SU_tb_user.TabIndex = 12;
            this.SU_tb_user.TextChanged += new System.EventHandler(this.SU_tb_user_TextChanged);
            // 
            // FM_lb_pw
            // 
            this.FM_lb_pw.AutoSize = true;
            this.FM_lb_pw.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FM_lb_pw.Location = new System.Drawing.Point(67, 209);
            this.FM_lb_pw.Name = "FM_lb_pw";
            this.FM_lb_pw.Size = new System.Drawing.Size(129, 36);
            this.FM_lb_pw.TabIndex = 11;
            this.FM_lb_pw.Text = "Password";
            // 
            // LI_lb_user
            // 
            this.LI_lb_user.AutoSize = true;
            this.LI_lb_user.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LI_lb_user.Location = new System.Drawing.Point(67, 84);
            this.LI_lb_user.Name = "LI_lb_user";
            this.LI_lb_user.Size = new System.Drawing.Size(69, 36);
            this.LI_lb_user.TabIndex = 10;
            this.LI_lb_user.Text = "User";
            // 
            // lb_signup
            // 
            this.lb_signup.AutoSize = true;
            this.lb_signup.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_signup.Location = new System.Drawing.Point(247, 27);
            this.lb_signup.Name = "lb_signup";
            this.lb_signup.Size = new System.Drawing.Size(134, 41);
            this.lb_signup.TabIndex = 9;
            this.lb_signup.Text = "Đăng ký";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 562);
            this.Controls.Add(this.SU_bt_signup);
            this.Controls.Add(this.SU_tb_pw);
            this.Controls.Add(this.SU_tb_user);
            this.Controls.Add(this.FM_lb_pw);
            this.Controls.Add(this.LI_lb_user);
            this.Controls.Add(this.lb_signup);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SU_bt_signup;
        private TextBox SU_tb_pw;
        private TextBox SU_tb_user;
        private Label FM_lb_pw;
        private Label LI_lb_user;
        private Label lb_signup;
    }
}