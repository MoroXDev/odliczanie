namespace odliczanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
        }

        private void start_btn1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int minutes))
            {
                if (int.TryParse(textBox2.Text, out int seconds))
                {
                    if (minutes > 60 || seconds > 60)
                    {
                        MessageBox.Show("Wpisałeś ponad 60 minut lub ponad 60 sekund");
                        return;
                    }
                    if (minutes * 60 + seconds > 3600)
                    {
                        MessageBox.Show("Wpisany czas jest poza zakresem timera");
                        return;
                    }
                    seconds_time1 = minutes * 60 + seconds;
                    timer_label1.Text = TimeSpan.FromSeconds(seconds_time1).ToString(@"mm\:ss");
                    timer1.Start();
                }
                else
                    MessageBox.Show("Źle wpisałeś sekundy");
            }
            else
                MessageBox.Show("Źle wpisałeś minuty");
        }

        private void reset_btn1_Click(object sender, EventArgs e)
        {
            seconds_time1 = 0;
            timer_label1.Text = "00:00";
            timer1.Stop();
        }

        private void stop_btn1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void start_btn2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void stop_btn2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void reset_btn2_Click(object sender, EventArgs e)
        {
            seconds_time2 = 0;
            timer_label2.Text = "00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds_time1 > 0)
            {
                seconds_time1 -= 1;
                timer_label1.Text = TimeSpan.FromSeconds(seconds_time1).ToString(@"mm\:ss");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds_time2 += 1;
            timer_label2.Text = TimeSpan.FromSeconds(seconds_time2).ToString(@"mm\:ss");
        }
    }
}
