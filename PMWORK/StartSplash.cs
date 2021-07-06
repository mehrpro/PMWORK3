using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PMWORK
{
   public class StartSplash
    {
        public StartSplash()
        {
            // Open a Splash Screen
            SplashScreenManager.ShowForm(this, typeof(Splash), true, true, false);

            // The splash screen will be opened in a separate thread. To interact with it, use the SendCommand method.
            for (int i = 1; i <= 100; i++)
            {
                SplashScreenManager.Default.SendCommand(Splash.SplashScreenCommand.SetProgress, i);
                //To process commands, override the SplashScreen.ProcessCommand method.
                Thread.Sleep(25);
            }

            // Close the Splash Screen.
            SplashScreenManager.CloseForm(false);
        }
    }
}
