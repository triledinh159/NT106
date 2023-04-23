namespace Bai01
{
    partial class bai1
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
            process1 = new System.Diagnostics.Process();
            valuein3 = new TextBox();
            value1 = new Label();
            maxprint = new TextBox();
            find = new Button();
            erase = new Button();
            exit = new Button();
            max = new Label();
            min = new Label();
            valuein1 = new TextBox();
            valuein2 = new TextBox();
            minprint = new TextBox();
            value2 = new Label();
            value3 = new Label();
            SuspendLayout();
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // valuein3
            // 
            valuein3.BorderStyle = BorderStyle.FixedSingle;
            valuein3.Location = new Point(164, 188);
            valuein3.Name = "valuein3";
            valuein3.Size = new Size(125, 27);
            valuein3.TabIndex = 2;
            valuein3.TextChanged += valuein3_TextChanged;
            // 
            // value1
            // 
            value1.AutoSize = true;
            value1.Location = new Point(73, 70);
            value1.Name = "value1";
            value1.Size = new Size(85, 20);
            value1.TabIndex = 3;
            value1.Text = "Số thứ nhất";
            value1.Click += value1_Click;
            // 
            // maxprint
            // 
            maxprint.BorderStyle = BorderStyle.FixedSingle;
            maxprint.Enabled = false;
            maxprint.Location = new Point(164, 258);
            maxprint.Name = "maxprint";
            maxprint.Size = new Size(125, 27);
            maxprint.TabIndex = 6;
            maxprint.TextChanged += maxprint_TextChanged;
            // 
            // find
            // 
            find.FlatStyle = FlatStyle.Flat;
            find.Location = new Point(601, 54);
            find.Name = "find";
            find.Size = new Size(117, 36);
            find.TabIndex = 7;
            find.Text = "Tìm";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // erase
            // 
            erase.FlatStyle = FlatStyle.Flat;
            erase.Location = new Point(601, 116);
            erase.Name = "erase";
            erase.Size = new Size(117, 36);
            erase.TabIndex = 8;
            erase.Text = "Xóa";
            erase.UseVisualStyleBackColor = true;
            erase.Click += erase_Click;
            // 
            // exit
            // 
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(601, 185);
            exit.Name = "exit";
            exit.Size = new Size(117, 36);
            exit.TabIndex = 9;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // max
            // 
            max.AutoSize = true;
            max.Location = new Point(74, 260);
            max.Name = "max";
            max.Size = new Size(84, 20);
            max.TabIndex = 11;
            max.Text = "Số lớn nhất";
            max.Click += label1_Click_1;
            // 
            // min
            // 
            min.AutoSize = true;
            min.Location = new Point(359, 260);
            min.Name = "min";
            min.Size = new Size(88, 20);
            min.TabIndex = 12;
            min.Text = "Số nhỏ nhất";
            // 
            // valuein1
            // 
            valuein1.BorderStyle = BorderStyle.FixedSingle;
            valuein1.Location = new Point(164, 68);
            valuein1.Name = "valuein1";
            valuein1.Size = new Size(125, 27);
            valuein1.TabIndex = 13;
            valuein1.TextChanged += valuein1_TextChanged;
            // 
            // valuein2
            // 
            valuein2.BorderStyle = BorderStyle.FixedSingle;
            valuein2.Location = new Point(164, 125);
            valuein2.Name = "valuein2";
            valuein2.Size = new Size(125, 27);
            valuein2.TabIndex = 14;
            valuein2.TextChanged += valuein2_TextChanged;
            // 
            // minprint
            // 
            minprint.BorderStyle = BorderStyle.FixedSingle;
            minprint.Enabled = false;
            minprint.Location = new Point(453, 258);
            minprint.Name = "minprint";
            minprint.Size = new Size(125, 27);
            minprint.TabIndex = 15;
            minprint.TextChanged += minprint_TextChanged;
            // 
            // value2
            // 
            value2.AutoSize = true;
            value2.Location = new Point(82, 127);
            value2.Name = "value2";
            value2.Size = new Size(76, 20);
            value2.TabIndex = 16;
            value2.Text = "Số thứ hai";
            value2.Click += value2_Click;
            // 
            // value3
            // 
            value3.AutoSize = true;
            value3.Location = new Point(85, 190);
            value3.Name = "value3";
            value3.Size = new Size(73, 20);
            value3.TabIndex = 17;
            value3.Text = "Số thứ ba";
            value3.Click += value3_Click;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(value3);
            Controls.Add(value2);
            Controls.Add(minprint);
            Controls.Add(valuein2);
            Controls.Add(valuein1);
            Controls.Add(min);
            Controls.Add(max);
            Controls.Add(exit);
            Controls.Add(erase);
            Controls.Add(find);
            Controls.Add(maxprint);
            Controls.Add(value1);
            Controls.Add(valuein3);
            Name = "bai1";
            Text = "Lab01_Bai01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Diagnostics.Process process1;
        private TextBox valuein3;
        private Label value1;
        private Label max;
        private Button exit;
        private Button erase;
        private Button find;
        private TextBox maxprint;
        private Label min;
        private TextBox valuein1;
        private TextBox valuein2;
        private TextBox minprint;
        private Label value3;
        private Label value2;
    }
}