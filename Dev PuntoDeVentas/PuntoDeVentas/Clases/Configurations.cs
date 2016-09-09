using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System {
    public static class Configurations {

        public static string NombreDelNegocio {
            get;
            set;
        }
        public static string Direccion {
            get;
            set;
        }
        public static string Region {
            get;
            set;
        }

        public static void Load() {
            NombreDelNegocio = DbRepository.GetConfig("EMPRESA");
            Direccion = DbRepository.GetConfig("DIRECCION");
            Region = DbRepository.GetConfig("REGION");
        }

        public static bool Update() {
            var IsSaveSuccess = 
                                DbRepository.UpdateConfig("EMPRESA", NombreDelNegocio) &
                                DbRepository.UpdateConfig("DIRECCION", Direccion) &
                                DbRepository.UpdateConfig("REGION", Region);

            return IsSaveSuccess;
        }

    }
}
