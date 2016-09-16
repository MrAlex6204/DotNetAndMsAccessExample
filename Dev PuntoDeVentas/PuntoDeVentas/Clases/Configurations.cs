using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace System
{
    public static class Configurations
    {
        private static CultureInfo _RegionCurrency = null;

        public static string NombreDelNegocio
        {
            get;
            set;
        }
        public static string Direccion
        {
            get;
            set;
        }
        public static string RegionString
        {
            get;
            set;
        }

        public static CultureInfo RegionProvider
        {
            get
            {
                if (_RegionCurrency == null && !string.IsNullOrEmpty(RegionString))
                {
                    try
                    {

                        _RegionCurrency = new CultureInfo(RegionString);
                    }
                    catch
                    {

                        _RegionCurrency = Threading.Thread.CurrentThread.CurrentCulture;
                    }
                }

                return _RegionCurrency;
            }
        }


        public static void Load()
        {
            NombreDelNegocio = DbRepository.GetConfig("EMPRESA");
            Direccion = DbRepository.GetConfig("DIRECCION");
            RegionString = DbRepository.GetConfig("REGION");
        }

        public static bool Update()
        {
            var IsSaveSuccess =
                                DbRepository.UpdateConfig("EMPRESA", NombreDelNegocio) &
                                DbRepository.UpdateConfig("DIRECCION", Direccion) &
                                DbRepository.UpdateConfig("REGION", RegionString);

            return IsSaveSuccess;
        }



    }
}
