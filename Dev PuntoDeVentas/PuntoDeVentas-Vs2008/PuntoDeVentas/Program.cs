using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    static class Program
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
            FRM_VentanaPrincipal wndVentanaPrinicipal = new FRM_VentanaPrincipal();
            FRM_Menu wndMenu = new FRM_Menu();
            FRM_SplashScreen wndLoading = new FRM_SplashScreen();
            wndLoading.ShowDialog();

            wndVentanaPrinicipal.Show();
            wndLogin.ShowDialog(wndVentanaPrinicipal);
            wndMenu.ShowDialog();
            Application.Run();            
        }
    }
}
