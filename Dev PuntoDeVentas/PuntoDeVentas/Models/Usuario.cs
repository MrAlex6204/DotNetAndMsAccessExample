using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoDeVentas.Models {

   public class Usuario {
             

        public Usuario() {
            //this.Clear();
        }


        //public bool Exists { get; set; }
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Type { get; set; }

        //public void Clear() {
        //    //this.Exists = false;
        //    this.Id = -1;
        //    this.UserName = string.Empty;
        //    this.Nombre = string.Empty;
        //    this.Type = string.Empty;
        //}

        //protected static Usuario GetInstance() {
        //    return new Usuario();
        //}

        //public static Usuario GetUserInfo(DbRepository Repository, string UserName, string Password) {
        //    var usr = Usuario.GetInstance();


        //    return usr;
        //}

        //public static Usuario GetUserInfo(DbRepository Repository, string Id) {
        //    var usr = Usuario.GetInstance();


        //    return usr;
        //}

        //public static Usuario UpdateUsetInfo(DbRepository Repository, Usuario User) {
        //    var usr = Usuario.GetInstance();


        //    return usr;
        //}

    }


}
