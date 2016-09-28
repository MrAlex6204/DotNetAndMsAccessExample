using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace PuntoDeVentas {


    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class RoundedRect {
        public int Radius{ get; set; }
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
         
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (this.Radius <= 0) {
                this.Radius = 1;
            }
            

            BaseRect = new RectangleF(this.Position, this.Size);
            ArcRect = new RectangleF(BaseRect.Location, new SizeF(this.Radius, this.Radius));

            //top left Arc
            g.DrawArc(p, ArcRect, 180, 90);
            g.DrawLine(p, this.Position.X + Convert.ToInt32(this.Radius / 2), this.Position.Y, this.Position.X + this.Size.Width - Convert.ToInt32(this.Radius/ 2), this.Position.Y);

            // top right arc
            ArcRect.X = BaseRect.Right - this.Radius;
            g.DrawArc(p, ArcRect, 270, 90);
            g.DrawLine(p, this.Position.X + this.Size.Width, this.Position.Y + Convert.ToInt32(this.Radius/ 2), this.Position.X + this.Size.Width, this.Position.Y + this.Size.Height - Convert.ToInt32(this.Radius/ 2));

            // bottom right arc
            ArcRect.Y = BaseRect.Bottom - this.Radius;
            g.DrawArc(p, ArcRect, 0, 90);
            g.DrawLine(p, this.Position.X + Convert.ToInt32(this.Radius / 2), this.Position.Y + this.Size.Height, this.Position.X + this.Size.Width - Convert.ToInt32(this.Radius / 2), this.Position.Y + this.Size.Height);

            // bottom left arc
            ArcRect.X = BaseRect.Left;
            g.DrawArc(p, ArcRect, 90, 90);
            g.DrawLine(p, this.Position.X, this.Position.Y + Convert.ToInt32(this.Radius/ 2), this.Position.X, this.Position.Y + this.Size.Height - Convert.ToInt32(this.Radius / 2));

         

            
            
        }

        public void FillRoundedRectangle(ref Graphics g, Color c) {

            Rectangle BaseRect;
            Rectangle ArcRect;
            Rectangle VRect;
            Rectangle HRect;
            Brush Br = new SolidBrush(c);
            

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (this.Radius <= 0) {
                this.Radius = 1;
            }


            BaseRect = new Rectangle(this.Position, this.Size);
            ArcRect = new Rectangle(this.Position, new Size(this.Radius, this.Radius));

            // --
            VRect = new Rectangle(this.Position.X + Convert.ToInt16(this.Radius / 2), this.Position.Y, this.Size.Width - Convert.ToInt16(this.Radius / 2) - Convert.ToInt16(this.Radius / 2), this.Size.Height);
            // |
            HRect = new Rectangle(this.Position.X, this.Position.Y + Convert.ToInt16(this.Radius / 2), this.Size.Width, this.Size.Height - Convert.ToInt16(this.Radius / 2) - Convert.ToInt16(this.Radius / 2));

            //TOP LEFT ARC
            g.FillRectangle(Br, HRect);
            g.FillPie(Br, ArcRect, 180, 90);
            
            //TOP RIGHT ARC
            ArcRect.X = BaseRect.Right - this.Radius;
            g.FillPie(Br, ArcRect, 270, 90);
            
            //BOTTOM RIGHT ARC
            ArcRect.Y = BaseRect.Bottom - this.Radius;
            g.FillPie(Br, ArcRect, 0, 90);
            
            //BOTTOM LEFT ARC
            ArcRect.X = BaseRect.Left;
            g.FillPie(Br, ArcRect, 90, 90);            
            g.FillRectangle(Br, VRect);
                        
        }

        

    }

}
