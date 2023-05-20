namespace Lab03
{
    partial class UDPdashboard
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
            buttonServer = new Button();
            buttonClient = new Button();
            SuspendLayout();
            // 
            // buttonServer
            // 
            buttonServer.Location = new Point(157, 144);
            buttonServer.Name = "buttonServer";
            buttonServer.Size = new Size(130, 57);
            buttonServer.TabIndex = 0;
            buttonServer.Text = "UDP server";
            buttonServer.UseVisualStyleBackColor = true;
            buttonServer.Click += buttonServer_Click;
            // 
            // buttonClient
            // 
            buttonClient.Location = new Point(506, 144);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(130, 57);
            buttonClient.TabIndex = 1;
            buttonClient.Text = "UDP client";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // UDPdashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClient);
            Controls.Add(buttonServer);
            Name = "UDPdashboard";
            RightToLeft = RightToLeft.No;
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonServer;
        private Button buttonClient;
    }
}