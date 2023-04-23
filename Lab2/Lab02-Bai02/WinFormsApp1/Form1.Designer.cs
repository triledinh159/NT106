namespace WinFormsApp1
{
    partial class Lab02Bai02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            name = new TextBox();
            url = new TextBox();
            ctline = new TextBox();
            ctword = new TextBox();
            ctletter = new TextBox();
            read_box = new TextBox();
            SuspendLayout();
            // 
            // btn_read
            // 
            btn_read.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_read.Location = new Point(71, 54);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(191, 63);
            btn_read.TabIndex = 0;
            btn_read.Text = "ĐỌC FILE";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 140);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên file";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 198);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 2;
            label2.Text = "Url";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 258);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Số dòng";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(48, 314);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "Số từ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 375);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 5;
            label5.Text = "Số ký tự";
            // 
            // name
            // 
            name.Location = new Point(140, 137);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(172, 27);
            name.TabIndex = 6;
            name.TextChanged += name_TextChanged;
            // 
            // url
            // 
            url.Location = new Point(140, 195);
            url.Name = "url";
            url.ReadOnly = true;
            url.Size = new Size(172, 27);
            url.TabIndex = 7;
            // 
            // ctline
            // 
            ctline.Location = new Point(140, 255);
            ctline.Name = "ctline";
            ctline.ReadOnly = true;
            ctline.Size = new Size(172, 27);
            ctline.TabIndex = 8;
            // 
            // ctword
            // 
            ctword.Location = new Point(140, 311);
            ctword.Name = "ctword";
            ctword.ReadOnly = true;
            ctword.Size = new Size(172, 27);
            ctword.TabIndex = 9;
            // 
            // ctletter
            // 
            ctletter.Location = new Point(140, 372);
            ctletter.Name = "ctletter";
            ctletter.ReadOnly = true;
            ctletter.Size = new Size(172, 27);
            ctletter.TabIndex = 10;
            // 
            // read_box
            // 
            read_box.Location = new Point(388, 54);
            read_box.Multiline = true;
            read_box.Name = "read_box";
            read_box.Size = new Size(365, 345);
            read_box.TabIndex = 11;
            // 
            // Lab02Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(read_box);
            Controls.Add(ctletter);
            Controls.Add(ctword);
            Controls.Add(ctline);
            Controls.Add(url);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_read);
            Name = "Lab02Bai02";
            Text = "Lab02-Bai02";
            Load += Lab02Bai02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_read;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox name;
        private TextBox url;
        private TextBox ctline;
        private TextBox ctword;
        private TextBox ctletter;
        private TextBox read_box;
    }
}