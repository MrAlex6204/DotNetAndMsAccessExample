using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//nombre de espacions usados para imprimir el tiket
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
public static class Functions
{
    //FUNCION PARA MOSTRAR UN MESAJE EN PANTALLA
    public static void Message(string Text,Nullable<Color> Bordercolor = null,Form Parent = null)
    {
        PuntoDeVentas.FRM_Message wndMessage = new PuntoDeVentas.FRM_Message();
        wndMessage.Message = Text;

        if (Bordercolor.HasValue) { 
            wndMessage.WindowBorderColor = Bordercolor.Value;        
        }

        if (Parent!=null) {
            wndMessage.StartPosition = FormStartPosition.CenterParent;
            wndMessage.ShowDialog(Parent);
        } else {
            wndMessage.ShowDialog();
        }

    }

    public static void MostrarCambio(string Text, string Total, string Pago, string Cambio, System.Windows.Forms.Form Owner)
    {
        PuntoDeVentas.FRM_Cambio wndMessage = new PuntoDeVentas.FRM_Cambio();
        wndMessage.Message = Text;
        wndMessage.ShowDialog(Owner);
        if (wndMessage.ImprimirTiket)
        { //Si el usuario desea imprimir el tiket
            try
            {
                System.DbRepository.ImprimirTiket(Total, Pago, Cambio);
            }
            catch (Exception ex)
            {
                //Si marca un error mostramos en pantalla 
                Message(ex.Message);
            }
        }
    }

    //FUNCION PARA VALIDAR SI UN DATO ES NUMERICO
    public static bool IsNumber(string Value)
    {
        try//retorna false si marca un error al hacer la conversion
        {
            double number = 0;
            number = Convert.ToDouble(Value.Trim());
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static double ToNumber(string Value)
    {
        return Convert.ToDouble(Value);
    }

    public static string ToCurrency(double value,IFormatProvider provider ) {
        return string.Format(provider, "{0:C2}", value);
    }

    public static string ToCurrency(string value, IFormatProvider provider) {
        var val = 0.0d;

        if (double.TryParse(value, out val)) {
            return ToCurrency(val,provider);
        } else {
            return value;
        }
                
    }

    public static string ToCurrency(double value)
    {
        return string.Format(Configurations.RegionProvider, "{0:C2}", value);
    }

    public static string ToCurrency(string value) {
        var val = 0.0d;

        if (double.TryParse(value, out val))
        {
            return ToCurrency(val);
        }
        else {
            return value;
        }

    }



}

