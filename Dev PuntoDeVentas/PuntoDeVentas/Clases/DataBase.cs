<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Namespace usado para poder hacer la conexion
using System.Data.OleDb;
using System.Data;

using System.Drawing;
using System.Drawing.Printing;

namespace System {

    public static class PuntoDeVentas //Clase para hacer consultas a nuestra base de datos
    {

        #region  <DECLARACIONES GLOBALES>

        //Cadena de conexion hacia la base de datos access        
        private static string _strCadenaDeConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB\dbVentas.mdb;User Id=admin;Password=";
        //Objeto de conexion para hacer las consultas
        private static OleDbConnection _objConn = new OleDbConnection(_strCadenaDeConexion);
        //Objeto para ejecutar las consulas hacia Bd.
        private static OleDbCommand _objCmd = new OleDbCommand();

        private static PrintDocument _PrintTiket = new PrintDocument();

        //Informacion de el usuario logueado!
        private static string _Usr = "";//Usuario
        private static string _Nombre = "";//Nombre
        private static string _Tipo = "";//Tipo
        private static string _Id = ""; //Id del usuario

        public struct ArticuloInfo//Estructura para guardar la informacion de un articulo 
        {
            public string ID;
            public string DESCRIPCION;
            public string PRECIO;
            public string INV;
            public string UNIDAD;
            public bool EXIST;//si el articulo existe devuelve true
        }

        public struct CorteDeCajaInfo// ESTRUCTURA PARA GUARDAR INFORMACION DEL CORTE DE CAJA
        {
            public string NomCajero;
            public DataTable Articulos;
            public Double Total;
            public int TotalArticulos;
            public bool CajeroExist;//si el cajero existe devuelve true
        }
        public struct VentadelDia {//En para guardar la venta del dia
            public double Total;
            public double TotalArticulos;
            public DataTable Articulos;
            public DataTable Cajeros;
            public bool HayVenta;
        }

        public struct UserInfo { //ESTRUCTURA PARA GUARDAR INFORMACION DE UN USUARIO...
            public string Nombre;
            public string Login;
            public string Password;
            public string Tipo;
            public string Fecha;
            public bool EXIST;
        }

        #endregion

        #region  <PROPIEDADES>

        //Propiedades para consultar la informacion del usuario logueado
        public static string Usr {
            get {
                return _Usr;
            }
        }
        public static string Nombre {
            get {
                return _Nombre;
            }
        }
        public static string Tipo {
            get {
                return _Tipo;
            }
        }
        public static string CajeroId {
            get {
                return _Id;
            }
        }

        #endregion

        #region  <CONSTRUCTOR DE LA CLASE>
        //Constructor de la clase
        static PuntoDeVentas() {

            try {

                //Si la conexion no esta abierta la abrimos
                if (_objConn.State != ConnectionState.Open) {
                    _objConn.Open();//Abrimos la conexion si no esta en el estado open.
                }

            } catch (OleDbException OleDbEx) {
                throw OleDbEx;

            } catch (Exception ex) {
                throw ex;
            }

            _objCmd.Connection = _objConn;

            //Agregamos el evento PrintPage ala funcion PrintTiketPage
            _PrintTiket.PrintPage += new PrintPageEventHandler(PrintTiketPage);

        }
        #endregion

        #region  <FUNCIONES PUBLICAS>

        //Funcion para validar si un usuario existe en el login
        public static bool ValidarUsuario(string Login, string Password) {
            //consulta para validar si el usuario existe!
            string Qry =
            " SELECT [USR_ID],[LOGIN],[NOMBRE],[TIPO] FROM [TBL_USUARIOS]" +
            " WHERE LOGIN='@LOGIN' AND PASSWORD='@PWD'";
            DataTable TblResult;
            Qry = Qry.Replace("@LOGIN", Login.Replace("'", ""));//Remplazamos el Texto @LOGIN EN LA  VARIABLE QRY
            Qry = Qry.Replace("@PWD", Password.Replace("'", ""));//Remplazamos el Texto @PWD EN LA  VARIABLE QRY

            TblResult = Fill(Qry, "Results");//Llamanos a la funcion para llenar la tabla.

            if (TblResult.Rows.Count > 0) {
                //Guardar informacion del usuario logueado
                _Usr = TblResult.Rows[0]["LOGIN"].ToString();
                _Nombre = TblResult.Rows[0]["NOMBRE"].ToString();
                _Tipo = TblResult.Rows[0]["TIPO"].ToString();
                _Id = TblResult.Rows[0]["USR_ID"].ToString();
                return true;
            } else {
                //Regresamos False si no tiene registros la tabla de resultados
                return false;
            }
        }
        //Funcion para obtener configuraciones de la tabla TBL_CONFIG
        public static string GetConfig(string Config_Name) {
            DataTable TblResult;
            string Qry =
            " SELECT [CONFIG_VALUE] FROM [TBL_CONFIG]" +
            " WHERE [CONFIG_NAME]='@CONFIG_NAME'";
            Qry = Qry.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));

            TblResult = Fill(Qry, "TblConfig");

