namespace Server_RC
{
    partial class RemoteDesktop
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
            components = new System.ComponentModel.Container();
            btn_cnt = new Button();
            label1 = new Label();
            label2 = new Label();
            ip_ins = new TextBox();
            port_ins = new TextBox();
            btn_listen = new Button();
            btn_share = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_cnt
            // 
            btn_cnt.Location = new Point(94, 203);
            btn_cnt.Name = "btn_cnt";
            btn_cnt.Size = new Size(94, 29);
            btn_cnt.TabIndex = 0;
            btn_cnt.Text = "Connect";
            btn_cnt.UseVisualStyleBackColor = true;
            btn_cnt.Click += btn_cnt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 49);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "IP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 100);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Port (default: 9981)";
            // 
            // ip_ins
            // 
            ip_ins.Location = new Point(296, 42);
            ip_ins.Name = "ip_ins";
            ip_ins.Size = new Size(125, 27);
            ip_ins.TabIndex = 3;
            ip_ins.Text = "127.0.0.1";
            ip_ins.TextChanged += ip_ins_TextChanged;
            // 
            // port_ins
            // 
            port_ins.Location = new Point(296, 100);
            port_ins.Name = "port_ins";
            port_ins.Size = new Size(125, 27);
            port_ins.TabIndex = 4;
            port_ins.Text = "9981";
            port_ins.TextChanged += port_ins_TextChanged;
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(374, 203);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(94, 29);
            btn_listen.TabIndex = 5;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // btn_share
            // 
            btn_share.Location = new Point(233, 203);
            btn_share.Name = "btn_share";
            btn_share.Size = new Size(94, 29);
            btn_share.TabIndex = 6;
            btn_share.Text = "Share";
            btn_share.UseVisualStyleBackColor = true;
            btn_share.Click += btn_share_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // RemoteDesktop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_share);
            Controls.Add(btn_listen);
            Controls.Add(port_ins);
            Controls.Add(ip_ins);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_cnt);
            Name = "RemoteDesktop";
            Text = "RemoteDesktop";
            Load += RemoteDesktop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cnt;
        private Label label1;
        private Label label2;
        private TextBox ip_ins;
        private TextBox port_ins;
        private Button btn_listen;
        private Button btn_share;
        private System.Windows.Forms.Timer timer1;
    }
}