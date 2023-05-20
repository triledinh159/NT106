namespace Lab03
{
    partial class UDPclient
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
            label2 = new Label();
            ipBox = new TextBox();
            portBox = new TextBox();
            label3 = new Label();
            richTextBox = new RichTextBox();
            buttonSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 0;
            label1.Text = "IP Remote host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(449, 26);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // ipBox
            // 
            ipBox.Location = new Point(31, 57);
            ipBox.Name = "ipBox";
            ipBox.Size = new Size(228, 27);
            ipBox.TabIndex = 2;
            // 
            // portBox
            // 
            portBox.Location = new Point(449, 57);
            portBox.Name = "portBox";
            portBox.Size = new Size(154, 27);
            portBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 101);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 4;
            label3.Text = "Message";
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 132);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(776, 261);
            richTextBox.TabIndex = 5;
            richTextBox.Text = "";
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSend.Location = new Point(12, 399);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(107, 41);
            buttonSend.TabIndex = 6;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // UDPclient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSend);
            Controls.Add(richTextBox);
            Controls.Add(label3);
            Controls.Add(portBox);
            Controls.Add(ipBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UDPclient";
            Text = "UDP client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ipBox;
        private TextBox portBox;
        private Label label3;
        private RichTextBox richTextBox;
        private Button buttonSend;
    }
}