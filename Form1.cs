namespace GuinnessTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Start();
            UpdateInterface();
            UpdateTimerLabelSize();
        }

        private void UpdateInterface()
        {
            startButton.Enabled = !TimerController.IsRunning;
            stopButton.Enabled = TimerController.IsRunning && !InPasswordEnteringMode;
            resetButton.Enabled = !TimerController.IsRunning && TimerController.GetTimeElapsed() != TimeSpan.Zero;

            targetTextBox.Visible = !TimerController.IsRunning;
            targetLabel.Text = TimerController.IsRunning
                ? "Cel: " + TimeSpanToString(TimeTarget)
                : "Cel:";

            passwordPromptLabel.Visible = InPasswordEnteringMode;
            passwordTextBox.Visible = InPasswordEnteringMode;
            acceptPasswordButton.Visible = InPasswordEnteringMode;
            cancelPasswordButton.Visible = InPasswordEnteringMode;

            UpdatePasswordToStopState();
        }

        private void UpdatePasswordToStopState()
        {
            bool newNeedsPasswordToStop;
            if (!TimerController.IsRunning)
            {
                newNeedsPasswordToStop = false;
            }
            else
            {
                newNeedsPasswordToStop = TimerController.GetTimeElapsed() < TimeTarget;
            }

            if (NeedsPasswordToStop != newNeedsPasswordToStop)
            {
                NeedsPasswordToStop = newNeedsPasswordToStop;
                passwordLabel.Visible = NeedsPasswordToStop;
            }
        }

        private void UpdateTimerLabelSize()
        {
            try
            {
                clocksPanel.SuspendLayout();

                var fontFamily = valueLabel.Font.FontFamily;
                var fontSizeValue = Height / 6f;
                var fontSizeTime = Height / 10f;

                valueLabel.Height = (int)(clocksPanel.Height * (10 / 16f));
                timeLabel.Height = (int)(clocksPanel.Height * (6 / 16f));
                valueLabel.Width = timeLabel.Width = clocksPanel.Width;

                valueLabel.Font = new Font(fontFamily, fontSizeValue, FontStyle.Regular);
                timeLabel.Font = new Font(fontFamily, fontSizeTime, FontStyle.Regular);

                clocksPanel.ResumeLayout(false);
            }
            catch (Exception)
            {

            }
        }

        private string TimeSpanToString(TimeSpan span)
        {
            var hours = span.Hours + span.Days * 24;
            var minutes = span.Minutes;
            var seconds = span.Seconds;

            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void ParseAndSetTarget(string target)
        {
            var parts = target.Split(':').Reverse().ToArray();
            var seconds = int.Parse(parts[0]);
            var minutes = parts.Length >= 2 ? int.Parse(parts[1]) : 0;
            var hours = parts.Length >= 3 ? int.Parse(parts[2]) : 0;

            TimeTarget = new TimeSpan(hours, minutes, seconds);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                ParseAndSetTarget(targetTextBox.Text);
                TimerController.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wyst¹pi³ b³¹d", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UpdateInterface();

            try
            {
                SleepManager.PreventSleep();
                Text = "Stoper (blokuje wygaszanie ekranu)";
            }
            catch (Exception)
            {
                // Just don't terminate the app
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (NeedsPasswordToStop)
            {
                OnPasswordEntered = actuallyStop;
                InPasswordEnteringMode = true;
            }
            else
            {
                actuallyStop();
            }

            void actuallyStop()
            {
                TimerController.Stop();
                UpdateInterface();

                try
                {
                    SleepManager.StopPreventingSleep();
                    Text = "Stoper";
                }
                catch (Exception)
                {
                    // Just don't terminate the app
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            TimerController.Reset();
            UpdateInterface();
        }

        private void acceptPasswordButton_Click(object sender, EventArgs e)
        {
            var password = passwordTextBox.Text.ToUpper();
            passwordTextBox.Text = "";

            if (password == Password)
            {
                OnPasswordEntered?.Invoke();
                OnPasswordEntered = null;
            }
            InPasswordEnteringMode = false;
        }

        private void cancelPasswordButton_Click(object sender, EventArgs e)
        {
            InPasswordEnteringMode = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var value = TimerController.GetTimeElapsed();
            var valueString = TimeSpanToString(value);
            var currentTimeString = DateTime.Now.ToString("HH:mm");

            if (valueLabel.Text != valueString)
            {
                valueLabel.Text = valueString;
            }
            if (timeLabel.Text != currentTimeString)
            {
                timeLabel.Text = currentTimeString;
            }
            UpdatePasswordToStopState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = TimerController.IsRunning;

            if (!e.Cancel)
            {
                SleepManager.StopPreventingSleep();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            UpdateTimerLabelSize();
        }

        private void clocksPanel_Layout(object sender, LayoutEventArgs e)
        {
            UpdateTimerLabelSize();
        }

        private bool _InPasswordEnteringMode = false;
        private bool InPasswordEnteringMode
        {
            get => _InPasswordEnteringMode;
            set
            {
                _InPasswordEnteringMode = value;
                UpdateInterface();
            }
        }

        private TimerController TimerController = new TimerController();
        private TimeSpan TimeTarget = TimeSpan.Zero;
        private bool NeedsPasswordToStop = true;
        private Action? OnPasswordEntered = null;
        private const string Password = "GUINNESS";
    }
}