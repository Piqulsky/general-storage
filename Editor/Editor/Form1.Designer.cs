namespace Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dodajButton = new System.Windows.Forms.Button();
            this.usunButton = new System.Windows.Forms.Button();
            this.czcionkaButton = new System.Windows.Forms.Button();
            this.kolorButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nowyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.otworzToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zapiszToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zapiszJakoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.wyjdzToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otworzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.wyjdzToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otworzToolStripMenuItem
            // 
            this.otworzToolStripMenuItem.Name = "otworzToolStripMenuItem";
            this.otworzToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.otworzToolStripMenuItem.Text = "Otwórz";
            this.otworzToolStripMenuItem.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // wyjdzToolStripMenuItem
            // 
            this.wyjdzToolStripMenuItem.Name = "wyjdzToolStripMenuItem";
            this.wyjdzToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.wyjdzToolStripMenuItem.Text = "Wyjdź";
            this.wyjdzToolStripMenuItem.Click += new System.EventHandler(this.wyjdzToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.9836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.98361F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 398);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(3, 39);
            this.richTextBox.Name = "richTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.richTextBox, 2);
            this.richTextBox.Size = new System.Drawing.Size(393, 356);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(402, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(402, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.dodajButton);
            this.flowLayoutPanel1.Controls.Add(this.usunButton);
            this.flowLayoutPanel1.Controls.Add(this.czcionkaButton);
            this.flowLayoutPanel1.Controls.Add(this.kolorButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(3, 3);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(125, 23);
            this.dodajButton.TabIndex = 0;
            this.dodajButton.Text = "Dodaj obraz";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(134, 3);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(125, 23);
            this.usunButton.TabIndex = 1;
            this.usunButton.Text = "Usuń obraz";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // czcionkaButton
            // 
            this.czcionkaButton.Location = new System.Drawing.Point(265, 3);
            this.czcionkaButton.Name = "czcionkaButton";
            this.czcionkaButton.Size = new System.Drawing.Size(125, 23);
            this.czcionkaButton.TabIndex = 2;
            this.czcionkaButton.Text = "Zmień czcionkę";
            this.czcionkaButton.UseVisualStyleBackColor = true;
            this.czcionkaButton.Click += new System.EventHandler(this.czcionkaButton_Click);
            // 
            // kolorButton
            // 
            this.kolorButton.Location = new System.Drawing.Point(396, 3);
            this.kolorButton.Name = "kolorButton";
            this.kolorButton.Size = new System.Drawing.Size(125, 23);
            this.kolorButton.TabIndex = 3;
            this.kolorButton.Text = "Zmień kolor";
            this.kolorButton.UseVisualStyleBackColor = true;
            this.kolorButton.Click += new System.EventHandler(this.kolorButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripButton,
            this.otworzToolStripButton,
            this.zapiszToolStripButton,
            this.zapiszJakoToolStripButton,
            this.wyjdzToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nowyToolStripButton
            // 
            this.nowyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nowyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nowyToolStripButton.Image")));
            this.nowyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nowyToolStripButton.Name = "nowyToolStripButton";
            this.nowyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nowyToolStripButton.Text = "Nowy";
            this.nowyToolStripButton.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otworzToolStripButton
            // 
            this.otworzToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otworzToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otworzToolStripButton.Image")));
            this.otworzToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otworzToolStripButton.Name = "otworzToolStripButton";
            this.otworzToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.otworzToolStripButton.Text = "Otwórz";
            this.otworzToolStripButton.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click);
            // 
            // zapiszToolStripButton
            // 
            this.zapiszToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zapiszToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zapiszToolStripButton.Image")));
            this.zapiszToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zapiszToolStripButton.Name = "zapiszToolStripButton";
            this.zapiszToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zapiszToolStripButton.Text = "Zapisz";
            this.zapiszToolStripButton.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripButton
            // 
            this.zapiszJakoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zapiszJakoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zapiszJakoToolStripButton.Image")));
            this.zapiszJakoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zapiszJakoToolStripButton.Name = "zapiszJakoToolStripButton";
            this.zapiszJakoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zapiszJakoToolStripButton.Text = "Zapisz jako...";
            this.zapiszJakoToolStripButton.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // wyjdzToolStripButton
            // 
            this.wyjdzToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wyjdzToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("wyjdzToolStripButton.Image")));
            this.wyjdzToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wyjdzToolStripButton.Name = "wyjdzToolStripButton";
            this.wyjdzToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.wyjdzToolStripButton.Text = "Wyjdź";
            this.wyjdzToolStripButton.Click += new System.EventHandler(this.wyjdzToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nowy Plik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem otworzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdzToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.Button czcionkaButton;
        private System.Windows.Forms.Button kolorButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nowyToolStripButton;
        private System.Windows.Forms.ToolStripButton otworzToolStripButton;
        private System.Windows.Forms.ToolStripButton zapiszToolStripButton;
        private System.Windows.Forms.ToolStripButton zapiszJakoToolStripButton;
        private System.Windows.Forms.ToolStripButton wyjdzToolStripButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

