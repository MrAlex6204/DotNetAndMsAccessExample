using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

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
                    float Orignal_Height = Img.Size.Height - 10;
                    float Orignal_Width = Img.Size.Width - 10;

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
        public static Image ConvertToGrayScale(System.Drawing.Image SourceImage) {
            Image grayScaleImg = null;

            if (SourceImage != null) {
                Bitmap bmp = new Bitmap(SourceImage);

                for (var w = 0; w < SourceImage.Size.Width; w++) {

                    for (var h = 0; h < SourceImage.Size.Height; h++) {

                        var pxColor = bmp.GetPixel(w, h);
                        var grayScale = (pxColor.R + pxColor.G + pxColor.B) / 3;
                        var pxNewColor = Color.FromArgb(grayScale, grayScale, grayScale);
                        bmp.SetPixel(w, h, pxNewColor);

                    }

                }

                grayScaleImg = bmp.GetThumbnailImage(SourceImage.Width, SourceImage.Height, null, IntPtr.Zero);

            }

            GC.Collect();
            return grayScaleImg;
        }

        //REDONDEA LAS ESQUINAS DE LA IMAGEN
        public static Image GetRoundCornersImage(Image SourceImage, int CornerRadius, Color BackgroundColor) {

            if (SourceImage != null) {
                CornerRadius *= 2;
                Bitmap RoundedImage = new Bitmap(SourceImage.Width, SourceImage.Height);
                Graphics g = Graphics.FromImage(RoundedImage);
                Brush brush;
                GraphicsPath gp;

                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                brush = new TextureBrush(SourceImage);
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

        public static Image GetTintImage(Image SourceImage, float RedTint, float GreenTint, float BlueTint) {
            Image TintImage = new Bitmap(SourceImage.Width,SourceImage.Height);

            byte[] pxBuffer = null;
            BitmapData SourceBmpData = ((Bitmap)SourceImage).LockBits(new Rectangle(0, 0, SourceImage.Width, SourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData NewBmpData = ((Bitmap)TintImage).LockBits(new Rectangle(0, 0, SourceImage.Width, SourceImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            pxBuffer = new byte[SourceBmpData.Stride * SourceBmpData.Height];

            Marshal.Copy(SourceBmpData.Scan0, pxBuffer, 0, pxBuffer.Length);

            ((Bitmap)SourceImage).UnlockBits(SourceBmpData);


            float Red = 0f, Green = 0f, Blue = 0f;

            for (int Idx = 0, RedIdx = Idx, GreenIdx = Idx + 1, BlueIdx = Idx + 2; Idx + 4 < pxBuffer.Length; Idx += 4,RedIdx = Idx, GreenIdx = Idx + 1, BlueIdx = Idx + 2) {
                


                Red = pxBuffer[RedIdx] + (255 - pxBuffer[RedIdx]) * RedTint;
                Green = pxBuffer[GreenIdx] + (255 - pxBuffer[GreenIdx]) * GreenTint;
                Blue = pxBuffer[BlueIdx] + (255 - pxBuffer[BlueIdx]) * BlueTint;


                Red = Red > 255 ? 255 : Red;
                Green = Green > 255 ? 255 : Green;
                Blue = Blue > 255 ? 255 : Blue;

                pxBuffer[RedIdx] = (byte)Red;
                pxBuffer[GreenIdx] = (byte)Green;
                pxBuffer[BlueIdx] = (byte)Blue;


            }

            Marshal.Copy(pxBuffer, 0, NewBmpData.Scan0, pxBuffer.Length);
            ((Bitmap)TintImage).UnlockBits(NewBmpData);
            
            GC.Collect();
            return TintImage;
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


    }

}
