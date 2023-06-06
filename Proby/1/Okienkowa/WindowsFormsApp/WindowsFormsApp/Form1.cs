using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Funkcja obsługuje naciśnięcie buttonAkceptuj
        private void buttonAkceptuj_Click(object sender, EventArgs e)
        {
            // Pobranie nazwy szkoły i dodanie Entera
            String name = textBoxNazwa.Text + "\n";
            // Pobranie adresu szkoły i dodanie Entera
            String adress = textBoxAdres.Text + "\n";
            String type = "";
            // Określenie typu szkoły na podstawie właściwości Checked od radioButton
            // RadioButton'y automatycznie się odznaczają, jeżeli są w tym samym groupBoxie!
            if(radioButtonLiceum.Checked)
                type= radioButtonLiceum.Text;
            if (radioButtonPodstawowa.Checked)
                type = radioButtonPodstawowa.Text;
            if (radioButtonTechnikum.Checked)
                type = radioButtonTechnikum.Text;
            // Wyświetlenie MessageBox - pierwszy agrument to tekst, drugi to tytuł
            MessageBox.Show(name + adress+ type, "Szkoła");
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            // Zamknięcie aplikacji
            Application.Exit();
        }
    }
}
