namespace BT
{
    partial class Form_PathFile
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
            this.FPF_tb_path = new System.Windows.Forms.TextBox();
            this.bt_xacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập đường dẫn file mà bạn yêu cầu";
            // 
            // FPF_tb_path
            // 
            this.FPF_tb_path.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FPF_tb_path.ForeColor = System.Drawing.Color.Black;
            this.FPF_tb_path.Location = new System.Drawing.Point(36, 70);
            this.FPF_tb_path.Name = "FPF_tb_path";
            this.FPF_tb_path.Size = new System.Drawing.Size(849, 42);
            this.FPF_tb_path.TabIndex = 1;
            this.FPF_tb_path.Text = "PathFile";
            this.FPF_tb_path.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.FPF_tb_path.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FPF_tb_path_KeyPress);
            // 
            // bt_xacnhan
            // 
            this.bt_xacnhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_xacnhan.Location = new System.Drawing.Point(715, 146);
            this.bt_xacnhan.Name = "bt_xacnhan";
            this.bt_xacnhan.Size = new System.Drawing.Size(170, 60);
            this.bt_xacnhan.TabIndex = 2;
            this.bt_xacnhan.Text = "Xác nhận";
            this.bt_xacnhan.UseVisualStyleBackColor = true;
            this.bt_xacnhan.Click += new System.EventHandler(this.bt_xacnhan_Click);
            // 
            // Form_PathFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 248);
            this.Controls.Add(this.bt_xacnhan);
            this.Controls.Add(this.FPF_tb_path);
            this.Controls.Add(this.label1);
            this.Name = "Form_PathFile";
            this.Text = "Nhập dường dẫn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox FPF_tb_path;
        private Button bt_xacnhan;
    }
}