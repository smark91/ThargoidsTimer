using System;
using System.Deployment.Application;
using System.Drawing;
using System.Windows.Forms;

namespace ThargoidsTimer
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();

            versionLabel.Text = string.Format("v{0}", Program.version.ToString(3));

            if (Program.currentVariant == Program.cyclopsVariant)
            {
                cyclopsVariantRadioButton.Select();
            }
            else if (Program.currentVariant == Program.basiliskVariant)
            {
                basiliskVariantRadioButton.Select();
            }
            else if (Program.currentVariant == Program.medusaVariant)
            {
                medusaVariantRadioButton.Select();
            }
            else if (Program.currentVariant == Program.hydraVariant)
            {
                hydraVariantRadioButton.Select();
            }

            ChangeStartTimerKeybindLabel(Program.startKeystroke);
            ChangeStopTimerKeybindLabel(Program.stopKeystroke);
        }

        public void ChangeStartTimerKeybindLabel(string text)
        {
            StartTimerKeybindButton.Text = text;
        }

        public void ChangeStopTimerKeybindLabel(string text)
        {
            StopTimerKeybindButton.Text = text;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void StartTimerKeybindButton_Click(object sender, EventArgs e)
        {
            StartTimerKeybindButton.Text = "Press a key...";
            Program.registerStartKeybind = true;
        }

        private void StopTimerKeybindButton_Click(object sender, EventArgs e)
        {
            StopTimerKeybindButton.Text = "Press a key...";
            Program.registerStopKeybind = true;
        }

        private void cyclopsVariantRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as VariantRadioButton).Checked) Program.ChangeVariant(Program.cyclopsVariant);
        }

        private void basiliskVariantRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as VariantRadioButton).Checked) Program.ChangeVariant(Program.basiliskVariant);
        }

        private void medusaVariantRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as VariantRadioButton).Checked) Program.ChangeVariant(Program.medusaVariant);
        }

        private void hydraVariantRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as VariantRadioButton).Checked) Program.ChangeVariant(Program.hydraVariant);
        }

        private class VariantRadioButton : RadioButton
        {
            protected override void OnCheckedChanged(EventArgs e)
            {
                ForeColor = Checked ? Color.Black : Color.DarkOrange;
                base.OnCheckedChanged(e);
            }

            protected override void OnMouseEnter(EventArgs e)
            {
                ForeColor = Color.Black;
                base.OnMouseEnter(e);
            }

            protected override void OnMouseLeave(EventArgs e)
            {
                if (!Checked) ForeColor = Color.DarkOrange;
                base.OnMouseLeave(e);
            }
        }
    }
}
