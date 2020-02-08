namespace ThargoidsTimer
{
    partial class ConfigForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.StopTimerKeybindButton = new ThargoidsTimer.EliteButton();
            this.StartTimerKeybindButton = new ThargoidsTimer.EliteButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeybindLabel = new System.Windows.Forms.Label();
            this.closeButton = new ThargoidsTimer.EliteButton();
            this.hydraVariantRadioButton = new ThargoidsTimer.ConfigForm.VariantRadioButton();
            this.medusaVariantRadioButton = new ThargoidsTimer.ConfigForm.VariantRadioButton();
            this.basiliskVariantRadioButton = new ThargoidsTimer.ConfigForm.VariantRadioButton();
            this.cyclopsVariantRadioButton = new ThargoidsTimer.ConfigForm.VariantRadioButton();
            this.variantLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.versionLabel);
            this.panel1.Controls.Add(this.StopTimerKeybindButton);
            this.panel1.Controls.Add(this.StartTimerKeybindButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.KeybindLabel);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.hydraVariantRadioButton);
            this.panel1.Controls.Add(this.medusaVariantRadioButton);
            this.panel1.Controls.Add(this.basiliskVariantRadioButton);
            this.panel1.Controls.Add(this.cyclopsVariantRadioButton);
            this.panel1.Controls.Add(this.variantLabel);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 366);
            this.panel1.TabIndex = 0;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.versionLabel.Location = new System.Drawing.Point(3, 342);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(57, 20);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "v1.0.1";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StopTimerKeybindButton
            // 
            this.StopTimerKeybindButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.StopTimerKeybindButton.FlatAppearance.BorderSize = 4;
            this.StopTimerKeybindButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.StopTimerKeybindButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.StopTimerKeybindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopTimerKeybindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StopTimerKeybindButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.StopTimerKeybindButton.Location = new System.Drawing.Point(312, 241);
            this.StopTimerKeybindButton.Name = "StopTimerKeybindButton";
            this.StopTimerKeybindButton.Size = new System.Drawing.Size(190, 40);
            this.StopTimerKeybindButton.TabIndex = 11;
            this.StopTimerKeybindButton.Text = "Press a key...";
            this.StopTimerKeybindButton.Click += new System.EventHandler(this.StopTimerKeybindButton_Click);
            // 
            // StartTimerKeybindButton
            // 
            this.StartTimerKeybindButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.StartTimerKeybindButton.FlatAppearance.BorderSize = 4;
            this.StartTimerKeybindButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.StartTimerKeybindButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.StartTimerKeybindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTimerKeybindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StartTimerKeybindButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.StartTimerKeybindButton.Location = new System.Drawing.Point(312, 125);
            this.StartTimerKeybindButton.Name = "StartTimerKeybindButton";
            this.StartTimerKeybindButton.Size = new System.Drawing.Size(190, 40);
            this.StartTimerKeybindButton.TabIndex = 10;
            this.StartTimerKeybindButton.Text = "Press a key...";
            this.StartTimerKeybindButton.Click += new System.EventHandler(this.StartTimerKeybindButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(351, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "STOP TIMER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(345, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "START TIMER";
            // 
            // KeybindLabel
            // 
            this.KeybindLabel.AutoSize = true;
            this.KeybindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.KeybindLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.KeybindLabel.Location = new System.Drawing.Point(319, 23);
            this.KeybindLabel.Name = "KeybindLabel";
            this.KeybindLabel.Size = new System.Drawing.Size(183, 26);
            this.KeybindLabel.TabIndex = 7;
            this.KeybindLabel.Text = "KEY BINDINGS";
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.closeButton.FlatAppearance.BorderSize = 4;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.closeButton.Location = new System.Drawing.Point(177, 303);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(190, 40);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "CLOSE";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // hydraVariantRadioButton
            // 
            this.hydraVariantRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hydraVariantRadioButton.BackColor = System.Drawing.Color.Black;
            this.hydraVariantRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.hydraVariantRadioButton.FlatAppearance.BorderSize = 4;
            this.hydraVariantRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.hydraVariantRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.hydraVariantRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.hydraVariantRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hydraVariantRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hydraVariantRadioButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.hydraVariantRadioButton.Location = new System.Drawing.Point(33, 241);
            this.hydraVariantRadioButton.Name = "hydraVariantRadioButton";
            this.hydraVariantRadioButton.Size = new System.Drawing.Size(200, 40);
            this.hydraVariantRadioButton.TabIndex = 4;
            this.hydraVariantRadioButton.Text = "HYDRA";
            this.hydraVariantRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hydraVariantRadioButton.UseVisualStyleBackColor = false;
            this.hydraVariantRadioButton.CheckedChanged += new System.EventHandler(this.hydraVariantRadioButton_CheckedChanged);
            // 
            // medusaVariantRadioButton
            // 
            this.medusaVariantRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.medusaVariantRadioButton.BackColor = System.Drawing.Color.Black;
            this.medusaVariantRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.medusaVariantRadioButton.FlatAppearance.BorderSize = 4;
            this.medusaVariantRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.medusaVariantRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.medusaVariantRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.medusaVariantRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medusaVariantRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medusaVariantRadioButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.medusaVariantRadioButton.Location = new System.Drawing.Point(33, 183);
            this.medusaVariantRadioButton.Name = "medusaVariantRadioButton";
            this.medusaVariantRadioButton.Size = new System.Drawing.Size(200, 40);
            this.medusaVariantRadioButton.TabIndex = 3;
            this.medusaVariantRadioButton.Text = "MEDUSA";
            this.medusaVariantRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.medusaVariantRadioButton.UseVisualStyleBackColor = false;
            this.medusaVariantRadioButton.CheckedChanged += new System.EventHandler(this.medusaVariantRadioButton_CheckedChanged);
            // 
            // basiliskVariantRadioButton
            // 
            this.basiliskVariantRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.basiliskVariantRadioButton.BackColor = System.Drawing.Color.Black;
            this.basiliskVariantRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.basiliskVariantRadioButton.FlatAppearance.BorderSize = 4;
            this.basiliskVariantRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.basiliskVariantRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.basiliskVariantRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.basiliskVariantRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basiliskVariantRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basiliskVariantRadioButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.basiliskVariantRadioButton.Location = new System.Drawing.Point(33, 125);
            this.basiliskVariantRadioButton.Name = "basiliskVariantRadioButton";
            this.basiliskVariantRadioButton.Size = new System.Drawing.Size(200, 40);
            this.basiliskVariantRadioButton.TabIndex = 2;
            this.basiliskVariantRadioButton.Text = "BASILISK";
            this.basiliskVariantRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.basiliskVariantRadioButton.UseVisualStyleBackColor = false;
            this.basiliskVariantRadioButton.CheckedChanged += new System.EventHandler(this.basiliskVariantRadioButton_CheckedChanged);
            // 
            // cyclopsVariantRadioButton
            // 
            this.cyclopsVariantRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cyclopsVariantRadioButton.BackColor = System.Drawing.Color.Black;
            this.cyclopsVariantRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.cyclopsVariantRadioButton.FlatAppearance.BorderSize = 4;
            this.cyclopsVariantRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.cyclopsVariantRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.cyclopsVariantRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.cyclopsVariantRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cyclopsVariantRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyclopsVariantRadioButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.cyclopsVariantRadioButton.Location = new System.Drawing.Point(33, 67);
            this.cyclopsVariantRadioButton.Name = "cyclopsVariantRadioButton";
            this.cyclopsVariantRadioButton.Size = new System.Drawing.Size(200, 40);
            this.cyclopsVariantRadioButton.TabIndex = 1;
            this.cyclopsVariantRadioButton.Text = "CYCLOPS";
            this.cyclopsVariantRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cyclopsVariantRadioButton.UseVisualStyleBackColor = false;
            this.cyclopsVariantRadioButton.CheckedChanged += new System.EventHandler(this.cyclopsVariantRadioButton_CheckedChanged);
            // 
            // variantLabel
            // 
            this.variantLabel.AutoSize = true;
            this.variantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.variantLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.variantLabel.Location = new System.Drawing.Point(74, 23);
            this.variantLabel.Name = "variantLabel";
            this.variantLabel.Size = new System.Drawing.Size(114, 26);
            this.variantLabel.TabIndex = 0;
            this.variantLabel.Text = "VARIANT";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(550, 376);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label variantLabel;
        private VariantRadioButton cyclopsVariantRadioButton;
        private VariantRadioButton hydraVariantRadioButton;
        private VariantRadioButton medusaVariantRadioButton;
        private VariantRadioButton basiliskVariantRadioButton;
        private EliteButton closeButton;
        private EliteButton StopTimerKeybindButton;
        private EliteButton StartTimerKeybindButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KeybindLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}