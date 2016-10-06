using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace PuntoDeVentas {

    public class ImageInfo {
        //Image Stream
        public byte[] FSImage;

        //PROPIEDAD DE READONLY PARA DESCOMPRIMIR LA IMAGEN DE BYTES
        public System.Drawing.Image GetImageSzOf(System.Drawing.Size sz) {

            return GetImageSzOf(FSImage, sz);
        }

        //OBTIENE LA IMAGEN EN ESCALA DE GRISES
        public System.Drawing.Image GetGrayScaleImageSzOf(System.Drawing.Size sz) {
            var Img = GetImageSzOf(FSImage, sz);

            return ConvertToGrayScale(Img);
        }



        //LIMPIAR EL STREAM
        public void Clear() {
            this.FSImage = null;
        }

        //VERIFICAR SI EL STREAM ESTA VACION
        public bool IsEmpty {
            get {
                return (this.FSImage == null);
            }
        }

        //LEER EL ARCHIVO Y OBTENER EL STREAM
        public static byte[] GetFileStream(string FileFullName) {
            byte[] FsImg = null;

            using (System.IO.FileStream FsPicture = new System.IO.FileStream(FileFullName, System.IO.FileMode.Open, System.IO.FileAccess.Read)) {
                FsImg = new byte[FsPicture.Length];
                FsPicture.Read(FsImg, 0, (int)FsPicture.Length);
            }

            GC.Collect();
            return FsImg;
        }

        //DESCOMPRIME LA IMAGEN APARTIR DE UN BYTE STREAM
        public static Image GetImageSzOf(byte[] Fs, System.Drawing.Size sz) {

            if (Fs != null) {
                System.Drawing.Image Img, FixedImg;
                System.Drawing.Size AspectRatioSz = new System.Drawing.Size();

                using (System.IO.MemoryStream ImgStream = new System.IO.MemoryStream(Fs)) {
                    Img = System.Drawing.Image.FromStream(ImgStream);
                    float Orignal_Height = Img.Size.Height-10;
                    float Orignal_Width = Img.Size.Width-10;

                    //Calcular el aspect ratio para evitar que se distorcione                    
                    AspectRatioSz = new System.Drawing.Size(sz.Width, (int)((Orignal_Height / Orignal_Width) * sz.Width));

                    FixedImg = Img.GetThumbnailImage(AspectRatioSz.Width, AspectRatioSz.Height, null, IntPtr.Zero);

                }


                GC.Collect();
                return FixedImg;
            } else {
                return null;
            }

        }

        //CONVIERTE LA IMAGEN A ESCALA DE GRISES
        public static Image ConvertToGrayScale(System.Drawing.Image Img) {
            Image grayScaleImg = null;

            if (Img != null) {
                Bitmap bmp = new Bitmap(Img);

                for (var w = 0; w < Img.Size.Width; w++) {

                    for (var h = 0; h < Img.Size.Height; h++) {

                        var pxColor = bmp.GetPixel(w, h);
                        var grayScale = (pxColor.R + pxColor.G + pxColor.B) / 3;
                        var pxNewColor = Color.FromArgb(grayScale, grayScale, grayScale);
                        bmp.SetPixel(w, h, pxNewColor);
                                               
                    }

                }

                grayScaleImg = bmp.GetThumbnailImage(Img.Width, Img.Height, null, IntPtr.Zero);

            }

            GC.Collect();
            return grayScaleImg;
        }

        public static Image GetOvalImage(Image img) {
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            using (GraphicsPath gp = new GraphicsPath()) {
                gp.AddPie(0, 0, img.Width, img.Height, 0, 360);
                using (Graphics gr = Graphics.FromImage(bmp)) {
                    gr.SetClip(gp);
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    gr.DrawImage(img, Point.Empty);
                }
            }

            GC.Collect();
            return bmp;
        }

        public static Image GetRoundCornersImage(Image StartImage, int CornerRadius, Color BackgroundColor) {

            if (StartImage != null) {
                CornerRadius *= 2;
                Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);
                Graphics g = Graphics.FromImage(RoundedImage);
                Brush brush ;
                GraphicsPath gp;

                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                brush = new TextureBrush(StartImage);
                gp = new GraphicsPath();

                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);

                g.FillPath(brush, gp);

                return RoundedImage;
            } else {
                return null;
            }
        }

    }

}
