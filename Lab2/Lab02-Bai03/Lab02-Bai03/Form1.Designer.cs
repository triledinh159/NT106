namespace WinFormsApp1
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
            btn_read = new Button();
            showbox = new TextBox();
            btn_write = new Button();
            SuspendLayout();
            // 
            // btn_read
            // 
            btn_read.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_read.Location = new Point(49, 40);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(296, 60);
            btn_read.TabIndex = 0;
            btn_read.Text = "ĐỌC FILE";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // showbox
            // 
            showbox.Location = new Point(407, 40);
            showbox.Multiline = true;
            showbox.Name = "showbox";
            showbox.Size = new Size(320, 196);
            showbox.TabIndex = 1;
            // 
            // btn_write
            // 
            btn_write.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_write.Location = new Point(49, 176);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(296, 60);
            btn_write.TabIndex = 2;
            btn_write.Text = "GHI FILE";
            btn_write.UseVisualStyleBackColor = true;
            btn_write.Click += btn_write_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_write);
            Controls.Add(showbox);
            Controls.Add(btn_read);
            Name = "Form1";
            Text = "Lab02-Bai01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_read;
        private TextBox showbox;
        private Button btn_write;
    }
}