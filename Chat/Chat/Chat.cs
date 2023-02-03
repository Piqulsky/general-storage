using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class FormChat : Form
    {
        public string serverAdress;
        public int port;

        private IPHostEntry host;
        private IPAddress ipAddress;
        private IPEndPoint remoteEP;
        private Socket socket;

        private List<string> chat;

        public FormChat()
        {
            InitializeComponent();
        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            if(serverAdress != null && port != 0)
            {
                try
                {
                    host = Dns.GetHostEntry(serverAdress);
                    ipAddress = host.AddressList[0];
                    remoteEP = new IPEndPoint(ipAddress, port);

                    socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        socket.Connect(remoteEP);

                        byte[] msg = Encoding.UTF8.GetBytes("Get users: " + Text);
                        int bytesSent = socket.Send(msg);

                        byte[] bytes = new byte[1024];
                        int bytesRec = socket.Receive(bytes);
                        string response = Encoding.UTF8.GetString(bytes, 0, bytesRec);

                        // socket.Shutdown(SocketShutdown.Both);
                        // socket.Close();
                    }
                    catch (ArgumentNullException ex)
                    {
                        MessageBox.Show("ArgumentNullException : " + ex.Message);
                    }
                    catch (SocketException ex)
                    {
                        MessageBox.Show("SocketException : " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected exception : " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected exception : " + ex.Message);
                }
            }
            else
            {
                string response = "test user 1;test user 2;test user3";
                string[] users = response.Split(';');
                foreach(var user in users)
                {
                    Button button = new Button();
                    button.Text = user;
                    button.Size = new Size(222, 41);
                    button.Click += new EventHandler(buttonUser_Click);

                    flowLayoutPanel2.Controls.Add(button);
                }
            }
        }

        private void ReceiveMessage(string user)
        {
            if (host != null && remoteEP != null && socket != null)
            {
                try
                {
                    while (true)
                    {
                        byte[] bytes = new byte[1024];
                        int bytesRec = socket.Receive(bytes);
                        string response = Encoding.UTF8.GetString(bytes, 0, bytesRec);

                        chat = new List<string>();
                        chat.AddRange(response.Split('\n'));
                    }
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("ArgumentNullException : " + ex.Message);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("SocketException : " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected exception : " + ex.Message);
                }
            }
            else
            {
                // Test
                // Test
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            label1.Text = ((Button)sender).Text;
            richTextBox1.Text = "";
            if (host != null && remoteEP != null && socket != null)
            {
                try
                {
                    byte[] msg = Encoding.UTF8.GetBytes("Get messages: " + Text + " " + ((Button)sender).Text);
                    int bytesSent = socket.Send(msg);

                    byte[] bytes = new byte[1024];
                    int bytesRec = socket.Receive(bytes);
                    string response = Encoding.UTF8.GetString(bytes, 0, bytesRec);

                    chat = new List<string>();
                    chat.AddRange(response.Split('\n'));
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("ArgumentNullException : " + ex.Message);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("SocketException : " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected exception : " + ex.Message);
                }
            }
            else
            {
                string response = "[01.02.2023 08:12:03] User1 -> XD\n[01.02.2023 08:12:03] User2 -> XD\n[01.02.2023 08:12:03] User1 -> XD2\n[01.02.2023 08:12:03] User1 -> XD3\n";
                chat = new List<string>();
                chat.AddRange(response.Split('\n'));

                foreach(var msg in chat)
                {
                    richTextBox1.AppendText("\r\n" + msg);
                }
                richTextBox1.ScrollToCaret();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            chat.Add(textBoxMessage.Text);
            richTextBox1.AppendText("\r\n" + textBoxMessage.Text);
            richTextBox1.ScrollToCaret();
            if (host != null && remoteEP != null && socket != null)
            {
                try
                {
                    byte[] msg = Encoding.UTF8.GetBytes("Send message: " + Text + " " + label1.Text + " " + textBoxMessage.Text);
                    int bytesSent = socket.Send(msg);

                    byte[] bytes = new byte[1024];
                    int bytesRec = socket.Receive(bytes);
                    string response = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("ArgumentNullException : " + ex.Message);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("SocketException : " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected exception : " + ex.Message);
                }
            }
        }
    }
}
