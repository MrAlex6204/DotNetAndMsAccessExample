using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PuntoDeVentas {
    static class MainCore {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {


            try {

                FRM_Login wndLogin = new FRM_Login();
                FRM_Main wndVentanaPrinicipal = new FRM_Main();
                FRM_SplashScreen wndLoading = new FRM_SplashScreen();

                //Load main configuartions
                System.Configurations.Load();

#if DEBUG
                //Code para ejecutar solo en Debug 
                var Usr = DbRepository.ValidarUsuario("mavxdp1", "123");

                if (Usr.Exists) {
                    DbRepository.LoggedUser = Usr;
                    Application.Run(wndVentanaPrinicipal);

                }


#else 
            //Code para ejecutar solo en Release
            wndLoading.ShowDialog();            
            wndLogin.ShowDialog(wndVentanaPrinicipal);
            var User = wndLogin.User;

            if (User.Exists) {
                DbRepository.LoggedUser = User;
                //Correr applicacion solo si esta logueado
                wndVentanaPrinicipal.Show();
                

                Application.Run(wndVentanaPrinicipal);            
            }
#endif

            } catch (Exception ex) {



            } finally {
                Application.Exit();
            }


        }
    }
}
