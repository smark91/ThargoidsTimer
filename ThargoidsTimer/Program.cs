using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThargoidsTimer
{
    static class Program
    {
        public static UserActivityHook userActivityHook;
        public static string startKeystroke;
        public static string stopKeystroke;
        public static bool registerStartKeybind;
        public static bool registerStopKeybind;

        public static ThargoidsVariant cyclopsVariant;
        public static ThargoidsVariant basiliskVariant;
        public static ThargoidsVariant medusaVariant;
        public static ThargoidsVariant hydraVariant;
        public static ThargoidsVariant currentVariant;

        public static OverlayForm overlayForm;
        public static ConfigForm configForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            userActivityHook = new UserActivityHook(false, true);
            userActivityHook.KeyUp += new KeyEventHandler(UserActivityHook_KeyUp);
            registerStartKeybind = false;
            registerStopKeybind = false;
            startKeystroke = "F1";
            stopKeystroke = "F2";

            cyclopsVariant = new ThargoidsVariant("Cyclops", 360, 105);
            basiliskVariant = new ThargoidsVariant("Basilisk", 420, 180);
            medusaVariant = new ThargoidsVariant("Medusa", 420, 240);
            hydraVariant = new ThargoidsVariant("Hydra", 480, 320);
            

            currentVariant = cyclopsVariant;

            overlayForm = new OverlayForm();
            configForm = new ConfigForm();
            Application.Run(overlayForm);
        }

        private static void UserActivityHook_KeyUp(object sender, KeyEventArgs e)
        {
            if(registerStartKeybind)
            {
                startKeystroke = e.KeyData.ToString();
                registerStartKeybind = false;
                configForm.ChangeStartTimerKeybindLabel(startKeystroke);
                return;
            } else if (registerStopKeybind)
            {
                stopKeystroke = e.KeyData.ToString();
                registerStopKeybind = false;
                configForm.ChangeStopTimerKeybindLabel(stopKeystroke); 
                return;
            }
            if(e.KeyData.ToString() == startKeystroke)
            {
                overlayForm.Timers_Start();
                Console.WriteLine("Play");

            }
            else if (e.KeyData.ToString() == stopKeystroke)
            {
                overlayForm.Timers_Stop();
                Console.WriteLine("Stop");
            }
        }

        public static void ChangeVariant(ThargoidsVariant variant)
        {
            currentVariant = variant;
            overlayForm.EnrageTimer_Set(currentVariant.EnrageSeconds);
            overlayForm.ShieldTimer_Set(currentVariant.ShieldSeconds);
        }
    }
    
    public class EliteButton : Button
    {
        protected override void OnMouseEnter(EventArgs e)
        {
            ForeColor = Color.Black;
            BackColor = Color.DarkOrange;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            ForeColor = Color.DarkOrange;
            BackColor = Color.Transparent;
            base.OnMouseLeave(e);
        }
    }
}
