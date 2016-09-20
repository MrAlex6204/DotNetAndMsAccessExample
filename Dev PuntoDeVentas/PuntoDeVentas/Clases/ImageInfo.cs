using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas {

    public class ImageInfo {
        //Image Stream
        public byte[] FSImage;

        //Propiedad de ReadOnly para descomprimir la imagen de bytes
        public System.Drawing.Image GetImageSzOf(System.Drawing.Size sz) {

            if (FSImage != null) {
                System.Drawing.Image Img, FixedImg;
                System.Drawing.Size AspectRatioSz = new System.Drawing.Size();

                using (System.IO.MemoryStream ImgStream = new System.IO.MemoryStream(FSImage)) {
                    Img = System.Drawing.Image.FromStream(ImgStream);
                    float Orignal_Height = Img.Size.Height;
                    float Orignal_Width = Img.Size.Width;
                    
                    //Calcular el aspect ratio para evitar que se distorcione                    
                    AspectRatioSz = new System.Drawing.Size(sz.Width,(int)((Orignal_Height / Orignal_Width) * sz.Width));
                    
                    FixedImg = Img.GetThumbnailImage(AspectRatioSz.Width, AspectRatioSz.Height, null, IntPtr.Zero);

                }

                return FixedImg;
            } else {
                return null;
            }

        }

        //Limpiar el stream
        public void Clear() {
            this.FSImage = null;
        }

        //Verificar si el stream esta vacion
        public bool IsEmpty {
            get {
                return (this.FSImage == null);
            }
        }


        //Leer el archivo y obtener el stream
        public static byte[] GetFileStream(string FileFullName) {
            byte[] FsImg = null;

            using (System.IO.FileStream FsPicture = new System.IO.FileStream(FileFullName, System.IO.FileMode.Open, System.IO.FileAccess.Read)) {
                FsImg = new byte[FsPicture.Length];
                FsPicture.Read(FsImg, 0, (int)FsPicture.Length);
            }

            return FsImg;
        }



    }

}
