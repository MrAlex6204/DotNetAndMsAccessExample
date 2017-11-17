using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoDeVentas.Models {

    public class UserInfo {
        
        public bool Exists { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LevelType { get; set; }
        public string Password { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public ImageInfo Picture { get; set; }  //FOTO DEL USUARIO
        public string DepositoEnCaja { get; set; }

        public UserInfo() {

            this.Picture = new ImageInfo();
            this.Clear();
        }

        public void Clear() {

            Exists = false;
            Id = -1;
            UserName = string.Empty;
            Name = string.Empty;
            LevelType = string.Empty;
            Picture.Clear();
            Password= string.Empty;
            Date = null;
            DepositoEnCaja = string.Empty;

        }

    }


}
