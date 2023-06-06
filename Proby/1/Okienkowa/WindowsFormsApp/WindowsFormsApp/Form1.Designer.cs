namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSzkola = new System.Windows.Forms.GroupBox();
            this.groupBoxRodzaj = new System.Windows.Forms.GroupBox();
            this.buttonAkceptuj = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.radioButtonPodstawowa = new System.Windows.Forms.RadioButton();
            this.labelNazwa = new System.Windows.Forms.Label();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.radioButtonLiceum = new System.Windows.Forms.RadioButton();
            this.radioButtonTechnikum = new System.Windows.Forms.RadioButton();
            this.groupBoxSzkola.SuspendLayout();
            this.groupBoxRodzaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSzkola
            // 
            this.groupBoxSzkola.Controls.Add(this.textBoxAdres);
            this.groupBoxSzkola.Controls.Add(this.labelAdres);
            this.groupBoxSzkola.Controls.Add(this.textBoxNazwa);
            this.groupBoxSzkola.Controls.Add(this.labelNazwa);
            this.groupBoxSzkola.Location = new System.Drawing.Point(160, 12);
            this.groupBoxSzkola.Name = "groupBoxSzkola";
            this.groupBoxSzkola.Size = new System.Drawing.Size(401, 168);
            this.groupBoxSzkola.TabIndex = 0;
            this.groupBoxSzkola.TabStop = false;
            this.groupBoxSzkola.Text = "Szkoła";
            // 
            // groupBoxRodzaj
            // 
            this.groupBoxRodzaj.Controls.Add(this.radioButtonTechnikum);
            this.groupBoxRodzaj.Controls.Add(this.radioButtonLiceum);
            this.groupBoxRodzaj.Controls.Add(this.radioButtonPodstawowa);
            this.groupBoxRodzaj.Location = new System.Drawing.Point(160, 186);
            this.groupBoxRodzaj.Name = "groupBoxRodzaj";
            this.groupBoxRodzaj.Size = new System.Drawing.Size(401, 168);
            this.groupBoxRodzaj.TabIndex = 1;
            this.groupBoxRodzaj.TabStop = false;
            this.groupBoxRodzaj.Text = "Rodzaj szkoły";
            // 
            // buttonAkceptuj
            // 
            this.buttonAkceptuj.Location = new System.Drawing.Point(160, 360);
            this.buttonAkceptuj.Name = "buttonAkceptuj";
            this.buttonAkceptuj.Size = new System.Drawing.Size(75, 23);
            this.buttonAkceptuj.TabIndex = 2;
            this.buttonAkceptuj.Text = "Akceptuj";
            this.buttonAkceptuj.UseVisualStyleBackColor = true;
            this.buttonAkceptuj.Click += new System.EventHandler(this.buttonAkceptuj_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(486, 360);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(75, 23);
            this.buttonZamknij.TabIndex = 3;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // radioButtonPodstawowa
            // 
            this.radioButtonPodstawowa.AutoSize = true;
            this.radioButtonPodstawowa.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPodstawowa.Name = "radioButtonPodstawowa";
            this.radioButtonPodstawowa.Size = new System.Drawing.Size(122, 17);
            this.radioButtonPodstawowa.TabIndex = 0;
            this.radioButtonPodstawowa.TabStop = true;
            this.radioButtonPodstawowa.Text = "Szkoła podstawowa";
            this.radioButtonPodstawowa.UseVisualStyleBackColor = true;
            // 
            // labelNazwa
            // 
            this.labelNazwa.AutoSize = true;
            this.labelNazwa.Location = new System.Drawing.Point(30, 43);
            this.labelNazwa.Name = "labelNazwa";
            this.labelNazwa.Size = new System.Drawing.Size(46, 13);
            this.labelNazwa.TabIndex = 1;
            this.labelNazwa.Text = "Nazwa: ";
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(82, 43);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(281, 20);
            this.textBoxNazwa.TabIndex = 2;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(82, 100);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(281, 20);
            this.textBoxAdres.TabIndex = 4;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(36, 100);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(40, 13);
            this.labelAdres.TabIndex = 3;
            this.labelAdres.Text = "Adres: ";
            // 
            // radioButtonLiceum
            // 
            this.radioButtonLiceum.AutoSize = true;
            this.radioButtonLiceum.Location = new System.Drawing.Point(6, 42);
            this.radioButtonLiceum.Name = "radioButtonLiceum";
            this.radioButtonLiceum.Size = new System.Drawing.Size(59, 17);
            this.radioButtonLiceum.TabIndex = 1;
            this.radioButtonLiceum.TabStop = true;
            this.radioButtonLiceum.Text = "Liceum";
            this.radioButtonLiceum.UseVisualStyleBackColor = true;
            // 
            // radioButtonTechnikum
            // 
            this.radioButtonTechnikum.AutoSize = true;
            this.radioButtonTechnikum.Location = new System.Drawing.Point(6, 65);
            this.radioButtonTechnikum.Name = "radioButtonTechnikum";
            this.radioButtonTechnikum.Size = new System.Drawing.Size(78, 17);
            this.radioButtonTechnikum.TabIndex = 2;
            this.radioButtonTechnikum.TabStop = true;
            this.radioButtonTechnikum.Text = "Technikum";
            this.radioButtonTechnikum.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonAkceptuj);
            this.Controls.Add(this.groupBoxRodzaj);
            this.Controls.Add(this.groupBoxSzkola);
            this.Name = "Form1";
            this.Text = "Wybór szkoły";
            this.groupBoxSzkola.ResumeLayout(false);
            this.groupBoxSzkola.PerformLayout();
            this.groupBoxRodzaj.ResumeLayout(false);
            this.groupBoxRodzaj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSzkola;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label labelNazwa;
        private System.Windows.Forms.GroupBox groupBoxRodzaj;
        private System.Windows.Forms.RadioButton radioButtonTechnikum;
        private System.Windows.Forms.RadioButton radioButtonLiceum;
        private System.Windows.Forms.RadioButton radioButtonPodstawowa;
        private System.Windows.Forms.Button buttonAkceptuj;
        private System.Windows.Forms.Button buttonZamknij;
    }
}

