/*
 * EXERCISE............: Exercise 10.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP.....: 2º Interface Development 
 * PROJECT.............: Forms III. Serial Port and DLL
 * DATE................: 30 Jan 2019
 */


using System;
using System.Windows.Forms;

namespace Exercise10
{
    static class MainClass
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        #region main
        [STAThread]
        static void Main()
        {
            frmSplashScreen splash;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            splash = new frmSplashScreen();

            if (splash.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmConfig());
            }
        }
        #endregion
    }
}
