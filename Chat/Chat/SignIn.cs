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
                    IPHostEntry host = Dns.GetHostEntry(textBoxAdress.Text);
                    IPAddress ipAddress = host.AddressList[0];
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, int.Parse(textBoxPort.Text));

                    Socket socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        socket.Connect(remoteEP);

                        byte[] msg = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new Login(textBoxUsername.Text)));
                        int bytesSent = socket.Send(msg);

                        byte[] bytes = new byte[1024];
                        int bytesRec = socket.Receive(bytes);
                        string response = JsonSerializer.Deserialize<Login>(Encoding.UTF8.GetString(bytes, 0, bytesRec)).username;

                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();

                        if(response == "success")
                        {
                            FormChat formChat = new FormChat();
                            formChat.Text = textBoxUsername.Text;
                            formChat.serverAdress = textBoxAdress.Text;
                            formChat.port = int.Parse(textBoxPort.Text);
                            formChat.ShowDialog();
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
            else
            {
                FormChat formChat = new FormChat();
                formChat.Text = textBoxUsername.Text;
                formChat.ShowDialog();
            }
        }
    }
}
