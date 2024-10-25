using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyGame
{
    public partial class GameForm : Form
    {
        private Button button;

        public GameForm()
        {
            InitializeComponent();
            // Form sozlamalari
            this.Text = "O'yin Formasi";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tugma yaratish
            button = new Button();
            button.Text = "Meni bosing!";
            button.Size = new Size(150, 50);
            button.Location = new Point((this.ClientSize.Width - button.Width) / 2, (this.ClientSize.Height - button.Height) / 2);
            button.Click += Button_Click; // Tugma bosilganda chaqiriladigan hodisa

            // Tugmani formaga qo'shish
            Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siz tugmani bosdingiz!");
        }
    }
}