            if (TblResult.Rows.Count > 0) {
                return TblResult.Rows[0][0].ToString();
            } else {
                return "";
            }
        }
        //FUNCION PARA ACTUALIZAR UNA CONFIGURACION EN LA TABLA CONFIG
        public static int UpdateConfig(string Config_Name, string Config_Value) {

            string QryUpdate =
            " UPDATE TBL_CONFIG" +
            " SET CONFIG_VALUE='@CONFIG_VALUE'" +
            " WHERE CONFIG_NAME='@CONFIG_NAME'";
            QryUpdate = QryUpdate.Replace("@CONFIG_VALUE", Config_Value);
            QryUpdate = QryUpdate.Replace("@CONFIG_NAME", Config_Name);

            string QryExist =
            " SELECT CONFIG_NAME FROM TBL_CONFIG" +
            " WHERE CONFIG_NAME='@CONFIG_NAME'";
            DataTable tblResult;
            QryExist = QryExist.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));
            tblResult = Fill(QryExist, "tblResult");

            string QryInsert =
            " INSERT INTO TBL_CONFIG (CONFIG_NAME,CONFIG_VALUE) VALUES('@CONFIG_NAME','@CONFIG_VALUE')";
            QryInsert = QryInsert.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));
            QryInsert = QryInsert.Replace("@CONFIG_VALUE", Config_Value.Replace("'", ""));

            if (tblResult.Rows.Count > 0) {
                return Execute(QryUpdate);
            } else {
                return Execute(QryInsert);
            }



        }
        //Funcion para obtener la informacion del un articulo
        public static ArticuloInfo GetArticuloInfo(string ArticuloId) {
            ArticuloInfo info = new ArticuloInfo();
            DataTable TblResult;
            string Qry = "SELECT * FROM [TBL_ARTICULOS] WHERE [ARTICULO_ID]='@ART_ID'";
            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0) {
                info.EXIST = true;
                info.ID = TblResult.Rows[0]["ARTICULO_ID"].ToString();
                info.DESCRIPCION = TblResult.Rows[0]["DESCRIPCION"].ToString();
                info.PRECIO = TblResult.Rows[0]["PRECIO"].ToString();
                info.INV = TblResult.Rows[0]["INV"].ToString();
                info.UNIDAD = TblResult.Rows[0]["UNIDAD"].ToString();
            } else {
                info.EXIST = false;
                info.PRECIO = "0";

            }
            return info;
        }
        //Funcion para agregar un nuevo articulo ala Bd.
        public static bool UpdateArticulo(string Id, string Descripcion, string Unidad, string Precio, bool Inv) {
            string QryInsert = //ESTA INSTRUCCION SQL ES PARA INSERTAR UN ARTICULO EN LA BD.
           " INSERT INTO TBL_ARTICULOS (ARTICULO_ID,DESCRIPCION,UNIDAD,PRECIO,INV)" +
           " VALUES('@ID','@DESCRIPCION','@UNIDAD','@PRECIO','@INV')";
            string QryUpdate =
            " UPDATE TBL_ARTICULOS" +
            " SET ARTICULO_ID='@ID',DESCRIPCION='@DESCRIPCION',UNIDAD='@UNIDAD',PRECIO='@PRECIO',INV='@INV'" +
            " WHERE ARTICULO_ID='@ID'";

            //Validamos si no esta registrado ya este articulo
            if (GetArticuloInfo(Id).EXIST) { //Llamamos a la funcion GetArticuloInfo para saber si existe
                QryUpdate = QryUpdate.Replace("@ID", Id.Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@DESCRIPCION", Descripcion.ToUpper().Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@PRECIO", Precio.Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@UNIDAD", Unidad.ToUpper().Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@INV", Convert.ToInt16(Inv).ToString());//Convertimos a entero la variable bool para que guarde 1 o 0

                if (Execute(QryUpdate) > 0)//Mandamos a llamar la funcion Execute para ejecutar la instruccion SQL
                {
                    return true;//Retornamos True si la funcion _Execute nos regresa mas 0

                } else {
                    return false;//Retornamos False si la funcion no nos regreso nada
                }


            } else {
                //Remplazamos los valores en la de la instruccion por los valores a insertar
                QryInsert = QryInsert.Replace("@ID", Id.Replace(",", ""));
                QryInsert = QryInsert.Replace("@DESCRIPCION", Descripcion.ToUpper().Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@PRECIO", Precio.Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@UNIDAD", Unidad.ToUpper().Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@INV", Convert.ToInt16(Inv).ToString());//Convertimos a entero la variable bool para que guarde 1 o 0

                if (Execute(QryInsert) > 0)//Mandamos a llamar la funcion Execute para ejecutar la instruccion SQL
                {
                    return true;//Retornamos True si la funcion _Execute nos regresa mas 0

                } else {
                    return false;//Retornamos False si la funcion no nos regreso nada
                }

            }

        }
        //Funcion Para buscar un articulo por descripcion en la Bd
        public static DataTable BuscarArticulo(string Buscar) {
            DataTable TblResult;
            string QryBuscar = "SELECT ARTICULO_ID AS [CODIGO],DESCRIPCION,UNIDAD,PRECIO FROM TBL_ARTICULOS WHERE DESCRIPCION LIKE '%@BUSCAR%'";
            QryBuscar = QryBuscar.Replace("@BUSCAR", Buscar.Replace("'", ""));
            TblResult = Fill(QryBuscar, "TblResultados");
            return TblResult;
        }
        //BUSCA UN ARTICULO EN LA VISTA DE INVENTARIO
        public static DataTable BuscarInventarioArticulo(string Buscar) {
            DataTable TblResult;
            string QryBuscar = "SELECT * FROM TBL_INVENTARIO_VIEW WHERE DESCRIPCION LIKE '%@BUSCAR%'";
            QryBuscar = QryBuscar.Replace("@BUSCAR", Buscar.Replace("'", ""));
            TblResult = Fill(QryBuscar, "TblResultados");
            return TblResult;
        }
        //Registra el Articulo en la base de datos!
        public static int RegistrarArticulo(string Id, string Descripcion, string Precio, string Cantidad, string Total, string UsrId) {

            string Qry =
            " INSERT INTO TBL_VENTAS ([ARTICULO_ID],[DESCRIPCION],[PRECIO],[CANTIDAD],[TOTAL],[USR_ID],[OPEN],[FECHA])" +
            " VALUES('@ID','@DESCRIPCION','@PRECIO','@CANTIDAD','@TOTAL','@USR','1',NOW())";
            Qry = Qry.Replace("@ID", Id);
            Qry = Qry.Replace("@DESCRIPCION", Descripcion);
            Qry = Qry.Replace("@PRECIO", Precio);
            Qry = Qry.Replace("@USR", UsrId);
            Qry = Qry.Replace("@CANTIDAD", Cantidad);
            Qry = Qry.Replace("@TOTAL", Total);

            return Execute(Qry);

        }
        //REGISTRA UN ARTICULO AL SYSTEMA DE INVETARIO
        public static int InvRegistrarArticulo(string Id, string Entrada, string Salida, string UsrId, string TransType) {
            string Qry =
           " INSERT INTO TBL_INVENTARIO (ARTICULO_ID,ENTRADA,SALIDA,FECHA,USR_ID,TRANS_TYPE)" +
           " VALUES('@ART_ID','@ENTRADA','@SALIDA',NOW(),'@USR_ID','@TRANS_TYPE')";

            Qry = Qry.Replace("@ART_ID", Id);
            Qry = Qry.Replace("@ENTRADA", Entrada);
            Qry = Qry.Replace("@SALIDA", Salida);
            Qry = Qry.Replace("@USR_ID", UsrId);
            Qry = Qry.Replace("@TRANS_TYPE", TransType);
            return Execute(Qry);
        }
        //Obtiene el Historial del inventario de un Articulo
        public static DataTable GetInvHistorial(string ArticuloId) {
            string Qry = "SELECT A.*,B.NOMBRE AS USUARIO FROM TBL_INVENTARIO AS A INNER JOIN TBL_USUARIOS AS B ON A.USR_ID =B.USR_ID WHERE ARTICULO_ID='@ART_ID'";
            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace(",", ""));
            return Fill(Qry, "TblResult");
        }
        //Obtiene la informacion para el corte de caja
        public static CorteDeCajaInfo GetCorteDeCaja(string UsrId) {
            DataTable TblResult;
            CorteDeCajaInfo CorteDeCaja = new CorteDeCajaInfo();//Declaramos una variable del tipo de la estructura CorteDeCajaInfo
            // EN LA TABLA TBL_VENTAS EL CAMPO OPEN REPRESENTA EL ESTADO DE LA CAJA
            // OPEN = TRUE QUIEERE DECIR QUE LA CAA SIGUE ABIERTA
            //OPEN = FALSE QUIERE DECIR QUE LA CAJ ESTA CERRADA
            //CONSULTAMOS TODO LO QUE ESTE OPEN =  TRUE QUE ES LO QUE HAA VENDIDO EL CAJERO HASTA EL MOMENTO
            //CUANDO CERREMOS LA CAJA OPEN SERA = FALSE

            string QryArtVendidos = //CONSULTA PARA OBTENER TODAS LAS TRANSACCIONES DEL CAJERO
            " SELECT B.NOMBRE,A.* " +
            " FROM TBL_VENTAS AS A INNER JOIN TBL_USUARIOS AS B " +
            " ON A.USR_ID =B.USR_ID" +
            " WHERE A.USR_ID= @USR_ID  AND A.[OPEN]= True ";
            string QryTotal =//CONSULTA PARA OBTENER EL TOTAL DE LO QUE VENDIO EL CAJERO
            " SELECT B.NOMBRE,SUM(A.CANTIDAD) AS [TOTAL_ARTICULOS],SUM(A.TOTAL) AS [TOTAL_VENDIDO]" +
            " FROM TBL_VENTAS AS A INNER JOIN TBL_USUARIOS AS B" +
            " ON A.USR_ID = B.USR_ID" +
            " WHERE A.USR_ID= @USR_ID AND A.[OPEN]= True" +
            " GROUP BY B.NOMBRE";

            QryArtVendidos = QryArtVendidos.Replace("@USR_ID", UsrId.Replace("'", ""));
            QryTotal = QryTotal.Replace("@USR_ID", UsrId.Replace("'", ""));

            CorteDeCaja.Articulos = new DataTable();

            CorteDeCaja.Articulos = Fill(QryArtVendidos, "ARTICULOS_VENDIDOS");//Llenamos los articulos vendidos por el cajero
            TblResult = Fill(QryTotal, "TOTAL");//OBTENEMOS EL TOTAL DE LO VENDIDO POR EL CAJERO

            if (TblResult.Rows.Count > 0) {
                CorteDeCaja.NomCajero = TblResult.Rows[0]["NOMBRE"].ToString().ToUpper();
                CorteDeCaja.CajeroExist = true;
                CorteDeCaja.Total = Convert.ToDouble(TblResult.Rows[0]["TOTAL_VENDIDO"].ToString());
                CorteDeCaja.TotalArticulos = Convert.ToInt16(TblResult.Rows[0]["TOTAL_ARTICULOS"].ToString());
            } else {
                CorteDeCaja.Total = 0;
                CorteDeCaja.TotalArticulos = 0;
                CorteDeCaja.CajeroExist = false;
                CorteDeCaja.NomCajero = "";
            }


            return CorteDeCaja;
        }
        //CERRAR LA CAJE DEL CAJERO
        public static bool CerrarCaja(string UsrId) {
            string QryCerrarCaja =//CONSULTA PARA CERRAR LA CAJA DEL CAJERO
            " UPDATE TBL_VENTAS " +
            " SET [OPEN]= False,[CORTE_DE_CAJA]=NOW()" +
            " WHERE USR_ID= @USR_ID AND [OPEN]= True ";
            QryCerrarCaja = QryCerrarCaja.Replace("@USR_ID", UsrId.Replace("'", ""));
            if (Execute(QryCerrarCaja) > 0)//EJECUTAMOS LA CONSULTA , SI HAY HAY REGISTROS AFECTADOS NOS REGRESA EL TOTAL DE REGISTROS AFECTADO POR LA CONSULTA
            {
                return true;
            } else {
                return false;
            }

        }
        //OBTIENE EL STOCK ACTUAL DE LOS ARTICULOS
        public static DataTable GerArticulosStock() {
            string Qry = "SELECT * FROM TBL_STOCK_VIEW";
            return Fill(Qry, "TBL_STOCK");
        }
        //OBTENEMOS LA INFORMACION DE LA VENTA DEL DIA
        public static VentadelDia GetVentaDelDia() {
            VentadelDia Info = new VentadelDia();
            DataTable TblResult;
            string QryVentaDelDia = "SELECT * FROM  TBL_VENTA_DEL_DIA_VIEW";
            string QryArticulosVendidos = "SELECT * FROM TBL_VENTA_DEL_DIA_X_ARTICULO";
            string QryVentaDeCajeros = "SELECT * FROM TBL_VENTA_DEL_DIA_X_CAJERO_VIEW";

            TblResult = Fill(QryVentaDelDia, "VENTA_DEL_DIA");
            Info.Articulos = Fill(QryArticulosVendidos, "ARTICULOS_VENDIDOS");
            Info.Cajeros = Fill(QryVentaDeCajeros, "VENTA_X_CAJEROS");

            if (TblResult.Rows.Count > 0) {
                Info.HayVenta = true;
                if (Equals(TblResult.Rows[0]["VENTA_TOTAL"], System.DBNull.Value)) {
                    Info.HayVenta = false;
                    return Info;
                }
                Info.Total = Convert.ToDouble(TblResult.Rows[0]["VENTA_TOTAL"].ToString());
                Info.TotalArticulos = Convert.ToDouble(TblResult.Rows[0]["TOTAL_ARTICULOS"].ToString());

            } else {
                Info.HayVenta = false;
            }

            return Info;
        }
        //GUARDA UN LOGIN DE USUARIO EN LA BD
        public static bool GuardarUsuario(string Nombre, string Login, string Password, string Tipo) {
            DataTable TblResult;
            string QryExist =
            "SELECT LOGIN FROM TBL_USUARIOS WHERE LOGIN='@LOGIN'";
            string QryUpdate =
            " UPDATE TBL_USUARIOS" +
            " SET [LOGIN]='@LOGIN',[NOMBRE]='@NOMBRE',[PASSWORD]='@PASS',[TIPO]='@TIPO',[FECHA]=NOW()" +
            " WHERE LOGIN='@LOGIN'";
            string QryInsert =
            " INSERT INTO TBL_USUARIOS ([NOMBRE],[LOGIN],[PASSWORD],[TIPO],[FECHA])" +
            " VALUES('@NOMBRE','@LOGIN','@PASSWORD','@TIPO',NOW())";

            QryExist = QryExist.Replace("@LOGIN", Login.Replace("'", ""));

            QryUpdate = QryUpdate.Replace("@LOGIN", Login.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@NOMBRE", Nombre.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@PASS", Password.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@TIPO", Tipo.Replace("'", ""));

            QryInsert = QryInsert.Replace("@LOGIN", Login.Replace("'", ""));
            QryInsert = QryInsert.Replace("@NOMBRE", Nombre.Replace("'", ""));
            QryInsert = QryInsert.Replace("@PASSWORD", Password.Replace("'", ""));
            QryInsert = QryInsert.Replace("@TIPO", Tipo.Replace("'", ""));

            TblResult = Fill(QryExist, "TblResult");

            if (TblResult.Rows.Count > 0) {
                if (Execute(QryUpdate) > 0) {
                    return true;
                } else {
                    return false;
                }
            } else {
                if (Execute(QryInsert) > 0) {
                    return true;
                } else {
                    return false;
                }
            }




        }
        //OBTENEMOS INFORMACION DE UN USUARIO                      
        public static UserInfo GetUserInfo(string UsrId) {
            UserInfo Info = new UserInfo();
            DataTable TblResult;
            string Qry = "SELECT * FROM TBL_USUARIOS WHERE USR_ID= @USR_ID";
            Qry = Qry = Qry.Replace("@USR_ID", UsrId);
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0) {
                Info.EXIST = true;
                Info.Nombre = TblResult.Rows[0]["NOMBRE"].ToString();
                Info.Login = TblResult.Rows[0]["LOGIN"].ToString();
                Info.Password = TblResult.Rows[0]["PASSWORD"].ToString();
                Info.Fecha = TblResult.Rows[0]["FECHA"].ToString();
                Info.Tipo = TblResult.Rows[0]["TIPO"].ToString();
            } else {
                Info.EXIST = false;
            }
            return Info;
        }
        //BUSCA EL NOMBRE DE UN USUARIO EN LA DB
        public static DataTable BuscarUsuario(string Nombre) {
            string Qry = "SELECT USR_ID as ID,LOGIN AS USUARIO,NOMBRE,TIPO,FECHA FROM TBL_USUARIOS WHERE NOMBRE LIKE '%@BUSCAR%' OR LOGIN LIKE '%@BUSCAR%'";
            DataTable TblResult;

            Qry = Qry.Replace("@BUSCAR", Nombre.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");
            return TblResult;
        }
        //Obtiene todos lo pedidos no cancelados
        public static DataTable GetPedidos() {
            string Qry = "SELECT * FROM TBL_PEDIDOS_VIEW";
            return Fill(Qry, "TblPedidos");
        }
        //elimina un pedido de la lista
        public static void CambiarStatus(string No, string Status) {
            string QryUpdate = "UPDATE TBL_PEDIDOS SET STATUS='@STATUS' WHERE ID= @NO";
            QryUpdate = QryUpdate.Replace("@NO", No.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@STATUS", Status.Replace("'", ""));

            Execute(QryUpdate);
        }
        //AGREGA UN PEDIDO A LA TABLA DE PEDIDOS
        public static bool AgregarPedido(string UsrId, string ArticuloId, string Cantidad, string Nombre) {
            string Qry =
            " INSERT INTO TBL_PEDIDOS (USR_ID,ARTICULO_ID,CANTIDAD,CLIENTE_NOM,FECHA,STATUS)" +
            " VALUES('@USR_ID','@ARTICULO_ID','@CANTIDAD','@CLIENTE_NOMBRE',NOW(),'ABIERTO')";
            Qry = Qry.Replace("@USR_ID", UsrId);
            Qry = Qry.Replace("@ARTICULO_ID", ArticuloId);
            Qry = Qry.Replace("@CANTIDAD", Cantidad);
            Qry = Qry.Replace("@CLIENTE_NOMBRE", Nombre.Replace(",", ""));
            if (Execute(Qry) > 0) {
                return true;
            } else {
                return false;
            }



        }

        #endregion

        #region  <FUNCION PARA IMPRIMR EL TIKET>

        private static DataTable _ArticulosList = new DataTable();
        private static string _Total = "";//Total de la venta
        private static string _Pago = "";//Pago del efectivo 
        private static string _Cambio = "";//Cambio del cliente

        //Propiedad para establecer los articulos a imprimir
        public static DataTable ArticulosParaImprimir {
            set {
                _ArticulosList = value;
            }
        }
        //Imprime el Tiket
        public static void ImprimirTiket(string Total, string Pago, string Cambio) {
            try {
                _Total = Total;
                _Pago = Pago;
                _Cambio = Cambio;
                _PrintTiket.Print();
            } catch (Exception ex) {
                throw (ex);
            }

        }

        private static void PrintTiketPage(object sender, PrintPageEventArgs e) {
            try {
                int PosX = 0;
                int PosY = 31;
                int TituloTam = 16;
                int PiedePagTam = 12;
                string Titulo = System.PuntoDeVentas.GetConfig("EMPRESA").ToUpper();//Obtenemos el nombre de la empresa de la base de datos
                string PiedeTiket = "Gracias por su compra!";

                Font font1 = new Font("Consolas", 12f, FontStyle.Regular);
                Font font2 = new Font("Consolas", (float)PiedePagTam, FontStyle.Regular);
                Font font4 = new Font("Courier New", 8f, FontStyle.Bold);
                Font font5 = new Font("Courier New", 10f, FontStyle.Bold);
                Font font6 = new Font("Courier New", 8f, FontStyle.Regular);
                Font font7 = new Font("Courier New", 7f, FontStyle.Bold);
                Font font8 = new Font("Consolas", (float)TituloTam, FontStyle.Bold);
                Font font9 = new Font("Courier New", 8f, FontStyle.Bold);

                string Cajero = "Le Atendio : " + Nombre;//Nombre del Cajero
                e.PageSettings.Margins.Top = 0;
                e.PageSettings.Margins.Left = 0;
                e.PageSettings.Margins.Right = 0;
                e.Graphics.DrawString(Titulo, font8, Brushes.Black, PosX, PosY);
                PosY = PosY + 30;
                e.Graphics.DrawString("FECHA : " + DateTime.Now.ToString("dddd, dd-MMMM-yyyy").ToUpper(), font7, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString(Cajero, font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("-------------------------------------------------", font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                int iCount = 1;
                foreach (DataRow dataRow in _ArticulosList.Rows) {

                    string Articulo = iCount.ToString() + "-" + dataRow["DESC"].ToString();
                    string Cantidad = "CANT.: " + (Convert.ToDouble(dataRow["CANTIDAD"].ToString()).ToString("00.00") + " @ $" + (Convert.ToDouble(dataRow["PRECIO"].ToString())).ToString("00.00") + " = $" + (Convert.ToDouble(dataRow["TOTAL"].ToString())).ToString("00.00"));

                    e.Graphics.DrawString(Articulo, font5, Brushes.Black, PosX, PosY);
                    PosY += 14;
                    e.Graphics.DrawString(Cantidad, font6, Brushes.Black, PosX, PosY);
                    PosY += 14;
                    iCount++;
                }
                e.Graphics.DrawString("-------------------------------------------------", font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("TOTAL    : $ " + _Total.ToString(), font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("EFECTIVO : " + _Pago.ToString(), font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("SU CAMBIO! " + _Cambio, font2, Brushes.Black, PosX, PosY);
                PosY = PosY + 16;
                e.Graphics.DrawString(PiedeTiket, font2, Brushes.Black, PosX, PosY);//Pie de tiket
                PosY = PosY + 24;
                //Fecha y Hra
                e.Graphics.DrawString(">" + DateTime.Now.ToString("dd-MMMM-yyyy hh:mm:ss tt").ToUpper(), font9, Brushes.Black, PosX, PosY);

            } catch (Exception ex) {
                throw new Exception("Erro al imprimir Tiket.\nError Msg:\n" + ex.Message);
            }
        }
        #endregion

        #region  <FUNCIONES ESPECIALES>
        //Esta funcion es para llenar una tabla
        public static DataTable Fill(string Qry, string TableName) {
            DataTable TblResult = new DataTable(TableName); //Tabla para guardar el resultado!.
            OleDbDataReader Reader;
            _objCmd.CommandText = Qry;//Le pasamos la consulta, para poder extraer los datos
            Reader = _objCmd.ExecuteReader();//Executamos la Qry
            TblResult.Load(Reader, LoadOption.OverwriteChanges);//Llenamos los datos a la tabla
            Reader.Close();//cerramos el datareader para que no se quede abierto
            return TblResult;//Retornamos el datatable
        }
        public static int Execute(string Qry) {
            _objCmd.CommandText = Qry;
            return _objCmd.ExecuteNonQuery();
        }
        #endregion

    }


}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Namespace usado para poder hacer la conexion
using System.Data.OleDb;
using System.Data;

using System.Drawing;
using System.Drawing.Printing;

namespace System
{

    public static class PuntoDeVentas //Clase para hacer consultas a nuestra base de datos
    {

        #region  <DECLARACIONES GLOBALES>

        //Cadena de conexion hacia la base de datos access
        private static string _strCadenaDeConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DB\dbVentas.accdb;Persist Security Info=True";
        //Objeto de conexion para hacer las consultas
        private static OleDbConnection _objConn = new OleDbConnection(_strCadenaDeConexion);
        //Objeto para ejecutar las consulas hacia Bd.
        private static OleDbCommand _objCmd = new OleDbCommand();

        private static PrintDocument _PrintTiket = new PrintDocument();

        //Informacion de el usuario logueado!
        private static string _Usr = "";//Usuario
        private static string _Nombre = "";//Nombre
        private static string _Tipo = "";//Tipo
        private static string _Id = ""; //Id del usuario

        public struct ArticuloInfo//Estructura para guardar la informacion de un articulo 
        {
            public string ID;
            public string DESCRIPCION;
            public string PRECIO;
            public string INV;
            public string UNIDAD;
            public bool EXIST;//si el articulo existe devuelve true
        }

        public struct CorteDeCajaInfo// ESTRUCTURA PARA GUARDAR INFORMACION DEL CORTE DE CAJA
        {
            public string NomCajero;
            public DataTable Articulos;
            public Double Total;
            public int TotalArticulos;
            public bool CajeroExist;//si el cajero existe devuelve true
        }
        public struct VentadelDia
        {//En para guardar la venta del dia
            public double Total;
            public double TotalArticulos;
            public DataTable Articulos;
            public DataTable Cajeros;
            public bool HayVenta;
        }

        public struct UserInfo
        { //ESTRUCTURA PARA GUARDAR INFORMACION DE UN USUARIO...
            public string Nombre;
            public string Login;
            public string Password;
            public string Tipo;
            public string Fecha;
            public bool EXIST;
        }

        #endregion

        #region  <PROPIEDADES>

        //Propiedades para consultar la informacion del usuario logueado
        public static string Usr
        {
            get
            {
                return _Usr;
            }
        }
        public static string Nombre
        {
            get
            {
                return _Nombre;
            }
        }
        public static string Tipo
        {
            get
            {
                return _Tipo;
            }
        }
        public static string CajeroId
        {
            get
            {
                return _Id;
            }
        }

        #endregion

        #region  <CONSTRUCTOR DE LA CLASE>
        //Constructor de la clase
        static PuntoDeVentas()
        {
            //Si la conexion no esta abierta la abrimos
            if (_objConn.State != ConnectionState.Open)
            {
                _objConn.Open();//Abrimos la conexion si no esta en el estado open.
            }

            _objCmd.Connection = _objConn;

            //Agregamos el evento PrintPage ala funcion PrintTiketPage
            _PrintTiket.PrintPage += new PrintPageEventHandler(PrintTiketPage);

        }
        #endregion

        #region  <FUNCIONES PUBLICAS>

        //Funcion para validar si un usuario existe en el login
        public static bool ValidarUsuario(string Login, string Password)
        {
            //consulta para validar si el usuario existe!
            string Qry =
            " SELECT [USR_ID],[LOGIN],[NOMBRE],[TIPO] FROM [TBL_USUARIOS]" +
            " WHERE LOGIN='@LOGIN' AND PASSWORD='@PWD'";
            DataTable TblResult;
            Qry = Qry.Replace("@LOGIN", Login.Replace("'", ""));//Remplazamos el Texto @LOGIN EN LA  VARIABLE QRY
            Qry = Qry.Replace("@PWD", Password.Replace("'", ""));//Remplazamos el Texto @PWD EN LA  VARIABLE QRY

            TblResult = Fill(Qry, "Results");//Llamanos a la funcion para llenar la tabla.

            if (TblResult.Rows.Count > 0)
            {
                _Usr = TblResult.Rows[0]["LOGIN"].ToString();
                _Nombre = TblResult.Rows[0]["NOMBRE"].ToString();
                _Tipo = TblResult.Rows[0]["TIPO"].ToString();
                _Id = TblResult.Rows[0]["USR_ID"].ToString();
                return true;
            }
            else
            {
                //Regresamos False si no tiene registros la tabla de resultados
                return false;
            }
        }
        //Funcion para obtener configuraciones de la tabla TBL_CONFIG
        public static string GetConfig(string Config_Name)
        {
            DataTable TblResult;
            string Qry =
            " SELECT [CONFIG_VALUE] FROM [TBL_CONFIG]" +
            " WHERE [CONFIG_NAME]='@CONFIG_NAME'";
            Qry = Qry.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));

            TblResult = Fill(Qry, "TblConfig");

            if (TblResult.Rows.Count > 0)
            {
                return TblResult.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }
        //FUNCION PARA ACTUALIZAR UNA CONFIGURACION EN LA TABLA CONFIG
        public static int UpdateConfig(string Config_Name, string Config_Value)
        {

            string QryUpdate =
            " UPDATE TBL_CONFIG" +
            " SET CONFIG_VALUE='@CONFIG_VALUE'" +
            " WHERE CONFIG_NAME='@CONFIG_NAME'";
            QryUpdate = QryUpdate.Replace("@CONFIG_VALUE", Config_Value);
            QryUpdate = QryUpdate.Replace("@CONFIG_NAME", Config_Name);

            string QryExist =
            " SELECT CONFIG_NAME FROM TBL_CONFIG" +
            " WHERE CONFIG_NAME='@CONFIG_NAME'";
            DataTable tblResult;
            QryExist = QryExist.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));
            tblResult = Fill(QryExist, "tblResult");

            string QryInsert =
            " INSERT INTO TBL_CONFIG (CONFIG_NAME,CONFIG_VALUE) VALUES('@CONFIG_NAME','@CONFIG_VALUE')";
            QryInsert = QryInsert.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));
            QryInsert = QryInsert.Replace("@CONFIG_VALUE", Config_Value.Replace("'", ""));

            if (tblResult.Rows.Count > 0)
            {
                return Execute(QryUpdate);
            }
            else
            {
                return Execute(QryInsert);
            }



        }
        //Funcion para obtener la informacion del un articulo
        public static ArticuloInfo GetArticuloInfo(string ArticuloId)
        {
            ArticuloInfo info = new ArticuloInfo();
            DataTable TblResult;
            string Qry = "SELECT * FROM [TBL_ARTICULOS] WHERE [ARTICULO_ID]='@ART_ID'";
            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0)
            {
                info.EXIST = true;
                info.ID = TblResult.Rows[0]["ARTICULO_ID"].ToString();
                info.DESCRIPCION = TblResult.Rows[0]["DESCRIPCION"].ToString();
                info.PRECIO = TblResult.Rows[0]["PRECIO"].ToString();
                info.INV = TblResult.Rows[0]["INV"].ToString();
                info.UNIDAD = TblResult.Rows[0]["UNIDAD"].ToString();
            }
            else
            {
                info.EXIST = false;
                info.PRECIO = "0";

            }
            return info;
        }
        //Funcion para agregar un nuevo articulo ala Bd.
        public static bool UpdateArticulo(string Id, string Descripcion, string Unidad, string Precio, bool Inv)
        {
            string QryInsert = //ESTA INSTRUCCION SQL ES PARA INSERTAR UN ARTICULO EN LA BD.
           " INSERT INTO TBL_ARTICULOS (ARTICULO_ID,DESCRIPCION,UNIDAD,PRECIO,INV)" +
           " VALUES('@ID','@DESCRIPCION','@UNIDAD','@PRECIO','@INV')";
            string QryUpdate =
            " UPDATE TBL_ARTICULOS" +
            " SET ARTICULO_ID='@ID',DESCRIPCION='@DESCRIPCION',UNIDAD='@UNIDAD',PRECIO='@PRECIO',INV='@INV'" +
            " WHERE ARTICULO_ID='@ID'";

            //Validamos si no esta registrado ya este articulo
            if (GetArticuloInfo(Id).EXIST)
            { //Llamamos a la funcion GetArticuloInfo para saber si existe
                QryUpdate = QryUpdate.Replace("@ID", Id.Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@DESCRIPCION", Descripcion.ToUpper().Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@PRECIO", Precio.Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@UNIDAD", Unidad.ToUpper().Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@INV", Convert.ToInt16(Inv).ToString());//Convertimos a entero la variable bool para que guarde 1 o 0

                if (Execute(QryUpdate) > 0)//Mandamos a llamar la funcion Execute para ejecutar la instruccion SQL
                {
                    return true;//Retornamos True si la funcion _Execute nos regresa mas 0

                }
                else
                {
                    return false;//Retornamos False si la funcion no nos regreso nada
                }


            }
            else
            {
                //Remplazamos los valores en la de la instruccion por los valores a insertar
                QryInsert = QryInsert.Replace("@ID", Id.Replace(",", ""));
                QryInsert = QryInsert.Replace("@DESCRIPCION", Descripcion.ToUpper().Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@PRECIO", Precio.Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@UNIDAD", Unidad.ToUpper().Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@INV", Convert.ToInt16(Inv).ToString());//Convertimos a entero la variable bool para que guarde 1 o 0

                if (Execute(QryInsert) > 0)//Mandamos a llamar la funcion Execute para ejecutar la instruccion SQL
                {
                    return true;//Retornamos True si la funcion _Execute nos regresa mas 0

                }
                else
                {
                    return false;//Retornamos False si la funcion no nos regreso nada
                }

            }

        }
        //Funcion Para buscar un articulo por descripcion en la Bd
        public static DataTable BuscarArticulo(string Buscar)
        {
            DataTable TblResult;
            string QryBuscar = "SELECT ARTICULO_ID AS [CODIGO],DESCRIPCION,UNIDAD,PRECIO FROM TBL_ARTICULOS WHERE DESCRIPCION LIKE '%@BUSCAR%'";
            QryBuscar = QryBuscar.Replace("@BUSCAR", Buscar.Replace("'", ""));
            TblResult = Fill(QryBuscar, "TblResultados");
            return TblResult;
        }
        //BUSCA UN ARTICULO EN LA VISTA DE INVENTARIO
        public static DataTable BuscarInventarioArticulo(string Buscar)
        {
            DataTable TblResult;
            string QryBuscar = "SELECT * FROM TBL_INVENTARIO_VIEW WHERE DESCRIPCION LIKE '%@BUSCAR%'";
            QryBuscar = QryBuscar.Replace("@BUSCAR", Buscar.Replace("'", ""));
            TblResult = Fill(QryBuscar, "TblResultados");
            return TblResult;
        }
        //Registra el Articulo en la base de datos!
        public static int RegistrarArticulo(string Id, string Descripcion, string Precio, string Cantidad, string Total, string UsrId)
        {

            string Qry =
            " INSERT INTO TBL_VENTAS ([ARTICULO_ID],[DESCRIPCION],[PRECIO],[CANTIDAD],[TOTAL],[USR_ID],[OPEN],[FECHA])" +
            " VALUES('@ID','@DESCRIPCION','@PRECIO','@CANTIDAD','@TOTAL','@USR','1',NOW())";
            Qry = Qry.Replace("@ID", Id);
            Qry = Qry.Replace("@DESCRIPCION", Descripcion);
            Qry = Qry.Replace("@PRECIO", Precio);
            Qry = Qry.Replace("@USR", UsrId);
            Qry = Qry.Replace("@CANTIDAD", Cantidad);
            Qry = Qry.Replace("@TOTAL", Total);

            return Execute(Qry);

        }
        //REGISTRA UN ARTICULO AL SYSTEMA DE INVETARIO
        public static int InvRegistrarArticulo(string Id, string Entrada, string Salida, string UsrId, string TransType)
        {
            string Qry =
           " INSERT INTO TBL_INVENTARIO (ARTICULO_ID,ENTRADA,SALIDA,FECHA,USR_ID,TRANS_TYPE)" +
           " VALUES('@ART_ID','@ENTRADA','@SALIDA',NOW(),'@USR_ID','@TRANS_TYPE')";

            Qry = Qry.Replace("@ART_ID", Id);
            Qry = Qry.Replace("@ENTRADA", Entrada);
            Qry = Qry.Replace("@SALIDA", Salida);
            Qry = Qry.Replace("@USR_ID", UsrId);
            Qry = Qry.Replace("@TRANS_TYPE", TransType);
            return Execute(Qry);
        }
        //Obtiene el Historial del inventario de un Articulo
        public static DataTable GetInvHistorial(string ArticuloId)
        {
            string Qry = "SELECT A.*,B.NOMBRE AS USUARIO FROM TBL_INVENTARIO AS A INNER JOIN TBL_USUARIOS AS B ON A.USR_ID =B.USR_ID WHERE ARTICULO_ID='@ART_ID'";
            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace(",", ""));
            return Fill(Qry, "TblResult");
        }
        //Obtiene la informacion para el corte de caja
        public static CorteDeCajaInfo GetCorteDeCaja(string UsrId)
        {
            DataTable TblResult;
            CorteDeCajaInfo CorteDeCaja = new CorteDeCajaInfo();//Declaramos una variable del tipo de la estructura CorteDeCajaInfo
            // EN LA TABLA TBL_VENTAS EL CAMPO OPEN REPRESENTA EL ESTADO DE LA CAJA
            // OPEN = TRUE QUIEERE DECIR QUE LA CAA SIGUE ABIERTA
            //OPEN = FALSE QUIERE DECIR QUE LA CAJ ESTA CERRADA
            //CONSULTAMOS TODO LO QUE ESTE OPEN =  TRUE QUE ES LO QUE HAA VENDIDO EL CAJERO HASTA EL MOMENTO
            //CUANDO CERREMOS LA CAJA OPEN SERA = FALSE

            string QryArtVendidos = //CONSULTA PARA OBTENER TODAS LAS TRANSACCIONES DEL CAJERO
            " SELECT B.NOMBRE,A.* " +
            " FROM TBL_VENTAS AS A INNER JOIN TBL_USUARIOS AS B " +
            " ON A.USR_ID =B.USR_ID" +
            " WHERE A.USR_ID= @USR_ID  AND A.[OPEN]= True ";
            string QryTotal =//CONSULTA PARA OBTENER EL TOTAL DE LO QUE VENDIO EL CAJERO
            " SELECT B.NOMBRE,SUM(A.CANTIDAD) AS [TOTAL_ARTICULOS],SUM(A.TOTAL) AS [TOTAL_VENDIDO]" +
            " FROM TBL_VENTAS AS A INNER JOIN TBL_USUARIOS AS B" +
            " ON A.USR_ID = B.USR_ID" +
            " WHERE A.USR_ID= @USR_ID AND A.[OPEN]= True" +
            " GROUP BY B.NOMBRE";

            QryArtVendidos = QryArtVendidos.Replace("@USR_ID", UsrId.Replace("'", ""));
            QryTotal = QryTotal.Replace("@USR_ID", UsrId.Replace("'", ""));

            CorteDeCaja.Articulos = new DataTable();

            CorteDeCaja.Articulos = Fill(QryArtVendidos, "ARTICULOS_VENDIDOS");//Llenamos los articulos vendidos por el cajero
            TblResult = Fill(QryTotal, "TOTAL");//OBTENEMOS EL TOTAL DE LO VENDIDO POR EL CAJERO

            if (TblResult.Rows.Count > 0)
            {
                CorteDeCaja.NomCajero = TblResult.Rows[0]["NOMBRE"].ToString().ToUpper();
                CorteDeCaja.CajeroExist = true;
                CorteDeCaja.Total = Convert.ToDouble(TblResult.Rows[0]["TOTAL_VENDIDO"].ToString());
                CorteDeCaja.TotalArticulos = Convert.ToInt16(TblResult.Rows[0]["TOTAL_ARTICULOS"].ToString());
            }
            else
            {
                CorteDeCaja.Total = 0;
                CorteDeCaja.TotalArticulos = 0;
                CorteDeCaja.CajeroExist = false;
                CorteDeCaja.NomCajero = "";
            }


            return CorteDeCaja;
        }
        //CERRAR LA CAJE DEL CAJERO
        public static bool CerrarCaja(string UsrId)
        {
            string QryCerrarCaja =//CONSULTA PARA CERRAR LA CAJA DEL CAJERO
            " UPDATE TBL_VENTAS " +
            " SET [OPEN]= False,[CORTE_DE_CAJA]=NOW()" +
            " WHERE USR_ID= @USR_ID AND [OPEN]= True ";
            QryCerrarCaja = QryCerrarCaja.Replace("@USR_ID", UsrId.Replace("'", ""));
            if (Execute(QryCerrarCaja) > 0)//EJECUTAMOS LA CONSULTA , SI HAY HAY REGISTROS AFECTADOS NOS REGRESA EL TOTAL DE REGISTROS AFECTADO POR LA CONSULTA
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //OBTIENE EL STOCK ACTUAL DE LOS ARTICULOS
        public static DataTable GerArticulosStock()
        {
            string Qry = "SELECT * FROM TBL_STOCK_VIEW";
            return Fill(Qry, "TBL_STOCK");
        }
        //OBTENEMOS LA INFORMACION DE LA VENTA DEL DIA
        public static VentadelDia GetVentaDelDia()
        {
            VentadelDia Info = new VentadelDia();
            DataTable TblResult;
            string QryVentaDelDia = "SELECT * FROM  TBL_VENTA_DEL_DIA_VIEW";
            string QryArticulosVendidos = "SELECT * FROM TBL_VENTA_DEL_DIA_X_ARTICULO";
            string QryVentaDeCajeros = "SELECT * FROM TBL_VENTA_DEL_DIA_X_CAJERO_VIEW";

            TblResult = Fill(QryVentaDelDia, "VENTA_DEL_DIA");
            Info.Articulos = Fill(QryArticulosVendidos, "ARTICULOS_VENDIDOS");
            Info.Cajeros = Fill(QryVentaDeCajeros, "VENTA_X_CAJEROS");

            if (TblResult.Rows.Count > 0)
            {
                Info.HayVenta = true;
                if (Equals(TblResult.Rows[0]["VENTA_TOTAL"], System.DBNull.Value))
                {
                    Info.HayVenta = false;
                    return Info;
                }
                Info.Total = Convert.ToDouble(TblResult.Rows[0]["VENTA_TOTAL"].ToString());
                Info.TotalArticulos = Convert.ToDouble(TblResult.Rows[0]["TOTAL_ARTICULOS"].ToString());

            }
            else
            {
                Info.HayVenta = false;
            }

            return Info;
        }
        //GUARDA UN LOGIN DE USUARIO EN LA BD
        public static bool GuardarUsuario(string Nombre, string Login, string Password, string Tipo)
        {
            DataTable TblResult;
            string QryExist =
            "SELECT LOGIN FROM TBL_USUARIOS WHERE LOGIN='@LOGIN'";
            string QryUpdate =
            " UPDATE TBL_USUARIOS" +
            " SET [LOGIN]='@LOGIN',[NOMBRE]='@NOMBRE',[PASSWORD]='@PASS',[TIPO]='@TIPO',[FECHA]=NOW()" +
            " WHERE LOGIN='@LOGIN'";
            string QryInsert =
            " INSERT INTO TBL_USUARIOS ([NOMBRE],[LOGIN],[PASSWORD],[TIPO],[FECHA])" +
            " VALUES('@NOMBRE','@LOGIN','@PASSWORD','@TIPO',NOW())";

            QryExist = QryExist.Replace("@LOGIN", Login.Replace("'", ""));

            QryUpdate = QryUpdate.Replace("@LOGIN", Login.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@NOMBRE", Nombre.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@PASS", Password.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@TIPO", Tipo.Replace("'", ""));

            QryInsert = QryInsert.Replace("@LOGIN", Login.Replace("'", ""));
            QryInsert = QryInsert.Replace("@NOMBRE", Nombre.Replace("'", ""));
            QryInsert = QryInsert.Replace("@PASSWORD", Password.Replace("'", ""));
            QryInsert = QryInsert.Replace("@TIPO", Tipo.Replace("'", ""));

            TblResult = Fill(QryExist, "TblResult");

            if (TblResult.Rows.Count > 0)
            {
                if (Execute(QryUpdate) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Execute(QryInsert) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }




        }
        //OBTENEMOS INFORMACION DE UN USUARIO                      
        public static UserInfo GetUserInfo(string UsrId)
        {
            UserInfo Info = new UserInfo();
            DataTable TblResult;
            string Qry = "SELECT * FROM TBL_USUARIOS WHERE USR_ID= @USR_ID";
            Qry = Qry = Qry.Replace("@USR_ID", UsrId);
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0)
            {
                Info.EXIST = true;
                Info.Nombre = TblResult.Rows[0]["NOMBRE"].ToString();
                Info.Login = TblResult.Rows[0]["LOGIN"].ToString();
                Info.Password = TblResult.Rows[0]["PASSWORD"].ToString();
                Info.Fecha = TblResult.Rows[0]["FECHA"].ToString();
                Info.Tipo = TblResult.Rows[0]["TIPO"].ToString();
            }
            else
            {
                Info.EXIST = false;
            }
            return Info;
        }
        //BUSCA EL NOMBRE DE UN USUARIO EN LA DB
        public static DataTable BuscarUsuario(string Nombre)
        {
            string Qry = "SELECT USR_ID as ID,LOGIN AS USUARIO,NOMBRE,TIPO,FECHA FROM TBL_USUARIOS WHERE NOMBRE LIKE '%@BUSCAR%' OR LOGIN LIKE '%@BUSCAR%'";
            DataTable TblResult;

            Qry = Qry.Replace("@BUSCAR", Nombre.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");
            return TblResult;
        }
        //Obtiene todos lo pedidos no cancelados
        public static DataTable GetPedidos()
        {
            string Qry = "SELECT * FROM TBL_PEDIDOS_VIEW";
            return Fill(Qry, "TblPedidos");
        }
        //elimina un pedido de la lista
        public static void CambiarStatus(string No, string Status)
        {
            string QryUpdate = "UPDATE TBL_PEDIDOS SET STATUS='@STATUS' WHERE ID= @NO";
            QryUpdate = QryUpdate.Replace("@NO", No.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@STATUS", Status.Replace("'", ""));

            Execute(QryUpdate);
        }
        //AGREGA UN PEDIDO A LA TABLA DE PEDIDOS
        public static bool AgregarPedido(string UsrId, string ArticuloId, string Cantidad, string Nombre)
        {
            string Qry =
            " INSERT INTO TBL_PEDIDOS (USR_ID,ARTICULO_ID,CANTIDAD,CLIENTE_NOM,FECHA,STATUS)" +
            " VALUES('@USR_ID','@ARTICULO_ID','@CANTIDAD','@CLIENTE_NOMBRE',NOW(),'ABIERTO')";
            Qry = Qry.Replace("@USR_ID", UsrId);
            Qry = Qry.Replace("@ARTICULO_ID", ArticuloId);
            Qry = Qry.Replace("@CANTIDAD", Cantidad);
            Qry = Qry.Replace("@CLIENTE_NOMBRE", Nombre.Replace(",", ""));
            if (Execute(Qry) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        #endregion

        #region  <FUNCION PARA IMPRIMR EL TIKET>

        private static DataTable _ArticulosList = new DataTable();
        private static string _Total = "";//Total de la venta
        private static string _Pago = "";//Pago del efectivo 
        private static string _Cambio = "";//Cambio del cliente

        //Propiedad para establecer los articulos a imprimir
        public static DataTable ArticulosParaImprimir
        {
            set
            {
                _ArticulosList = value;
            }
        }
        //Imprime el Tiket
        public static void ImprimirTiket(string Total, string Pago, string Cambio)
        {
            try
            {
                _Total = Total;
                _Pago = Pago;
                _Cambio = Cambio;
                _PrintTiket.Print();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        private static void PrintTiketPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int PosX = 0;
                int PosY = 31;
                int TituloTam = 16;
                int PiedePagTam = 12;
                string Titulo = System.PuntoDeVentas.GetConfig("EMPRESA").ToUpper();//Obtenemos el nombre de la empresa de la base de datos
                string PiedeTiket = "Gracias por su compra!";

                Font font1 = new Font("Consolas", 12f, FontStyle.Regular);
                Font font2 = new Font("Consolas", (float)PiedePagTam, FontStyle.Regular);
                Font font4 = new Font("Courier New", 8f, FontStyle.Bold);
                Font font5 = new Font("Courier New", 10f, FontStyle.Bold);
                Font font6 = new Font("Courier New", 8f, FontStyle.Regular);
                Font font7 = new Font("Courier New", 7f, FontStyle.Bold);
                Font font8 = new Font("Consolas", (float)TituloTam, FontStyle.Bold);
                Font font9 = new Font("Courier New", 8f, FontStyle.Bold);

                string Cajero = "Le Atendio : " + Nombre;//Nombre del Cajero
                e.PageSettings.Margins.Top = 0;
                e.PageSettings.Margins.Left = 0;
                e.PageSettings.Margins.Right = 0;
                e.Graphics.DrawString(Titulo, font8, Brushes.Black, PosX, PosY);
                PosY = PosY + 30;
                e.Graphics.DrawString("FECHA : " + DateTime.Now.ToString("dddd, dd-MMMM-yyyy").ToUpper(), font7, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString(Cajero, font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("-------------------------------------------------", font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                int iCount = 1;
                foreach (DataRow dataRow in _ArticulosList.Rows)
                {

                    string Articulo = iCount.ToString() + "-" + dataRow["DESC"].ToString();
                    string Cantidad = "CANT.: " + (Convert.ToDouble(dataRow["CANTIDAD"].ToString()).ToString("00.00") + " @ $" + ( Convert.ToDouble( dataRow["PRECIO"].ToString())).ToString("00.00") + " = $" +(Convert.ToDouble(dataRow["TOTAL"].ToString())).ToString("00.00"));

                    e.Graphics.DrawString(Articulo, font5, Brushes.Black, PosX, PosY);
                    PosY += 14;
                    e.Graphics.DrawString(Cantidad, font6, Brushes.Black, PosX, PosY);
                    PosY += 14;
                    iCount++;
                }
                e.Graphics.DrawString("-------------------------------------------------", font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("TOTAL    : $ " + _Total.ToString(), font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("EFECTIVO : " + _Pago.ToString(), font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("SU CAMBIO! " + _Cambio, font2, Brushes.Black, PosX, PosY);
                PosY = PosY + 16;
                e.Graphics.DrawString(PiedeTiket, font2, Brushes.Black, PosX, PosY);//Pie de tiket
                PosY = PosY + 24;
                //Fecha y Hra
                e.Graphics.DrawString(">" + DateTime.Now.ToString("dd-MMMM-yyyy hh:mm:ss tt").ToUpper(), font9, Brushes.Black, PosX, PosY);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro al imprimir Tiket.\nError Msg:\n" + ex.Message);
            }
        }
        #endregion

        #region  <FUNCIONES ESPECIALES>
        //Esta funcion es para llenar una tabla
        public static DataTable Fill(string Qry, string TableName)
        {
            DataTable TblResult = new DataTable(TableName); //Tabla para guardar el resultado!.
            OleDbDataReader Reader;
            _objCmd.CommandText = Qry;//Le pasamos la consulta, para poder extraer los datos
            Reader = _objCmd.ExecuteReader();//Executamos la Qry
            TblResult.Load(Reader, LoadOption.OverwriteChanges);//Llenamos los datos a la tabla
            Reader.Close();//cerramos el datareader para que no se quede abierto
            return TblResult;//Retornamos el datatable
        }
        public static int Execute(string Qry)
        {
            _objCmd.CommandText = Qry;
            return _objCmd.ExecuteNonQuery();
        }
        #endregion

    }


}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Namespace usado para poder hacer la conexion
using System.Data.OleDb;
using System.Data;

using System.Drawing;
using System.Drawing.Printing;

namespace System
{

    public static class PuntoDeVentas //Clase para hacer consultas a nuestra base de datos
    {

        #region  <DECLARACIONES GLOBALES>

        //Cadena de conexion hacia la base de datos access
        private static string _strCadenaDeConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DB\dbVentas.accdb;Persist Security Info=True";
        //Objeto de conexion para hacer las consultas
        private static OleDbConnection _objConn = new OleDbConnection(_strCadenaDeConexion);
        //Objeto para ejecutar las consulas hacia Bd.
        private static OleDbCommand _objCmd = new OleDbCommand();

        private static PrintDocument _PrintTiket = new PrintDocument();

        //Informacion de el usuario logueado!
        private static string _Usr = "";//Usuario
        private static string _Nombre = "";//Nombre
        private static string _Tipo = "";//Tipo
        private static string _Id = ""; //Id del usuario

        public struct ArticuloInfo//Estructura para guardar la informacion de un articulo 
        {
            public string ID;
            public string DESCRIPCION;
            public string PRECIO;
            public string INV;
            public string UNIDAD;
            public bool EXIST;//si el articulo existe devuelve true
        }

        public struct CorteDeCajaInfo// ESTRUCTURA PARA GUARDAR INFORMACION DEL CORTE DE CAJA
        {
            public string NomCajero;
            public DataTable Articulos;
            public Double Total;
            public int TotalArticulos;
            public bool CajeroExist;//si el cajero existe devuelve true
        }
        public struct VentadelDia
        {//En para guardar la venta del dia
            public double Total;
            public double TotalArticulos;
            public DataTable Articulos;
            public DataTable Cajeros;
            public bool HayVenta;
        }

        public struct UserInfo
        { //ESTRUCTURA PARA GUARDAR INFORMACION DE UN USUARIO...
            public string Nombre;
            public string Login;
            public string Password;
            public string Tipo;
            public string Fecha;
            public bool EXIST;
        }

        #endregion

        #region  <PROPIEDADES>

        //Propiedades para consultar la informacion del usuario logueado
        public static string Usr
        {
            get
            {
                return _Usr;
            }
        }
        public static string Nombre
        {
            get
            {
                return _Nombre;
            }
        }
        public static string Tipo
        {
            get
            {
                return _Tipo;
            }
        }
        public static string CajeroId
        {
            get
            {
                return _Id;
            }
        }

        #endregion

        #region  <CONSTRUCTOR DE LA CLASE>
        //Constructor de la clase
        static PuntoDeVentas()
        {
            //Si la conexion no esta abierta la abrimos
            if (_objConn.State != ConnectionState.Open)
            {
                _objConn.Open();//Abrimos la conexion si no esta en el estado open.
            }

            _objCmd.Connection = _objConn;

            //Agregamos el evento PrintPage ala funcion PrintTiketPage
            _PrintTiket.PrintPage += new PrintPageEventHandler(PrintTiketPage);

        }
        #endregion

        #region  <FUNCIONES PUBLICAS>

        //Funcion para validar si un usuario existe en el login
        public static bool ValidarUsuario(string Login, string Password)
        {
            //consulta para validar si el usuario existe!
            string Qry =
            " SELECT [USR_ID],[LOGIN],[NOMBRE],[TIPO] FROM [TBL_USUARIOS]" +
            " WHERE LOGIN='@LOGIN' AND PASSWORD='@PWD'";
            DataTable TblResult;
            Qry = Qry.Replace("@LOGIN", Login.Replace("'", ""));//Remplazamos el Texto @LOGIN EN LA  VARIABLE QRY
            Qry = Qry.Replace("@PWD", Password.Replace("'", ""));//Remplazamos el Texto @PWD EN LA  VARIABLE QRY

            TblResult = Fill(Qry, "Results");//Llamanos a la funcion para llenar la tabla.

            if (TblResult.Rows.Count > 0)
            {
                _Usr = TblResult.Rows[0]["LOGIN"].ToString();
                _Nombre = TblResult.Rows[0]["NOMBRE"].ToString();
                _Tipo = TblResult.Rows[0]["TIPO"].ToString();
                _Id = TblResult.Rows[0]["USR_ID"].ToString();
                return true;
            }
            else
            {
                //Regresamos False si no tiene registros la tabla de resultados
                return false;
            }
        }
        //Funcion para obtener configuraciones de la tabla TBL_CONFIG
        public static string GetConfig(string Config_Name)
        {
            DataTable TblResult;
            string Qry =
            " SELECT [CONFIG_VALUE] FROM [TBL_CONFIG]" +
            " WHERE [CONFIG_NAME]='@CONFIG_NAME'";
            Qry = Qry.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));

            TblResult = Fill(Qry, "TblConfig");

            if (TblResult.Rows.Count > 0)
            {
                return TblResult.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }
        //FUNCION PARA ACTUALIZAR UNA CONFIGURACION EN LA TABLA CONFIG
        public static int UpdateConfig(string Config_Name, string Config_Value)
        {

            string QryUpdate =
            " UPDATE TBL_CONFIG" +
            " SET CONFIG_VALUE='@CONFIG_VALUE'" +
            " WHERE CONFIG_NAME='@CONFIG_NAME'";
            QryUpdate = QryUpdate.Replace("@CONFIG_VALUE", Config_Value);
            QryUpdate = QryUpdate.Replace("@CONFIG_NAME", Config_Name);

            string QryExist =
            " SELECT CONFIG_NAME FROM TBL_CONFIG" +
            " WHERE CONFIG_NAME='@CONFIG_NAME'";
            DataTable tblResult;
            QryExist = QryExist.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));
            tblResult = Fill(QryExist, "tblResult");

            string QryInsert =
            " INSERT INTO TBL_CONFIG (CONFIG_NAME,CONFIG_VALUE) VALUES('@CONFIG_NAME','@CONFIG_VALUE')";
            QryInsert = QryInsert.Replace("@CONFIG_NAME", Config_Name.Replace("'", ""));
            QryInsert = QryInsert.Replace("@CONFIG_VALUE", Config_Value.Replace("'", ""));

            if (tblResult.Rows.Count > 0)
            {
                return Execute(QryUpdate);
            }
            else
            {
                return Execute(QryInsert);
            }



        }
        //Funcion para obtener la informacion del un articulo
        public static ArticuloInfo GetArticuloInfo(string ArticuloId)
        {
            ArticuloInfo info = new ArticuloInfo();
            DataTable TblResult;
            string Qry = "SELECT * FROM [TBL_ARTICULOS] WHERE [ARTICULO_ID]='@ART_ID'";
            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0)
            {
                info.EXIST = true;
                info.ID = TblResult.Rows[0]["ARTICULO_ID"].ToString();
                info.DESCRIPCION = TblResult.Rows[0]["DESCRIPCION"].ToString();
                info.PRECIO = TblResult.Rows[0]["PRECIO"].ToString();
                info.INV = TblResult.Rows[0]["INV"].ToString();
                info.UNIDAD = TblResult.Rows[0]["UNIDAD"].ToString();
            }
            else
            {
                info.EXIST = false;
                info.PRECIO = "0";

            }
            return info;
        }
        //Funcion para agregar un nuevo articulo ala Bd.
        public static bool UpdateArticulo(string Id, string Descripcion, string Unidad, string Precio, bool Inv)
        {
            string QryInsert = //ESTA INSTRUCCION SQL ES PARA INSERTAR UN ARTICULO EN LA BD.
           " INSERT INTO TBL_ARTICULOS (ARTICULO_ID,DESCRIPCION,UNIDAD,PRECIO,INV)" +
           " VALUES('@ID','@DESCRIPCION','@UNIDAD','@PRECIO','@INV')";
            string QryUpdate =
            " UPDATE TBL_ARTICULOS" +
            " SET ARTICULO_ID='@ID',DESCRIPCION='@DESCRIPCION',UNIDAD='@UNIDAD',PRECIO='@PRECIO',INV='@INV'" +
            " WHERE ARTICULO_ID='@ID'";

            //Validamos si no esta registrado ya este articulo
            if (GetArticuloInfo(Id).EXIST)
            { //Llamamos a la funcion GetArticuloInfo para saber si existe
                QryUpdate = QryUpdate.Replace("@ID", Id.Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@DESCRIPCION", Descripcion.ToUpper().Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@PRECIO", Precio.Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@UNIDAD", Unidad.ToUpper().Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@INV", Convert.ToInt16(Inv).ToString());//Convertimos a entero la variable bool para que guarde 1 o 0

                if (Execute(QryUpdate) > 0)//Mandamos a llamar la funcion Execute para ejecutar la instruccion SQL
                {
                    return true;//Retornamos True si la funcion _Execute nos regresa mas 0

                }
                else
                {
                    return false;//Retornamos False si la funcion no nos regreso nada
                }


            }
            else
            {
                //Remplazamos los valores en la de la instruccion por los valores a insertar
                QryInsert = QryInsert.Replace("@ID", Id.Replace(",", ""));
                QryInsert = QryInsert.Replace("@DESCRIPCION", Descripcion.ToUpper().Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@PRECIO", Precio.Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@UNIDAD", Unidad.ToUpper().Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@INV", Convert.ToInt16(Inv).ToString());//Convertimos a entero la variable bool para que guarde 1 o 0

                if (Execute(QryInsert) > 0)//Mandamos a llamar la funcion Execute para ejecutar la instruccion SQL
                {
                    return true;//Retornamos True si la funcion _Execute nos regresa mas 0

                }
                else
                {
                    return false;//Retornamos False si la funcion no nos regreso nada
                }

            }

        }
        //Funcion Para buscar un articulo por descripcion en la Bd
        public static DataTable BuscarArticulo(string Buscar)
        {
            DataTable TblResult;
            string QryBuscar = "SELECT ARTICULO_ID AS [CODIGO],DESCRIPCION,UNIDAD,PRECIO FROM TBL_ARTICULOS WHERE DESCRIPCION LIKE '%@BUSCAR%'";
            QryBuscar = QryBuscar.Replace("@BUSCAR", Buscar.Replace("'", ""));
            TblResult = Fill(QryBuscar, "TblResultados");
            return TblResult;
        }
        //BUSCA UN ARTICULO EN LA VISTA DE INVENTARIO
        public static DataTable BuscarInventarioArticulo(string Buscar)
        {
            DataTable TblResult;
            string QryBuscar = "SELECT * FROM TBL_INVENTARIO_VIEW WHERE DESCRIPCION LIKE '%@BUSCAR%'";
            QryBuscar = QryBuscar.Replace("@BUSCAR", Buscar.Replace("'", ""));
            TblResult = Fill(QryBuscar, "TblResultados");
            return TblResult;
        }
        //Registra el Articulo en la base de datos!
        public static int RegistrarArticulo(string Id, string Descripcion, string Precio, string Cantidad, string Total, string UsrId)
        {

            string Qry =
            " INSERT INTO TBL_VENTAS ([ARTICULO_ID],[DESCRIPCION],[PRECIO],[CANTIDAD],[TOTAL],[USR_ID],[OPEN],[FECHA])" +
            " VALUES('@ID','@DESCRIPCION','@PRECIO','@CANTIDAD','@TOTAL','@USR','1',NOW())";
            Qry = Qry.Replace("@ID", Id);
            Qry = Qry.Replace("@DESCRIPCION", Descripcion);
            Qry = Qry.Replace("@PRECIO", Precio);
            Qry = Qry.Replace("@USR", UsrId);
            Qry = Qry.Replace("@CANTIDAD", Cantidad);
            Qry = Qry.Replace("@TOTAL", Total);

            return Execute(Qry);

        }
        //REGISTRA UN ARTICULO AL SYSTEMA DE INVETARIO
        public static int InvRegistrarArticulo(string Id, string Entrada, string Salida, string UsrId, string TransType)
        {
            string Qry =
           " INSERT INTO TBL_INVENTARIO (ARTICULO_ID,ENTRADA,SALIDA,FECHA,USR_ID,TRANS_TYPE)" +
           " VALUES('@ART_ID','@ENTRADA','@SALIDA',NOW(),'@USR_ID','@TRANS_TYPE')";

            Qry = Qry.Replace("@ART_ID", Id);
            Qry = Qry.Replace("@ENTRADA", Entrada);
            Qry = Qry.Replace("@SALIDA", Salida);
            Qry = Qry.Replace("@USR_ID", UsrId);
            Qry = Qry.Replace("@TRANS_TYPE", TransType);
            return Execute(Qry);
        }
        //Obtiene el Historial del inventario de un Articulo
        public static DataTable GetInvHistorial(string ArticuloId)
        {
            string Qry = "SELECT A.*,B.NOMBRE AS USUARIO FROM TBL_INVENTARIO AS A INNER JOIN TBL_USUARIOS AS B ON A.USR_ID =B.USR_ID WHERE ARTICULO_ID='@ART_ID'";
            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace(",", ""));
            return Fill(Qry, "TblResult");
        }
        //Obtiene la informacion para el corte de caja
        public static CorteDeCajaInfo GetCorteDeCaja(string UsrId)
        {
            DataTable TblResult;
            CorteDeCajaInfo CorteDeCaja = new CorteDeCajaInfo();//Declaramos una variable del tipo de la estructura CorteDeCajaInfo
            // EN LA TABLA TBL_VENTAS EL CAMPO OPEN REPRESENTA EL ESTADO DE LA CAJA
            // OPEN = TRUE QUIEERE DECIR QUE LA CAA SIGUE ABIERTA
            //OPEN = FALSE QUIERE DECIR QUE LA CAJ ESTA CERRADA
            //CONSULTAMOS TODO LO QUE ESTE OPEN =  TRUE QUE ES LO QUE HAA VENDIDO EL CAJERO HASTA EL MOMENTO
            //CUANDO CERREMOS LA CAJA OPEN SERA = FALSE

            string QryArtVendidos = //CONSULTA PARA OBTENER TODAS LAS TRANSACCIONES DEL CAJERO
            " SELECT B.NOMBRE,A.* " +
            " FROM TBL_VENTAS AS A INNER JOIN TBL_USUARIOS AS B " +
            " ON A.USR_ID =B.USR_ID" +
            " WHERE A.USR_ID= @USR_ID  AND A.[OPEN]= True ";
            string QryTotal =//CONSULTA PARA OBTENER EL TOTAL DE LO QUE VENDIO EL CAJERO
            " SELECT B.NOMBRE,SUM(A.CANTIDAD) AS [TOTAL_ARTICULOS],SUM(A.TOTAL) AS [TOTAL_VENDIDO]" +
            " FROM TBL_VENTAS AS A INNER JOIN TBL_USUARIOS AS B" +
            " ON A.USR_ID = B.USR_ID" +
            " WHERE A.USR_ID= @USR_ID AND A.[OPEN]= True" +
            " GROUP BY B.NOMBRE";

            QryArtVendidos = QryArtVendidos.Replace("@USR_ID", UsrId.Replace("'", ""));
            QryTotal = QryTotal.Replace("@USR_ID", UsrId.Replace("'", ""));

            CorteDeCaja.Articulos = new DataTable();

            CorteDeCaja.Articulos = Fill(QryArtVendidos, "ARTICULOS_VENDIDOS");//Llenamos los articulos vendidos por el cajero
            TblResult = Fill(QryTotal, "TOTAL");//OBTENEMOS EL TOTAL DE LO VENDIDO POR EL CAJERO

            if (TblResult.Rows.Count > 0)
            {
                CorteDeCaja.NomCajero = TblResult.Rows[0]["NOMBRE"].ToString().ToUpper();
                CorteDeCaja.CajeroExist = true;
                CorteDeCaja.Total = Convert.ToDouble(TblResult.Rows[0]["TOTAL_VENDIDO"].ToString());
                CorteDeCaja.TotalArticulos = Convert.ToInt16(TblResult.Rows[0]["TOTAL_ARTICULOS"].ToString());
            }
            else
            {
                CorteDeCaja.Total = 0;
                CorteDeCaja.TotalArticulos = 0;
                CorteDeCaja.CajeroExist = false;
                CorteDeCaja.NomCajero = "";
            }


            return CorteDeCaja;
        }
        //CERRAR LA CAJE DEL CAJERO
        public static bool CerrarCaja(string UsrId)
        {
            string QryCerrarCaja =//CONSULTA PARA CERRAR LA CAJA DEL CAJERO
            " UPDATE TBL_VENTAS " +
            " SET [OPEN]= False,[CORTE_DE_CAJA]=NOW()" +
            " WHERE USR_ID= @USR_ID AND [OPEN]= True ";
            QryCerrarCaja = QryCerrarCaja.Replace("@USR_ID", UsrId.Replace("'", ""));
            if (Execute(QryCerrarCaja) > 0)//EJECUTAMOS LA CONSULTA , SI HAY HAY REGISTROS AFECTADOS NOS REGRESA EL TOTAL DE REGISTROS AFECTADO POR LA CONSULTA
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //OBTIENE EL STOCK ACTUAL DE LOS ARTICULOS
        public static DataTable GerArticulosStock()
        {
            string Qry = "SELECT * FROM TBL_STOCK_VIEW";
            return Fill(Qry, "TBL_STOCK");
        }
        //OBTENEMOS LA INFORMACION DE LA VENTA DEL DIA
        public static VentadelDia GetVentaDelDia()
        {
            VentadelDia Info = new VentadelDia();
            DataTable TblResult;
            string QryVentaDelDia = "SELECT * FROM  TBL_VENTA_DEL_DIA_VIEW";
            string QryArticulosVendidos = "SELECT * FROM TBL_VENTA_DEL_DIA_X_ARTICULO";
            string QryVentaDeCajeros = "SELECT * FROM TBL_VENTA_DEL_DIA_X_CAJERO_VIEW";

            TblResult = Fill(QryVentaDelDia, "VENTA_DEL_DIA");
            Info.Articulos = Fill(QryArticulosVendidos, "ARTICULOS_VENDIDOS");
            Info.Cajeros = Fill(QryVentaDeCajeros, "VENTA_X_CAJEROS");

            if (TblResult.Rows.Count > 0)
            {
                Info.HayVenta = true;
                if (Equals(TblResult.Rows[0]["VENTA_TOTAL"], System.DBNull.Value))
                {
                    Info.HayVenta = false;
                    return Info;
                }
                Info.Total = Convert.ToDouble(TblResult.Rows[0]["VENTA_TOTAL"].ToString());
                Info.TotalArticulos = Convert.ToDouble(TblResult.Rows[0]["TOTAL_ARTICULOS"].ToString());

            }
            else
            {
                Info.HayVenta = false;
            }

            return Info;
        }
        //GUARDA UN LOGIN DE USUARIO EN LA BD
        public static bool GuardarUsuario(string Nombre, string Login, string Password, string Tipo)
        {
            DataTable TblResult;
            string QryExist =
            "SELECT LOGIN FROM TBL_USUARIOS WHERE LOGIN='@LOGIN'";
            string QryUpdate =
            " UPDATE TBL_USUARIOS" +
            " SET [LOGIN]='@LOGIN',[NOMBRE]='@NOMBRE',[PASSWORD]='@PASS',[TIPO]='@TIPO',[FECHA]=NOW()" +
            " WHERE LOGIN='@LOGIN'";
            string QryInsert =
            " INSERT INTO TBL_USUARIOS ([NOMBRE],[LOGIN],[PASSWORD],[TIPO],[FECHA])" +
            " VALUES('@NOMBRE','@LOGIN','@PASSWORD','@TIPO',NOW())";

            QryExist = QryExist.Replace("@LOGIN", Login.Replace("'", ""));

            QryUpdate = QryUpdate.Replace("@LOGIN", Login.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@NOMBRE", Nombre.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@PASS", Password.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@TIPO", Tipo.Replace("'", ""));

            QryInsert = QryInsert.Replace("@LOGIN", Login.Replace("'", ""));
            QryInsert = QryInsert.Replace("@NOMBRE", Nombre.Replace("'", ""));
            QryInsert = QryInsert.Replace("@PASSWORD", Password.Replace("'", ""));
            QryInsert = QryInsert.Replace("@TIPO", Tipo.Replace("'", ""));

            TblResult = Fill(QryExist, "TblResult");

            if (TblResult.Rows.Count > 0)
            {
                if (Execute(QryUpdate) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Execute(QryInsert) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }




        }
        //OBTENEMOS INFORMACION DE UN USUARIO                      
        public static UserInfo GetUserInfo(string UsrId)
        {
            UserInfo Info = new UserInfo();
            DataTable TblResult;
            string Qry = "SELECT * FROM TBL_USUARIOS WHERE USR_ID= @USR_ID";
            Qry = Qry = Qry.Replace("@USR_ID", UsrId);
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0)
            {
                Info.EXIST = true;
                Info.Nombre = TblResult.Rows[0]["NOMBRE"].ToString();
                Info.Login = TblResult.Rows[0]["LOGIN"].ToString();
                Info.Password = TblResult.Rows[0]["PASSWORD"].ToString();
                Info.Fecha = TblResult.Rows[0]["FECHA"].ToString();
                Info.Tipo = TblResult.Rows[0]["TIPO"].ToString();
            }
            else
            {
                Info.EXIST = false;
            }
            return Info;
        }
        //BUSCA EL NOMBRE DE UN USUARIO EN LA DB
        public static DataTable BuscarUsuario(string Nombre)
        {
            string Qry = "SELECT USR_ID as ID,LOGIN AS USUARIO,NOMBRE,TIPO,FECHA FROM TBL_USUARIOS WHERE NOMBRE LIKE '%@BUSCAR%' OR LOGIN LIKE '%@BUSCAR%'";
            DataTable TblResult;

            Qry = Qry.Replace("@BUSCAR", Nombre.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");
            return TblResult;
        }
        //Obtiene todos lo pedidos no cancelados
        public static DataTable GetPedidos()
        {
            string Qry = "SELECT * FROM TBL_PEDIDOS_VIEW";
            return Fill(Qry, "TblPedidos");
        }
        //elimina un pedido de la lista
        public static void CambiarStatus(string No, string Status)
        {
            string QryUpdate = "UPDATE TBL_PEDIDOS SET STATUS='@STATUS' WHERE ID= @NO";
            QryUpdate = QryUpdate.Replace("@NO", No.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@STATUS", Status.Replace("'", ""));

            Execute(QryUpdate);
        }
        //AGREGA UN PEDIDO A LA TABLA DE PEDIDOS
        public static bool AgregarPedido(string UsrId, string ArticuloId, string Cantidad, string Nombre)
        {
            string Qry =
            " INSERT INTO TBL_PEDIDOS (USR_ID,ARTICULO_ID,CANTIDAD,CLIENTE_NOM,FECHA,STATUS)" +
            " VALUES('@USR_ID','@ARTICULO_ID','@CANTIDAD','@CLIENTE_NOMBRE',NOW(),'ABIERTO')";
            Qry = Qry.Replace("@USR_ID", UsrId);
            Qry = Qry.Replace("@ARTICULO_ID", ArticuloId);
            Qry = Qry.Replace("@CANTIDAD", Cantidad);
            Qry = Qry.Replace("@CLIENTE_NOMBRE", Nombre.Replace(",", ""));
            if (Execute(Qry) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        #endregion

        #region  <FUNCION PARA IMPRIMR EL TIKET>

        private static DataTable _ArticulosList = new DataTable();
        private static string _Total = "";//Total de la venta
        private static string _Pago = "";//Pago del efectivo 
        private static string _Cambio = "";//Cambio del cliente

        //Propiedad para establecer los articulos a imprimir
        public static DataTable ArticulosParaImprimir
        {
            set
            {
                _ArticulosList = value;
            }
        }
        //Imprime el Tiket
        public static void ImprimirTiket(string Total, string Pago, string Cambio)
        {
            try
            {
                _Total = Total;
                _Pago = Pago;
                _Cambio = Cambio;
                _PrintTiket.Print();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        private static void PrintTiketPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int PosX = 0;
                int PosY = 31;
                int TituloTam = 16;
                int PiedePagTam = 12;
                string Titulo = System.PuntoDeVentas.GetConfig("EMPRESA").ToUpper();//Obtenemos el nombre de la empresa de la base de datos
                string PiedeTiket = "Gracias por su compra!";

                Font font1 = new Font("Consolas", 12f, FontStyle.Regular);
                Font font2 = new Font("Consolas", (float)PiedePagTam, FontStyle.Regular);
                Font font4 = new Font("Courier New", 8f, FontStyle.Bold);
                Font font5 = new Font("Courier New", 10f, FontStyle.Bold);
                Font font6 = new Font("Courier New", 8f, FontStyle.Regular);
                Font font7 = new Font("Courier New", 7f, FontStyle.Bold);
                Font font8 = new Font("Consolas", (float)TituloTam, FontStyle.Bold);
                Font font9 = new Font("Courier New", 8f, FontStyle.Bold);

                string Cajero = "Le Atendio : " + Nombre;//Nombre del Cajero
                e.PageSettings.Margins.Top = 0;
                e.PageSettings.Margins.Left = 0;
                e.PageSettings.Margins.Right = 0;
                e.Graphics.DrawString(Titulo, font8, Brushes.Black, PosX, PosY);
                PosY = PosY + 30;
                e.Graphics.DrawString("FECHA : " + DateTime.Now.ToString("dddd, dd-MMMM-yyyy").ToUpper(), font7, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString(Cajero, font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("-------------------------------------------------", font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                int iCount = 1;
                foreach (DataRow dataRow in _ArticulosList.Rows)
                {

                    string Articulo = iCount.ToString() + "-" + dataRow["DESC"].ToString();
                    string Cantidad = "CANT.: " + (Convert.ToDouble(dataRow["CANTIDAD"].ToString()).ToString("00.00") + " @ $" + ( Convert.ToDouble( dataRow["PRECIO"].ToString())).ToString("00.00") + " = $" +(Convert.ToDouble(dataRow["TOTAL"].ToString())).ToString("00.00"));

                    e.Graphics.DrawString(Articulo, font5, Brushes.Black, PosX, PosY);
                    PosY += 14;
                    e.Graphics.DrawString(Cantidad, font6, Brushes.Black, PosX, PosY);
                    PosY += 14;
                    iCount++;
                }
                e.Graphics.DrawString("-------------------------------------------------", font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("TOTAL    : $ " + _Total.ToString(), font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("EFECTIVO : " + _Pago.ToString(), font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("SU CAMBIO! " + _Cambio, font2, Brushes.Black, PosX, PosY);
                PosY = PosY + 16;
                e.Graphics.DrawString(PiedeTiket, font2, Brushes.Black, PosX, PosY);//Pie de tiket
                PosY = PosY + 24;
                //Fecha y Hra
                e.Graphics.DrawString(">" + DateTime.Now.ToString("dd-MMMM-yyyy hh:mm:ss tt").ToUpper(), font9, Brushes.Black, PosX, PosY);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro al imprimir Tiket.\nError Msg:\n" + ex.Message);
            }
        }
        #endregion

        #region  <FUNCIONES ESPECIALES>
        //Esta funcion es para llenar una tabla
        public static DataTable Fill(string Qry, string TableName)
        {
            DataTable TblResult = new DataTable(TableName); //Tabla para guardar el resultado!.
            OleDbDataReader Reader;
            _objCmd.CommandText = Qry;//Le pasamos la consulta, para poder extraer los datos
            Reader = _objCmd.ExecuteReader();//Executamos la Qry
            TblResult.Load(Reader, LoadOption.OverwriteChanges);//Llenamos los datos a la tabla
            Reader.Close();//cerramos el datareader para que no se quede abierto
            return TblResult;//Retornamos el datatable
        }
        public static int Execute(string Qry)
        {
            _objCmd.CommandText = Qry;
            return _objCmd.ExecuteNonQuery();
        }
        #endregion

    }


}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
