using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxAdress.Text != "" && textBoxPort.Text != "")
            {
                try
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(textBoxAdress.Text), int.Parse(textBoxPort.Text));

                    Socket socket = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        socket.Connect(ipEndPoint);

                        byte[] msg = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new Login(textBoxUsername.Text)));
                        int bytesSent = socket.Send(msg);

                        byte[] bytes = new byte[1024];
                        int bytesRec = socket.Receive(bytes);
                        int response = JsonSerializer.Deserialize<Response>(Encoding.UTF8.GetString(bytes, 0, bytesRec)).code;

                        if(response == 0)
                        {
                            FormChat formChat = new FormChat();
                            formChat.Text = textBoxUsername.Text;
                            formChat.socket = socket;
                            formChat.Show();
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
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected exception : " + ex.Message);
                }
            }
        }
    }
}
