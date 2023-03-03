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

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                FileStream fs = new FileStream("list.moscicki", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                var itemsInFile = (object[])bf.Deserialize(fs);
                toDoList.Items.AddRange(itemsInFile);
                fs.Close();
            }
            catch {  }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            toDoList.Items.Add(textBoxNewTask.Text);

            FileStream fs = new FileStream("list.moscicki", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            object[] listItems = new object[toDoList.Items.Count];
            toDoList.Items.CopyTo(listItems, 0);
            bf.Serialize(fs, listItems);
            fs.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            toDoList.Items.Remove(toDoList.SelectedItem);

            FileStream fs = new FileStream("list.moscicki", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            object[] listItems = new object[toDoList.Items.Count];
            toDoList.Items.CopyTo(listItems, 0);
            bf.Serialize(fs, listItems);
            fs.Close();
        }
    }
}
