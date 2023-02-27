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
using System.Text.Json;

namespace Chat
{
    public partial class FormChat : Form
    {
        public Socket socket;

        private Dictionary<string, List<string>> chat = new Dictionary<string, List<string>>(){ {"Public", new List<string>() } };
        private string target = "Public";

        public FormChat()
        {
            InitializeComponent();
        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            if(socket != null)
            {
                Task receiveData = new Task(ReceiveData);
                receiveData.Start();
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
                    chat.Add(user, new List<string>());
                }
            }
        }

        private void ReceiveData()
        {
            while (true)
            {
                try
                {
                    byte[] bytes = new byte[1024];
                    int bytesRec = socket.Receive(bytes);
                    Response response = JsonSerializer.Deserialize<Response>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if(response.code == 0)
                    {
                        if(response.message != null)
                        {
                            chat[response.isPrivate ? response.from : "Public"].Add(response.from + " -> " + response.message);
                            if (target == response.from && response.isPrivate)
                            {
                                richTextBox1.BeginInvoke(new Action(() => { richTextBox1.AppendText("\r\n" + response.from + " -> " + response.message); }));
                            }
                            else if (!response.isPrivate && target == "Public")
                            {
                                richTextBox1.BeginInvoke(new Action(() => { richTextBox1.AppendText("\r\n" + response.from + " -> " + response.message); }));
                            }
                        }
                    }
                    else if (response.code == 3)
                    {
                        Button button = new Button();
                        button.Text = response.from;
                        button.Size = new Size(222, 41);
                        button.Click += new EventHandler(buttonUser_Click);

                        flowLayoutPanel2.BeginInvoke((Action)(() => { flowLayoutPanel2.Controls.Add(button); }));
                        chat.Add(response.from, new List<string>());
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
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            target = ((Button)sender).Text;
            label1.Text = target;
            richTextBox1.Text = "";
            if (socket != null)
            {
                foreach (var msg in chat[target])
                {
                    richTextBox1.AppendText("\r\n" + msg);
                }
                richTextBox1.ScrollToCaret();
            }
            else
            {
                string response = "User1 -> XD\nUser2 -> XD\nUser1 -> XD2\nUser1 -> XD3\n";
                //chat = new List<string>();
                //chat.AddRange(response.Split('\n'));

                foreach(var msg in chat)
                {
                    richTextBox1.AppendText("\r\n" + msg);
                }
                richTextBox1.ScrollToCaret();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            chat[target].Add(this.Text + " -> " + textBoxMessage.Text);
            richTextBox1.AppendText("\r\n" + this.Text + " -> " + textBoxMessage.Text);
            richTextBox1.ScrollToCaret();
            if (socket != null)
            {
                try
                {
                    byte[] msg = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new Message(textBoxMessage.Text, target, target != "Public")));
                    int bytesSent = socket.Send(msg);
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
