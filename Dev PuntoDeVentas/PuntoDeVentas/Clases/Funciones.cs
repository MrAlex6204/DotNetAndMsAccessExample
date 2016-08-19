<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//nombre de espacions usados para imprimir el tiket
using System.Drawing;
using System.Drawing.Printing;

   public static class Funciones
    {
       //funcion para mostrar un mesaje en pantalla
       public static void Message(string Text) {
           PuntoDeVentas.FRM_Message wndMessage = new PuntoDeVentas.FRM_Message();
           wndMessage.Message = Text;
           wndMessage.ShowDialog();
       }
       public static void MostrarCambio(string Text,string Total,string Pago,string Cambio,System.Windows.Forms.Form Owner)
       {
           PuntoDeVentas.FRM_Cambio wndMessage = new PuntoDeVentas.FRM_Cambio();
           wndMessage.Message = Text;
           wndMessage.ShowDialog(Owner);
           if (wndMessage.ImprimirTiket) { //Si el usuario desea imprimir el tiket
               try
               {
                   System.PuntoDeVentas.ImprimirTiket(Total, Pago, Cambio);
               }
               catch (Exception ex) {
                   //Si marca un error mostramos en pantalla 
                   Message(ex.Message);
               }
           }
       }
       //funcion para validar si un dato es numerico
       public static bool IsNumber(string Value) {
           try//retorna false si marca un error al hacer la conversion
           {
               double number = 0;
               number = Convert.ToDouble(Value.Trim());
               return true;
           }
           catch {
               return false;
           }
       }


       public static double ToNumber(string Value){
       return Convert.ToDouble(Value);
       }

    }

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//nombre de espacions usados para imprimir el tiket
using System.Drawing;
using System.Drawing.Printing;

   public static class Funciones
    {
       //funcion para mostrar un mesaje en pantalla
       public static void Message(string Text) {
           PuntoDeVentas.FRM_Message wndMessage = new PuntoDeVentas.FRM_Message();
           wndMessage.Message = Text;
           wndMessage.ShowDialog();
       }
       public static void MostrarCambio(string Text,string Total,string Pago,string Cambio,System.Windows.Forms.Form Owner)
       {
           PuntoDeVentas.FRM_Cambio wndMessage = new PuntoDeVentas.FRM_Cambio();
           wndMessage.Message = Text;
           wndMessage.ShowDialog(Owner);
           if (wndMessage.ImprimirTiket) { //Si el usuario desea imprimir el tiket
               try
               {
                   System.PuntoDeVentas.ImprimirTiket(Total, Pago, Cambio);
               }
               catch (Exception ex) {
                   //Si marca un error mostramos en pantalla 
                   Message(ex.Message);
               }
           }
       }
       //funcion para validar si un dato es numerico
       public static bool IsNumber(string Value) {
           try//retorna false si marca un error al hacer la conversion
           {
               double number = 0;
               number = Convert.ToDouble(Value.Trim());
               return true;
           }
           catch {
               return false;
           }
       }


       public static double ToNumber(string Value){
       return Convert.ToDouble(Value);
       }

    }

>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//nombre de espacions usados para imprimir el tiket
using System.Drawing;
using System.Drawing.Printing;

   public static class Funciones
    {
       //funcion para mostrar un mesaje en pantalla
       public static void Message(string Text) {
           PuntoDeVentas.FRM_Message wndMessage = new PuntoDeVentas.FRM_Message();
           wndMessage.Message = Text;
           wndMessage.ShowDialog();
       }
       public static void MostrarCambio(string Text,string Total,string Pago,string Cambio,System.Windows.Forms.Form Owner)
       {
           PuntoDeVentas.FRM_Cambio wndMessage = new PuntoDeVentas.FRM_Cambio();
           wndMessage.Message = Text;
           wndMessage.ShowDialog(Owner);
           if (wndMessage.ImprimirTiket) { //Si el usuario desea imprimir el tiket
               try
               {
                   System.PuntoDeVentas.ImprimirTiket(Total, Pago, Cambio);
               }
               catch (Exception ex) {
                   //Si marca un error mostramos en pantalla 
                   Message(ex.Message);
               }
           }
       }
       //funcion para validar si un dato es numerico
       public static bool IsNumber(string Value) {
           try//retorna false si marca un error al hacer la conversion
           {
               double number = 0;
               number = Convert.ToDouble(Value.Trim());
               return true;
           }
           catch {
               return false;
           }
       }


       public static double ToNumber(string Value){
       return Convert.ToDouble(Value);
       }

    }

>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
