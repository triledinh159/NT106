namespace Lab04_Bai01
{
    partial class Form1 : Form
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
            urlBox = new TextBox();
            buttonGet = new Button();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // urlBox
            // 
            urlBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            urlBox.Location = new Point(13, 28);
            urlBox.Margin = new Padding(3, 4, 3, 4);
            urlBox.Name = "urlBox";
            urlBox.Size = new Size(627, 24);
            urlBox.TabIndex = 0;
            // 
            // buttonGet
            // 
            buttonGet.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGet.Location = new Point(665, 15);
            buttonGet.Margin = new Padding(3, 4, 3, 4);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(108, 62);
            buttonGet.TabIndex = 1;
            buttonGet.Text = "Get";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 85);
            richTextBox.Margin = new Padding(3, 4, 3, 4);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(776, 462);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            richTextBox.TextChanged += richTextBox_TextChanged;
            // 
            // GET
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(richTextBox);
            Controls.Add(buttonGet);
            Controls.Add(urlBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GET";
            Text = "GET";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}