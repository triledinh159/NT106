namespace Lab03
{
    partial class TCPserver
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
            label2 = new Label();
            portBox = new TextBox();
            buttonListen = new Button();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 23);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // portBox
            // 
            portBox.Location = new Point(65, 20);
            portBox.Name = "portBox";
            portBox.Size = new Size(125, 27);
            portBox.TabIndex = 3;
            // 
            // buttonListen
            // 
            buttonListen.Location = new Point(210, 20);
            buttonListen.Name = "buttonListen";
            buttonListen.Size = new Size(94, 29);
            buttonListen.TabIndex = 4;
            buttonListen.Text = "Listen";
            buttonListen.UseVisualStyleBackColor = true;
            buttonListen.Click += buttonListen_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(14, 61);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(774, 377);
            richTextBox.TabIndex = 5;
            richTextBox.Text = "";
            // 
            // TCPserver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(buttonListen);
            Controls.Add(portBox);
            Controls.Add(label2);
            Name = "TCPserver";
            Text = "TCP server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox portBox;
        private Button buttonListen;
        private RichTextBox richTextBox;
    }
}