using System;
using System.Windows.Forms;

namespace ThargoidsTimer
{
    partial class OverlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.enrageLabel = new System.Windows.Forms.Label();
            this.enrageTimerLabel = new System.Windows.Forms.Label();
            this.shieldTimerLabel = new System.Windows.Forms.Label();
            this.shieldLabel = new System.Windows.Forms.Label();
            this.enrageTimer = new System.Windows.Forms.Timer(this.components);
            this.shieldTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.startButton = new ThargoidsTimer.EliteButton();
            this.exitButton = new ThargoidsTimer.EliteButton();
            this.stopButton = new ThargoidsTimer.EliteButton();
            this.configButton = new ThargoidsTimer.EliteButton();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enrageLabel
            // 
            this.enrageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.enrageLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.enrageLabel.Location = new System.Drawing.Point(12, 15);
            this.enrageLabel.Name = "enrageLabel";
            this.enrageLabel.Size = new System.Drawing.Size(115, 30);
            this.enrageLabel.TabIndex = 0;
            this.enrageLabel.Text = "ENRAGE";
            this.enrageLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseDown);
            this.enrageLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseMove);
            this.enrageLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseUp);
            // 
            // enrageTimerLabel
            // 
            this.enrageTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.enrageTimerLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.enrageTimerLabel.Location = new System.Drawing.Point(125, 5);
            this.enrageTimerLabel.Name = "enrageTimerLabel";
            this.enrageTimerLabel.Size = new System.Drawing.Size(120, 40);
            this.enrageTimerLabel.TabIndex = 1;
            this.enrageTimerLabel.Text = "00:00";
            this.enrageTimerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.enrageTimerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseDown);
            this.enrageTimerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseMove);
            this.enrageTimerLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseUp);
            // 
            // shieldTimerLabel
            // 
            this.shieldTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.shieldTimerLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.shieldTimerLabel.Location = new System.Drawing.Point(244, 5);
            this.shieldTimerLabel.Name = "shieldTimerLabel";
            this.shieldTimerLabel.Size = new System.Drawing.Size(120, 40);
            this.shieldTimerLabel.TabIndex = 2;
            this.shieldTimerLabel.Text = "00:00";
            this.shieldTimerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.shieldTimerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseDown);
            this.shieldTimerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseMove);
            this.shieldTimerLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseUp);
            // 
            // shieldLabel
            // 
            this.shieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.shieldLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.shieldLabel.Location = new System.Drawing.Point(362, 15);
            this.shieldLabel.Name = "shieldLabel";
            this.shieldLabel.Size = new System.Drawing.Size(100, 30);
            this.shieldLabel.TabIndex = 3;
            this.shieldLabel.Text = "SHIELD";
            this.shieldLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.shieldLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseDown);
            this.shieldLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseMove);
            this.shieldLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseUp);
            // 
            // enrageTimer
            // 
            this.enrageTimer.Interval = 1000;
            this.enrageTimer.Tick += new System.EventHandler(this.EnrageTimer_Tick);
            // 
            // shieldTimer
            // 
            this.shieldTimer.Interval = 1000;
            this.shieldTimer.Tick += new System.EventHandler(this.ShieldTimer_Tick);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.startButton);
            this.buttonPanel.Controls.Add(this.exitButton);
            this.buttonPanel.Controls.Add(this.stopButton);
            this.buttonPanel.Controls.Add(this.configButton);
            this.buttonPanel.Location = new System.Drawing.Point(12, 54);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(455, 54);
            this.buttonPanel.TabIndex = 8;
            this.buttonPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseDown);
            this.buttonPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseMove);
            this.buttonPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseUp);
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = global::ThargoidsTimer.Properties.Resources.PlayOrange;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.startButton.FlatAppearance.BorderSize = 4;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.startButton.Location = new System.Drawing.Point(6, 7);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 40);
            this.startButton.TabIndex = 7;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.MouseEnter += new System.EventHandler(this.PlayButton_MouseEnter);
            this.startButton.MouseLeave += new System.EventHandler(this.PlayButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.exitButton.FlatAppearance.BorderSize = 4;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.exitButton.Location = new System.Drawing.Point(325, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = global::ThargoidsTimer.Properties.Resources.StopOrange;
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.stopButton.FlatAppearance.BorderSize = 4;
            this.stopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.stopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.stopButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.stopButton.Location = new System.Drawing.Point(101, 7);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(88, 40);
            this.stopButton.TabIndex = 6;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            this.stopButton.MouseEnter += new System.EventHandler(this.StopButton_MouseEnter);
            this.stopButton.MouseLeave += new System.EventHandler(this.StopButton_MouseLeave);
            // 
            // configButton
            // 
            this.configButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.configButton.FlatAppearance.BorderSize = 4;
            this.configButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.configButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.configButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.configButton.Location = new System.Drawing.Point(196, 7);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(122, 40);
            this.configButton.TabIndex = 4;
            this.configButton.Text = "CONFIG";
            this.configButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(474, 114);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.enrageLabel);
            this.Controls.Add(this.enrageTimerLabel);
            this.Controls.Add(this.shieldTimerLabel);
            this.Controls.Add(this.shieldLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverlayForm";
            this.TopMost = true;
            this.TransparencyKey = this.BackColor;
            this.Activated += new System.EventHandler(this.OverlayForm_GotFocus);
            this.Deactivate += new System.EventHandler(this.OverlayForm_LostFocus);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OverlayForm_MouseUp);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label enrageLabel;
        private Label enrageTimerLabel;
        private Label shieldTimerLabel;
        private Label shieldLabel;
        private EliteButton configButton;
        private EliteButton exitButton;

        private Timer enrageTimer;
        private TimeSpan enrageTimeSpan;
        private Timer shieldTimer;
        private TimeSpan shieldTimeSpan;
        private EliteButton stopButton;
        private EliteButton startButton;
        private Panel buttonPanel;
    }
}

