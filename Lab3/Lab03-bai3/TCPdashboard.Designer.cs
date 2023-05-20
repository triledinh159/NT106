namespace Lab03
{
    partial class TCPdashboard
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
            buttonServer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonServer.Location = new Point(215, 106);
            buttonServer.Name = "buttonServer";
            buttonServer.Size = new Size(347, 38);
            buttonServer.TabIndex = 0;
            buttonServer.Text = "Open TCP server";
            buttonServer.UseVisualStyleBackColor = true;
            buttonServer.Click += buttonServer_Click;
            // 
            // buttonClient
            // 
            buttonClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClient.Location = new Point(215, 201);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(347, 38);
            buttonClient.TabIndex = 1;
            buttonClient.Text = "Open TCP client";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // TCPdashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 450);
            Controls.Add(buttonClient);
            Controls.Add(buttonServer);
            Name = "TCPdashboard";
            Text = "TCP dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonServer;
        private Button buttonClient;
    }
}