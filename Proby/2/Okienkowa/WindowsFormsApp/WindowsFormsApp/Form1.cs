using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Istotne do użycia klasy File
using System.IO;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        // Zmienna, która przechowa nam wygodnie lokalizacje pliku do zapisywania
        private string filename;
        public Form1()
        {
            // Żeby uzyskać wyświetlanie wyłącznie plików tekstowych w oknach dialogowych
            // wykorzystaj właściwość Filter i ustaw na: pliki tekstowe|*.txt
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Wyczyszczenie ścieżki do pliku, ponieważ tworzymy nowy
            filename = null;
            // Wyczyszczenie tekstu
            richTextBox1.Text = "";
            // "Wyczyszczenie" tekstu na belce okna
            Text = "Edytor tekstu";
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Otworzenie okna dialogowego do otwierania pliku
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Zapisanie ściezki pliku do zmiennej
                filename = openFileDialog.FileName;
                // Pamiętaj o użyciu System.IO w zależnościach
                // Odczytanie tekstu z pliku o wybranej ścieżce
                richTextBox1.Text = File.ReadAllText(filename);
                // Ustawienie tekstu na belce
                Text = filename;
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sprawdzamy, czy ten plik został już przez nas zapisany
            if (filename != null)
            {
                // Zapisanie tekstu do zapisanego już pliku
                File.WriteAllText(filename, richTextBox1.Text);
            }
            else
            {
                // Otworzenie okna dialogowego do zapisywania pliku
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Zapisanie ściezki pliku do zmiennej 
                    filename = saveFileDialog.FileName;
                    // Zapisanie tekstu do zapisanego już pliku
                    File.WriteAllText(filename, richTextBox1.Text);
                    // Ustawienie tekstu na belce
                    Text = filename;
                }
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Otworzenie okna dialogowego do zapisywania pliku
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Zapisanie ściezki pliku do zmiennej 
                filename = saveFileDialog.FileName;
                // Zapisanie tekstu do zapisanego już pliku
                File.WriteAllText(filename, richTextBox1.Text);
                // Ustawienie tekstu na belce
                Text = filename;
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Zamknięcie aplikacji
            Application.Exit();
        }
    }
}
