using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThargoidsTimer
{
    public partial class OverlayForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;



        public OverlayForm()
        {
            InitializeComponent();
            EnrageTimer_Set(Program.currentVariant.EnrageSeconds);
            ShieldTimer_Set(Program.currentVariant.ShieldSeconds);
        }

        public void EnrageTimer_Set(int seconds)
        {
            enrageTimeSpan = new TimeSpan(0, 0, seconds);
            enrageTimerLabel.Text = $"{enrageTimeSpan.Minutes.ToString("D2")}:{enrageTimeSpan.Seconds.ToString("D2")}";
            enrageTimer.Stop();
        }

        public void ShieldTimer_Set(int seconds)
        {
            shieldTimeSpan = new TimeSpan(0, 0, seconds);
            shieldTimerLabel.Text = $"{shieldTimeSpan.Minutes.ToString("D2")}:{shieldTimeSpan.Seconds.ToString("D2")}";
            shieldTimer.Stop();
        }

        public void Timers_Start()
        {
            EnrageTimer_Set(Program.currentVariant.EnrageSeconds);
            ShieldTimer_Set(Program.currentVariant.ShieldSeconds);
            enrageTimer.Start();
            shieldTimer.Start();
        }

        public void Timers_Stop()
        {
            EnrageTimer_Set(Program.currentVariant.EnrageSeconds);
            ShieldTimer_Set(Program.currentVariant.ShieldSeconds);
        }

        private void EnrageTimer_Tick(object sender, EventArgs e)
        {
            if(enrageTimeSpan.TotalSeconds <= 0)
            {
                enrageTimer.Stop();
                return;
            }
            enrageTimeSpan = enrageTimeSpan.Subtract(new TimeSpan(0, 0, 1));
            enrageTimerLabel.Text = $"{enrageTimeSpan.Minutes.ToString("D2")}:{enrageTimeSpan.Seconds.ToString("D2")}";
        }

        private void ShieldTimer_Tick(object sender, EventArgs e)
        {
            if (shieldTimeSpan.TotalSeconds <= 0)
            {
                shieldTimer.Stop();
                return;
            }
            shieldTimeSpan = shieldTimeSpan.Subtract(new TimeSpan(0, 0, 1));
            shieldTimerLabel.Text = $"{shieldTimeSpan.Minutes.ToString("D2")}:{shieldTimeSpan.Seconds.ToString("D2")}";
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            Program.configForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OverlayForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void OverlayForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void OverlayForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void OverlayForm_GotFocus(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;
        }

        private void OverlayForm_LostFocus(object sender, EventArgs e)
        {
            buttonPanel.Visible = false;
        }

        private void PlayButton_MouseEnter(object sender, EventArgs e)
        {
            startButton.BackgroundImage = Properties.Resources.PlayBlack;
        }

        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.BackgroundImage = Properties.Resources.PlayOrange;
        }

        private void StopButton_MouseEnter(object sender, EventArgs e)
        {
            stopButton.BackgroundImage = Properties.Resources.StopBlack;
        }

        private void StopButton_MouseLeave(object sender, EventArgs e)
        {
            stopButton.BackgroundImage = Properties.Resources.StopOrange;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Timers_Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Timers_Stop();
        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }
    }
}
