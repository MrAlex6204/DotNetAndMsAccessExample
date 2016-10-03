using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    static class MainCore
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);            
            //Application.Run(new FRM_Login());
            FRM_Login wndLogin = new FRM_Login();
            FRM_Main wndVentanaPrinicipal = new FRM_Main();            
            FRM_SplashScreen wndLoading = new FRM_SplashScreen();

            //Load main configuartions
            System.Configurations.Load();

#if DEBUG
            //Code para ejecutar solo en Debug            
            wndLogin.ShowDialog();
            if (wndLogin.UserIsLoggued) {
                var wndCbza = new FRM_Cbza();
                wndCbza.ShowDialog();
            }


#else 
            //Code para ejecutar solo en Release
            wndLoading.ShowDialog();            
            wndLogin.ShowDialog(wndVentanaPrinicipal);

            if (wndLogin.UserIsLoggued) { 
                //Correr applicacion solo si esta logueado
                wndVentanaPrinicipal.Show();
                

                Application.Run(wndVentanaPrinicipal);            
            }
#endif           
            
            
        }
    }
}
