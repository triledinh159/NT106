namespace Lab03
{
    partial class TCPclient
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
            label1 = new Label();
            ipBox = new TextBox();
            lable2 = new Label();
            portBox = new TextBox();
            buttonConnect = new Button();
            buttonSend = new Button();
            buttonDisconnect = new Button();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // ipBox
            // 
            ipBox.Location = new Point(9, 41);
            ipBox.Name = "ipBox";
            ipBox.Size = new Size(150, 27);
            ipBox.TabIndex = 1;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lable2.Location = new Point(181, 9);
            lable2.Name = "lable2";
            lable2.Size = new Size(48, 28);
            lable2.TabIndex = 2;
            lable2.Text = "Port";
            // 
            // portBox
            // 
            portBox.Location = new Point(181, 41);
            portBox.Name = "portBox";
            portBox.Size = new Size(135, 27);
            portBox.TabIndex = 3;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(332, 24);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(115, 47);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(475, 24);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(115, 47);
            buttonSend.TabIndex = 5;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Location = new Point(611, 24);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(115, 44);
            buttonDisconnect.TabIndex = 6;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 86);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(776, 352);
            richTextBox.TabIndex = 7;
            richTextBox.Text = "";
            // 
            // TCPclient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(buttonDisconnect);
            Controls.Add(buttonSend);
            Controls.Add(buttonConnect);
            Controls.Add(portBox);
            Controls.Add(lable2);
            Controls.Add(ipBox);
            Controls.Add(label1);
            Name = "TCPclient";
            Text = "TCP client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ipBox;
        private Label lable2;
        private TextBox portBox;
        private Button buttonConnect;
        private Button buttonSend;
        private Button buttonDisconnect;
        private RichTextBox richTextBox;
    }
}