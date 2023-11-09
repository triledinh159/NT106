using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_RC
{
    public partial class screenServer : Form
    {
        private readonly int port;
        private TcpClient tcpClient;
        private TcpListener tcpServer;
        private NetworkStream ns;

        private readonly Thread Listening;
        private readonly Thread getImage;

        // Import the necessary DLLs
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        // Define the INPUT structure required for simulating input
        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public uint Type;
            public INPUTUNION Union;
        }

        [StructLayout(LayoutKind.Explicit)]
        struct INPUTUNION
        {
            [FieldOffset(0)]
            public MOUSEINPUT MouseInput;
            [FieldOffset(0)]
            public KEYBDINPUT KeyboardInput;
        }

        const int INPUT_MOUSE = 0;
        const int INPUT_KEYBOARD = 1;
        const int KEYEVENTF_KEYUP = 0x0002;
        const int MOUSEEVENTF_MOVE = 0x0001;
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;

        // Define the MOUSEINPUT structure required for simulating mouse input
        struct MOUSEINPUT
        {
            public int X;
            public int Y;
            public uint MouseData;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        // Define the KEYBDINPUT structure required for simulating keyboard input
        struct KEYBDINPUT
        {
            public ushort KeyCode;
            public ushort Scan;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        public screenServer(int Port)
        {
            port = Port;
            tcpClient = new TcpClient();
            Listening = new Thread(StartListening);
            getImage = new Thread(recImage);
            InitializeComponent();
        }

        private void StartListening()
        {
            try
            {
                while (!tcpClient.Connected)
                {
                    tcpServer.Start();
                    tcpClient = tcpServer.AcceptTcpClient();
                }
                getImage.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopListening()
        {
            try
            {
                tcpServer.Stop();
                tcpClient = null;
                if (Listening.IsAlive) Listening.Abort();
                if (getImage.IsAlive) getImage.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recImage()
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                while (tcpClient.Connected)
                {
                    NetworkStream ns = tcpClient.GetStream();
                    pictureBox1.Image = (Image)bf.Deserialize(ns);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SimulateMouseMove(int x, int y)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0] = new INPUT();
            inputs[0].Type = INPUT_MOUSE;
            inputs[0].Union.MouseInput.Flags = MOUSEEVENTF_MOVE;
            inputs[0].Union.MouseInput.X = x;
            inputs[0].Union.MouseInput.Y = y;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        private void SimulateMouseClick(int x, int y)
        {
            // Move the mouse cursor to the specified position
            SimulateMouseMove(x, y);

            // Simulate left mouse button down event
            INPUT[] inputsDown = new INPUT[1];
            inputsDown[0] = new INPUT();
            inputsDown[0].Type = INPUT_MOUSE;
            inputsDown[0].Union.MouseInput.Flags = MOUSEEVENTF_LEFTDOWN;

            SendInput((uint)inputsDown.Length, inputsDown, Marshal.SizeOf(typeof(INPUT)));

            // Simulate left mouse button up event
            INPUT[] inputsUp = new INPUT[1];
            inputsUp[0] = new INPUT();
            inputsUp[0].Type = INPUT_MOUSE;
            inputsUp[0].Union.MouseInput.Flags = MOUSEEVENTF_LEFTUP;

            SendInput((uint)inputsUp.Length, inputsUp, Marshal.SizeOf(typeof(INPUT)));
        }

        private void SimulateKeyDown(Keys key)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0] = new INPUT();
            inputs[0].Type = INPUT_KEYBOARD;
            inputs[0].Union.KeyboardInput.KeyCode = (ushort)key;
            inputs[0].Union.KeyboardInput.Flags = 0;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        private void SimulateKeyUp(Keys key)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0] = new INPUT();
            inputs[0].Type = INPUT_KEYBOARD;
            inputs[0].Union.KeyboardInput.KeyCode = (ushort)key;
            inputs[0].Union.KeyboardInput.Flags = KEYEVENTF_KEYUP;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the coordinates relative to the pictureBox1 control
            int x = e.X;
            int y = e.Y;

            // Simulate mouse movement
            SimulateMouseMove(x, y);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the coordinates relative to the pictureBox1 control
            int x = e.X;
            int y = e.Y;

            // Simulate mouse click
            SimulateMouseClick(x, y);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tcpServer = new TcpListener(IPAddress.Any, port);
            Listening.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
