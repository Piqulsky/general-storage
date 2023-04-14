using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            Text = "Nowy Plik";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            richTextBox.Font = DefaultFont; 
            richTextBox.ForeColor = DefaultForeColor;
        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Text = openFileDialog1.FileName;
                BinaryFormatter bf = new BinaryFormatter();
                var fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                FormattedData data = (FormattedData) bf.Deserialize(fs);
                fs.Close();
                richTextBox.Text = data.text;
                richTextBox.Font = data.font;
                richTextBox.ForeColor = data.color;
                pictureBox1.Image = data.picture1;
                pictureBox2.Image = data.picture2;
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Text == "Nowy Plik")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Text = saveFileDialog1.FileName;
                    BinaryFormatter bf = new BinaryFormatter();
                    var fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    bf.Serialize(fs, new FormattedData(richTextBox.Text, pictureBox1.Image, pictureBox2.Image, richTextBox.Font, richTextBox.ForeColor));
                    fs.Close();
                }
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                var fs = new FileStream(Text, FileMode.Create);
                bf.Serialize(fs, new FormattedData(richTextBox.Text, pictureBox1.Image, pictureBox2.Image, richTextBox.Font, richTextBox.ForeColor));
                fs.Close();
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Text = saveFileDialog1.FileName;
                BinaryFormatter bf = new BinaryFormatter();
                var fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                bf.Serialize(fs, new FormattedData(richTextBox.Text, pictureBox1.Image, pictureBox2.Image, richTextBox.Font, richTextBox.ForeColor));
                fs.Close();
            }
        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.BorderStyle == BorderStyle.FixedSingle)
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                    pictureBox1.BorderStyle = BorderStyle.None;
                }
                else if (pictureBox2.BorderStyle == BorderStyle.FixedSingle)
                {
                    pictureBox2.Load(openFileDialog1.FileName);
                    pictureBox2.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            if(pictureBox1.BorderStyle == BorderStyle.FixedSingle)
            {
                pictureBox1.Image = null;
                pictureBox1.BorderStyle = BorderStyle.None;
            }
            else if(pictureBox2.BorderStyle == BorderStyle.FixedSingle)
            {
                pictureBox2.Image = null;
                pictureBox2.BorderStyle = BorderStyle.None;
            }
        }

        private void czcionkaButton_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = fontDialog1.Font;
            }
        }

        private void kolorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.ForeColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
    [System.Serializable]
    class FormattedData
    {
        public string text;
        public Image picture1;
        public Image picture2;
        public Font font;
        public Color color;
        public FormattedData(string text, Image picture1, Image picture2, Font font, Color color)
        {
            this.text = text;
            this.picture1 = picture1;
            this.picture2 = picture2;
            this.font = font;
            this.color = color;
        }
    }
}
