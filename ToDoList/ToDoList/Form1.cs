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
        Dictionary<string, object[]> completeList = new Dictionary<string, object[]>();
        public Form1()
        {
            InitializeComponent();
            try
            {
                FileStream fs = new FileStream("list.moscicki", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                completeList = (Dictionary<string, object[]>)bf.Deserialize(fs);
                toDoList.Items.AddRange(completeList[dateTimePicker1.Value.ToShortDateString()]);
                fs.Close();
            }
            catch {  }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            toDoList.Items.Add(textBoxNewTask.Text);

            FileStream fs = new FileStream("list.moscicki", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                completeList[dateTimePicker1.Value.ToShortDateString()] = new object[toDoList.Items.Count];
            }
            catch
            {
                completeList.Add(dateTimePicker1.Value.ToShortDateString(), new object[toDoList.Items.Count]);
            }
            toDoList.Items.CopyTo(completeList[dateTimePicker1.Value.ToShortDateString()], 0);
            bf.Serialize(fs, completeList);
            fs.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            toDoList.Items.Remove(toDoList.SelectedItem);

            FileStream fs = new FileStream("list.moscicki", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            completeList[dateTimePicker1.Value.ToShortDateString()] = new object[toDoList.Items.Count];
            toDoList.Items.CopyTo(completeList[dateTimePicker1.Value.ToShortDateString()], 0);
            bf.Serialize(fs, completeList);
            fs.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                toDoList.Items.Clear();
                toDoList.Items.AddRange(completeList[dateTimePicker1.Value.ToShortDateString()]);
            }
            catch (Exception exc)
            {
            }
        }
    }
}
