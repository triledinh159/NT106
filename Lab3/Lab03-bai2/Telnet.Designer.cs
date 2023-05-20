namespace Lab03
{
    partial class Telnet
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
            portBox = new TextBox();
            buttonListen = new Button();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(48, 28);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // portBox
            // 
            portBox.Location = new Point(81, 23);
            portBox.Name = "portBox";
            portBox.Size = new Size(125, 27);
            portBox.TabIndex = 1;
            // 
            // buttonListen
            // 
            buttonListen.Location = new Point(230, 21);
            buttonListen.Name = "buttonListen";
            buttonListen.Size = new Size(94, 29);
            buttonListen.TabIndex = 2;
            buttonListen.Text = "Listen";
            buttonListen.UseVisualStyleBackColor = true;
            buttonListen.Click += buttonListen_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(8, 61);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(780, 377);
            richTextBox.TabIndex = 3;
            richTextBox.Text = "";
            // 
            // Telnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(buttonListen);
            Controls.Add(portBox);
            Controls.Add(label1);
            Name = "Telnet";
            Text = "Telnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox portBox;
        private Button buttonListen;
        private RichTextBox richTextBox;
    }
}