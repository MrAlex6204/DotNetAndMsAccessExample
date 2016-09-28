using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
namespace PuntoDeVentas
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Radius
    {
        public enum RadiusType {
            TopLeft,
            TopRigth,
            BottonLeft,

        }

        public Radius()
        {
            this.TopLeft = 0f;
            this.TopRigth = 0f;

            this.BottomLeft = 0f;
            this.BottomRigth = 0f;
        }
        
        public float TopLeft { get; set; }
        public float TopRigth { get; set; }
        public float BottomLeft { get; set; }
        public float BottomRigth { get; set; }

        public override string ToString()
        {
            return "(Radius)";
        }



    }
}