using System;
using System.Windows.Forms;
using System.Drawing;

namespace ButtonClickGame
{
    public class GameForm : Form
    {
        private Button button;
        private Label scoreLabel;
        private Timer timer;
        private int score = 0;
        public GameForm()
        {
            button = new Button();
            button.Text = "Meni bosing!";
            button.Size = new Size(200, 100);
            button.Location = new Point(100, 100);
            button.Click += new EventHandler(Button_Click);

            scoreLabel = new Label();
            scoreLabel.Text = "Ball: 0";
            scoreLabel.Location = new Point(10, 10);
            scoreLabel.Size = new Size(100, 30);

            timer = new Timer();
            timer.Interval = 10000; // 10 soniya
            timer.Tick += new EventHandler(Timer_Tick);

            Controls.Add(button);
            Controls.Add(scoreLabel);
            this.Text = "Tugmani bos o'yini";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            timer.Start();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            score++;
            scoreLabel.Text = "Ball: " + score;
            Random rand = new Random();
            button.Location = new Point(rand.Next(0, this.ClientSize.Width - button.Width),
                rand.Next(0, this.ClientSize.Height - button.Height));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("O'yin tugadi! Sizning ballingiz: " + score);
            Application.Exit();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm());
        }
    }
}