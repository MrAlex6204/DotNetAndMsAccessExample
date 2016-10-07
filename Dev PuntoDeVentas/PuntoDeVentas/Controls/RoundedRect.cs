using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace PuntoDeVentas {


    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class RoundedRect {
        public int Radius { get; set; }
        public Point Position { get; set; }
        public Size Size { get; set; }


        public RoundedRect(Point Location, Size Size, int Radius) {

            this.Position = Location;
            this.Size = Size;
            this.Radius = Radius;

        }



        public void DrawRoundedRectangle(ref Graphics g, Pen p) {

            RectangleF BaseRect;
            RectangleF ArcRect;
            PointF PosF = this.Position;


            if (this.Radius <= 0) {
                this.Radius = 1;
            }


            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            BaseRect = new RectangleF(PosF, this.Size);
            ArcRect = new RectangleF(BaseRect.Location, new SizeF(this.Radius, this.Radius));

            //TOP LEFT ARC
            g.DrawArc(p, ArcRect, 180, 90);
            g.DrawLine(p, PosF.X + (this.Radius / 2), PosF.Y, PosF.X + this.Size.Width - (this.Radius / 2), PosF.Y);

            //TOP RIGHT ARC
            ArcRect.X = BaseRect.Right - this.Radius;
            g.DrawArc(p, ArcRect, 270, 90);
            g.DrawLine(p, PosF.X + this.Size.Width, PosF.Y + (this.Radius / 2), PosF.X + this.Size.Width, PosF.Y + this.Size.Height - (this.Radius / 2));

            //BOTTOM RIGHT ARC
            ArcRect.Y = BaseRect.Bottom - this.Radius;
            g.DrawArc(p, ArcRect, 0, 90);
            g.DrawLine(p, PosF.X + (this.Radius / 2), PosF.Y + this.Size.Height, PosF.X + this.Size.Width - (this.Radius / 2), PosF.Y + this.Size.Height);

            //BOTTOM LEFT ARC
            ArcRect.X = BaseRect.Left;
            g.DrawArc(p, ArcRect, 90, 90);
            g.DrawLine(p, PosF.X, PosF.Y + (this.Radius / 2), PosF.X, PosF.Y + this.Size.Height - (this.Radius / 2));





        }

        public void FillRoundedRectangle(ref Graphics g, Color c) {

            RectangleF BaseRect;
            RectangleF ArcRect;
            Brush Brsh = new SolidBrush(c);
            PointF PosF = this.Position;


            if (this.Radius <= 0) {
                this.Radius = 1;
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            BaseRect = new RectangleF(PosF, this.Size);
            ArcRect = new RectangleF(BaseRect.Location, new SizeF(this.Radius, this.Radius));

            using (var gp = new GraphicsPath()) {

                //TOP LEFT ARC
                gp.AddArc(ArcRect, 180, 90);
                gp.AddLine(PosF.X + (this.Radius / 2), PosF.Y, PosF.X + this.Size.Width - (this.Radius / 2), PosF.Y);

                //TOP RIGHT ARC
                ArcRect.X = BaseRect.Right - this.Radius;
                gp.AddArc(ArcRect, 270, 90);
                gp.AddLine(PosF.X + this.Size.Width, PosF.Y + (this.Radius / 2), PosF.X + this.Size.Width, PosF.Y + this.Size.Height - (this.Radius / 2));

                //BOTTOM RIGHT ARC
                ArcRect.Y = BaseRect.Bottom - this.Radius;
                gp.AddArc(ArcRect, 0, 90);
                gp.AddLine(PosF.X + (this.Radius / 2), PosF.Y + this.Size.Height, PosF.X + this.Size.Width - (this.Radius / 2), PosF.Y + this.Size.Height);

                //BOTTOM LEFT ARC
                ArcRect.X = BaseRect.Left;
                gp.AddArc(ArcRect, 90, 90);
                gp.AddLine(PosF.X, PosF.Y + (this.Radius / 2), PosF.X, PosF.Y + this.Size.Height - (this.Radius / 2));

                g.FillPath(Brsh, gp);

            }



        }



    }

}
