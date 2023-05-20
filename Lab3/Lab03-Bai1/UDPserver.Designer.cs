namespace Lab03
{
    partial class UDPserver
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
            portBox = new TextBox();
            label1 = new Label();
            buttonListen = new Button();
            label2 = new Label();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // portBox
            // 
            portBox.Location = new Point(73, 40);
            portBox.Name = "portBox";
            portBox.Size = new Size(125, 27);
            portBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(48, 28);
            label1.TabIndex = 1;
            label1.Text = "Port";
            // 
            // buttonListen
            // 
            buttonListen.Location = new Point(239, 38);
            buttonListen.Name = "buttonListen";
            buttonListen.Size = new Size(94, 29);
            buttonListen.TabIndex = 2;
            buttonListen.Text = "Listen";
            buttonListen.UseVisualStyleBackColor = true;
            buttonListen.Click += buttonListen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "Received messages";
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 93);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(771, 345);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            // 
            // UDPserver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(label2);
            Controls.Add(buttonListen);
            Controls.Add(label1);
            Controls.Add(portBox);
            Name = "UDPserver";
            Text = "UDP server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox portBox;
        private Label label1;
        private Button buttonListen;
        private Label label2;
        private RichTextBox richTextBox;
    }
}