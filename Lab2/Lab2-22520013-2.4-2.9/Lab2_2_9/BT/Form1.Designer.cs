namespace BT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FM_richtext = new System.Windows.Forms.RichTextBox();
            this.bt_OpenFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_filepath_now = new System.Windows.Forms.Label();
            this.FM_tb_SAF = new System.Windows.Forms.Button();
            this.FM_label_filepath_now = new System.Windows.Forms.Label();
            this.FM_lb_filepath_now = new System.Windows.Forms.Label();
            this.FM_lb_userLogIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FM_richtext
            // 
            this.FM_richtext.Location = new System.Drawing.Point(12, 98);
            this.FM_richtext.Name = "FM_richtext";
            this.FM_richtext.Size = new System.Drawing.Size(1105, 690);
            this.FM_richtext.TabIndex = 0;
            this.FM_richtext.Text = "";
            // 
            // bt_OpenFile
            // 
            this.bt_OpenFile.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_OpenFile.Location = new System.Drawing.Point(1202, 623);
            this.bt_OpenFile.Name = "bt_OpenFile";
            this.bt_OpenFile.Size = new System.Drawing.Size(176, 86);
            this.bt_OpenFile.TabIndex = 1;
            this.bt_OpenFile.Text = "Mở File";
            this.bt_OpenFile.UseVisualStyleBackColor = true;
            this.bt_OpenFile.Click += new System.EventHandler(this.bt_OpenFile_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1202, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1202, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 86);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tạo File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_filepath_now
            // 
            this.lb_filepath_now.AutoSize = true;
            this.lb_filepath_now.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_filepath_now.Location = new System.Drawing.Point(12, 39);
            this.lb_filepath_now.Name = "lb_filepath_now";
            this.lb_filepath_now.Size = new System.Drawing.Size(202, 30);
            this.lb_filepath_now.TabIndex = 5;
            this.lb_filepath_now.Text = "Đường dẫn hiện tại:";
            // 
            // FM_tb_SAF
            // 
            this.FM_tb_SAF.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FM_tb_SAF.Location = new System.Drawing.Point(1202, 448);
            this.FM_tb_SAF.Name = "FM_tb_SAF";
            this.FM_tb_SAF.Size = new System.Drawing.Size(176, 86);
            this.FM_tb_SAF.TabIndex = 6;
            this.FM_tb_SAF.Text = "Lưu File ở";
            this.FM_tb_SAF.UseVisualStyleBackColor = true;
            this.FM_tb_SAF.Click += new System.EventHandler(this.FM_tb_SAF_Click);
            // 
            // FM_label_filepath_now
            // 
            this.FM_label_filepath_now.AutoSize = true;
            this.FM_label_filepath_now.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FM_label_filepath_now.Location = new System.Drawing.Point(228, 39);
            this.FM_label_filepath_now.Name = "FM_label_filepath_now";
            this.FM_label_filepath_now.Size = new System.Drawing.Size(0, 30);
            this.FM_label_filepath_now.TabIndex = 7;
            // 
            // FM_lb_filepath_now
            // 
            this.FM_lb_filepath_now.AutoSize = true;
            this.FM_lb_filepath_now.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FM_lb_filepath_now.Location = new System.Drawing.Point(234, 39);
            this.FM_lb_filepath_now.Name = "FM_lb_filepath_now";
            this.FM_lb_filepath_now.Size = new System.Drawing.Size(107, 30);
            this.FM_lb_filepath_now.TabIndex = 8;
            this.FM_lb_filepath_now.Text = "Undefine!";
            // 
            // FM_lb_userLogIn
            // 
            this.FM_lb_userLogIn.AutoSize = true;
            this.FM_lb_userLogIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FM_lb_userLogIn.ForeColor = System.Drawing.Color.Red;
            this.FM_lb_userLogIn.Location = new System.Drawing.Point(1202, 19);
            this.FM_lb_userLogIn.Name = "FM_lb_userLogIn";
            this.FM_lb_userLogIn.Size = new System.Drawing.Size(184, 30);
            this.FM_lb_userLogIn.TabIndex = 9;
            this.FM_lb_userLogIn.Text = "Chưa đăng nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 809);
            this.Controls.Add(this.FM_lb_userLogIn);
            this.Controls.Add(this.FM_lb_filepath_now);
            this.Controls.Add(this.FM_label_filepath_now);
            this.Controls.Add(this.FM_tb_SAF);
            this.Controls.Add(this.lb_filepath_now);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_OpenFile);
            this.Controls.Add(this.FM_richtext);
            this.Name = "Form1";
            this.Text = "Thao tác với tập tin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox FM_richtext;
        private Button bt_OpenFile;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label lb_filepath_now;
        private Button FM_tb_SAF;
        private Label FM_label_filepath_now;
        private Label FM_lb_filepath_now;
        private Label FM_lb_userLogIn;
    }
}