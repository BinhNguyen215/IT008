namespace Lab1_1._5
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
            textBox = new TextBox();
            listView = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 12);
            textBox.Name = "textBox";
            textBox.Size = new Size(273, 27);
            textBox.TabIndex = 0;
            textBox.Text = "Enter the path here";
            textBox.KeyDown += textBox_KeyDown;
            // 
            // listView
            // 
            listView.Location = new Point(12, 45);
            listView.Name = "listView";
            listView.Size = new Size(324, 393);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.ItemActivate += listView_ItemActivate;
            // 
            // button1
            // 
            button1.Location = new Point(291, 11);
            button1.Name = "button1";
            button1.Size = new Size(45, 29);
            button1.TabIndex = 2;
            button1.Text = "find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(button1);
            Controls.Add(listView);
            Controls.Add(textBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private ListView listView;
        private Button button1;
    }
}