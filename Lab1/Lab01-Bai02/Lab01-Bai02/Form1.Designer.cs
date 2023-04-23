namespace Lab01_Bai02
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
            nhap09 = new Label();
            result = new Label();
            kqnhap09 = new TextBox();
            kqresult = new TextBox();
            read = new Button();
            quit = new Button();
            erase = new Button();
            SuspendLayout();
            // 
            // nhap09
            // 
            nhap09.AutoSize = true;
            nhap09.Location = new Point(56, 117);
            nhap09.Name = "nhap09";
            nhap09.Size = new Size(215, 20);
            nhap09.TabIndex = 0;
            nhap09.Text = "Nhập vào số nguyên từ 0 đến 9";
            nhap09.Click += nhap09_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(81, 271);
            result.Name = "result";
            result.Size = new Size(60, 20);
            result.TabIndex = 1;
            result.Text = "Kết quả";
            result.Click += result_Click;
            // 
            // kqnhap09
            // 
            kqnhap09.BorderStyle = BorderStyle.FixedSingle;
            kqnhap09.Location = new Point(277, 115);
            kqnhap09.Name = "kqnhap09";
            kqnhap09.Size = new Size(125, 27);
            kqnhap09.TabIndex = 2;
            kqnhap09.TextChanged += kqnhap09_TextChanged;
            // 
            // kqresult
            // 
            kqresult.BorderStyle = BorderStyle.FixedSingle;
            kqresult.Location = new Point(147, 258);
            kqresult.Multiline = true;
            kqresult.Name = "kqresult";
            kqresult.ScrollBars = ScrollBars.Horizontal;
            kqresult.Size = new Size(335, 53);
            kqresult.TabIndex = 3;
            kqresult.TextChanged += kqresult_TextChanged;
            // 
            // read
            // 
            read.Location = new Point(637, 64);
            read.Name = "read";
            read.Size = new Size(123, 54);
            read.TabIndex = 4;
            read.Text = "Đọc";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // quit
            // 
            quit.Location = new Point(637, 254);
            quit.Name = "quit";
            quit.Size = new Size(123, 54);
            quit.TabIndex = 6;
            quit.Text = "Thoát";
            quit.UseVisualStyleBackColor = true;
            quit.Click += quit_Click;
            // 
            // erase
            // 
            erase.Location = new Point(637, 159);
            erase.Name = "erase";
            erase.Size = new Size(123, 54);
            erase.TabIndex = 7;
            erase.Text = "Xóa";
            erase.UseVisualStyleBackColor = true;
            erase.Click += erase_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(erase);
            Controls.Add(quit);
            Controls.Add(read);
            Controls.Add(kqresult);
            Controls.Add(kqnhap09);
            Controls.Add(result);
            Controls.Add(nhap09);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nhap09;
        private Label result;
        private TextBox kqnhap09;
        private TextBox kqresult;
        private Button read;
        private Button quit;
        private Button erase;
    }
}