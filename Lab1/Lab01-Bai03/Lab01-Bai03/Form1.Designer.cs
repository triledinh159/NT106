namespace Lab01_Bai03
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
            cdtt = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            cvmon = new TextBox();
            mon = new TextBox();
            quydoi = new Label();
            combo = new ComboBox();
            combo2 = new ComboBox();
            del = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // cdtt
            // 
            cdtt.AutoSize = true;
            cdtt.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cdtt.Location = new Point(87, 35);
            cdtt.Name = "cdtt";
            cdtt.Size = new Size(233, 32);
            cdtt.TabIndex = 0;
            cdtt.Text = "Chuyển đổi tiền tệ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 98);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "Số tiền cần đổi";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 233);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Số tiền đã đổi";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 319);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 3;
            label3.Text = "Tỷ giá quy đổi";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(88, 152);
            button1.Name = "button1";
            button1.Size = new Size(281, 47);
            button1.TabIndex = 0;
            button1.Text = "Chuyển đổi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cvmon
            // 
            cvmon.BorderStyle = BorderStyle.FixedSingle;
            cvmon.Location = new Point(202, 231);
            cvmon.Name = "cvmon";
            cvmon.Size = new Size(167, 27);
            cvmon.TabIndex = 5;
            cvmon.TextChanged += cvmon_TextChanged;
            // 
            // mon
            // 
            mon.BorderStyle = BorderStyle.FixedSingle;
            mon.Location = new Point(202, 91);
            mon.Name = "mon";
            mon.Size = new Size(167, 27);
            mon.TabIndex = 6;
            mon.TextChanged += mon_TextChanged;
            // 
            // quydoi
            // 
            quydoi.AutoSize = true;
            quydoi.Location = new Point(202, 319);
            quydoi.Name = "quydoi";
            quydoi.Size = new Size(0, 20);
            quydoi.TabIndex = 9;
            quydoi.Click += quydoi_Click;
            // 
            // combo
            // 
            combo.FormattingEnabled = true;
            combo.Location = new Point(449, 90);
            combo.Name = "combo";
            combo.Size = new Size(198, 28);
            combo.TabIndex = 7;
            combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            // 
            // combo2
            // 
            combo2.FormattingEnabled = true;
            combo2.Location = new Point(449, 230);
            combo2.Name = "combo2";
            combo2.Size = new Size(198, 28);
            combo2.TabIndex = 10;
            combo2.SelectedIndexChanged += combo2_SelectedIndexChanged;
            // 
            // del
            // 
            del.FlatStyle = FlatStyle.Popup;
            del.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            del.Location = new Point(449, 152);
            del.Name = "del";
            del.Size = new Size(198, 47);
            del.TabIndex = 11;
            del.Text = "Xóa";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // exit
            // 
            exit.FlatStyle = FlatStyle.Popup;
            exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            exit.Location = new Point(449, 304);
            exit.Name = "exit";
            exit.Size = new Size(198, 47);
            exit.TabIndex = 12;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(del);
            Controls.Add(combo2);
            Controls.Add(quydoi);
            Controls.Add(combo);
            Controls.Add(mon);
            Controls.Add(cvmon);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cdtt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cdtt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox cvmon;
        private TextBox mon;
        private Label quydoi;
        private ComboBox combo;
        private ComboBox combo2;
        private Button del;
        private Button exit;
    }
}