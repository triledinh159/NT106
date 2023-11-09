namespace Lab04
{
    partial class POST
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
            this.label1 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // urlBox
            // 
            this.urlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.urlBox.Location = new System.Drawing.Point(15, 40);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(539, 24);
            this.urlBox.TabIndex = 1;
            // 
            // buttonPost
            // 
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPost.Location = new System.Drawing.Point(605, 40);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(123, 82);
            this.buttonPost.TabIndex = 2;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // dataBox
            // 
            this.dataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dataBox.Location = new System.Drawing.Point(15, 98);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(539, 24);
            this.dataBox.TabIndex = 4;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(15, 139);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(773, 299);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // POST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label1);
            this.Name = "POST";
            this.Text = "POST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}