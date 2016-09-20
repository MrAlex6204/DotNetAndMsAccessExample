using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{

    public class ImageInfo
    {
        //Image Stream
        public object FSImage;

        //Propiedad de ReadOnly para descomprimir la imagen de bytes
        public System.Drawing.Image Image
        {
            get
            {
                if (FSImage != null)
                {
                    System.IO.MemoryStream ImgStream = new System.IO.MemoryStream((byte[])FSImage);
                    return System.Drawing.Image.FromStream(ImgStream);
                }
                else
                {
                    return null;
                }
            }
        }

    }

}
