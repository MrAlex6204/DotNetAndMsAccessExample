using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//NAMESPACE USADO PARA PODER HACER LA CONEXION
using System.Data.OleDb;
using System.Data;

//NAME SPACE PARA IMPRIMIR EL TICKET
using System.Drawing;
using System.Drawing.Printing;

//MODELS DEL SISTEMA DE VENTA
using PuntoDeVentas;
using PuntoDeVentas.Models;

namespace System {

    public static class DbRepository //CLASE PARA HACER CONSULTAS A NUESTRA BASE DE DATOS
    {

        #region  <DECLARACIONES GLOBALES>

        //CADENA DE CONEXION HACIA LA BASE DE DATOS ACCESS
        private static string _strCadenaDeConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB\dbVentas.mdb;User Id=admin;Password=";
        //OBJETO DE CONEXION PARA HACER LAS CONSULTAS
        private static OleDbConnection _objConn = new OleDbConnection(_strCadenaDeConexion);
        //OBJETO PARA EJECUTAR LAS CONSULAS HACIA BD.
        private static OleDbCommand _objCmd = new OleDbCommand();
        //OBJETO DE PRINTDOCUMENT PARA IMPRIMIR EL TICKET
        private static PrintDocument _PrintTiket = new PrintDocument();

        public struct CorteDeCajaInfo// ESTRUCTURA PARA GUARDAR INFORMACION DEL CORTE DE CAJA
        {
            public string NomCajero;
            public DataTable Articulos;
            public Double Total;
            public int TotalArticulos;
            public bool CajeroExist;//SI EL CAJERO EXISTE DEVUELVE TRUE
        }

        public struct VentadelDia //EN PARA GUARDAR LA VENTA DEL DIA
        {
            public double Total;
            public double TotalArticulos;
            public DataTable Articulos;
            public DataTable Cajeros;
            public bool HayVenta;
        }

        public enum TransactionType {//TIPO DE TRANSACCION
            VENTA, INVENTARIO
        }


        #endregion

        #region  <PROPIEDADES>

        //Propiedades para consultar la informacion del usuario logueado
        private static UserInfo _LoggedUser;

        public static UserInfo LoggedUser {
            get {
                if (_LoggedUser != null) {
                    _LoggedUser.Picture = GetUserPicture(_LoggedUser.Id.ToString());
                }
                return _LoggedUser;
            }
            set {
                _LoggedUser = value;
            }
        }

        #endregion

        #region  <CONSTRUCTOR DE LA CLASE>

        static DbRepository() //CONSTRUCTOR DE LA CLASE
        {

            try {

                //SI LA CONEXION NO ESTA ABIERTA LA ABRIMOS
                if (_objConn.State != ConnectionState.Open) {
                    _objConn.Open();//ABRIMOS LA CONEXION SI NO ESTA EN EL ESTADO OPEN.
                }

            } catch (OleDbException OleDbEx) {
                throw OleDbEx;//ARROJAR ERROR DE OLEDB

            } catch (Exception ex) {
                throw ex;//ARROJAR CUALQUIER OTRO TIPO DE ERROR
            }

            _objCmd.Connection = _objConn;//ASIGNARLE EL OBJETO DE CONEXION AL SQL CMD 

            //AGREGAMOS EL EVENTO PRINTPAGE ALA FUNCION PRINTTIKETPAGE
            _PrintTiket.PrintPage += new PrintPageEventHandler(PrintTiketPage);


        }
        #endregion

        #region  <FUNCIONES PUBLICAS>

        //FUNCION PARA REALIZAR UN DEPOSITO A NOMBRE DEL CAJERO
        public static bool RegistrarDeposito(UserInfo User,float Deposito) {
            string Qry = "UPDATE TBL_USUARIOS SET DEPOSITO_DE_EFECTIVO = @Deposito WHERE USR_ID=@UsrId";

            Qry = Qry.Replace("@UsrId", User.Id.ToString());
            Qry = Qry.Replace("@Deposito", Deposito.ToString());

            return Execute(Qry) > 0;
        }

        //FUNCION PARA REALIZAR EL RETIRO DE DEPOSITO DE CAJA
        public static bool RetirarDeposito(UserInfo User) {
            string Qry = "UPDATE TBL_USUARIOS SET DEPOSITO_DE_EFECTIVO = 0 WHERE USR_ID=@UsrId";

            Qry = Qry.Replace("@UsrId", User.Id.ToString());

            return Execute(Qry) > 0;
        }

        //OBTENER EL REPORTE DETALLE DE ARTICULOS EN INVENTARIO
        public static DataTable GetInversionDetalle() { 
            var Qry = @"
                SELECT 
                       ARTICULO_ID,DESCRIPCION,UNIDAD,'@CurrencySymbol'+STR(PRECIO) as [PRECIO],'@CurrencySymbol' + STR(COSTO) as [COSTO],
                       ENTRADA AS [CANT ENTRADA],SALIDA AS [CANT SALIDA],STOCK AS [STOCK ACTUAL], '@CurrencySymbol'+STR(INVERSION) AS [INVERSION],
                       '@CurrencySymbol' + STR(GANCIAS_GENERADAS) AS [GANACIA X GENERAR] 
                FROM TBL_INVENTARIO_VIEW WHERE INVERSION > 0";

            Qry = Qry.Replace("@CurrencySymbol", Configurations.CurrencySymbol);
            

            var Tbl = Fill(Qry, "InventarioDetalle");
            return Tbl;        
        }

        //OBTIENE LA INVERSION ACTUAL EN INVENTARIO
        public static double GetInversionEnInventario() {
            var Total = 0d;
            var Qry = "SELECT SUM(INVERSION) FROM TBL_INVENTARIO_VIEW";

            Total =(double)ExecuteScalar(Qry);

            return Total;
        }

        //OBTIENE LA GANANCIA A GENERAR DEL INVENTARIO
        public static double GetGananciasDelInventario() {
            var Total = 0d;
            var Qry = "SELECT SUM(GANCIAS_GENERADAS) FROM TBL_INVENTARIO_VIEW";

            Total = (double)ExecuteScalar(Qry);

            return Total;
        }
        
        //FUNCION PARA VALIDAR SI UN USUARIO EXISTE EN EL LOGIN
        public static UserInfo ValidarUsuario(string Login, string Password) {
            UserInfo Usr = new UserInfo();
            DataTable TblResult;
            //CONSULTA PARA VALIDAR SI EL USUARIO EXISTE!
            string Qry =
            " SELECT * FROM [TBL_USUARIOS]" +
            " WHERE LOGIN='@LOGIN' AND PASSWORD='@PWD'";

            Qry = Qry.Replace("@LOGIN", Login.Replace("'", ""));//Remplazamos el Texto @LOGIN EN LA  VARIABLE QRY
            Qry = Qry.Replace("@PWD", Password.Replace("'", ""));//Remplazamos el Texto @PWD EN LA  VARIABLE QRY

            TblResult = Fill(Qry, "Results");//Llamanos a la funcion para llenar la tabla.

            if (TblResult.Rows.Count > 0) {
                //Guardar informacion del usuario logueado
                Usr.Exists = true;
                Usr.Id = Convert.ToInt16(TblResult.Rows[0]["USR_ID"].ToString());
                Usr.Name = TblResult.Rows[0]["NOMBRE"].ToString();
                Usr.UserName = TblResult.Rows[0]["LOGIN"].ToString();
                Usr.LevelType = TblResult.Rows[0]["TIPO"].ToString();
                Usr.Password = TblResult.Rows[0]["PASSWORD"].ToString();
                Usr.Date = Convert.ToDateTime(TblResult.Rows[0]["FECHA"].ToString());
                Usr.Picture = GetUserPicture(Usr.Id.ToString());
                Usr.DepositoEnCaja = TblResult.Rows[0]["DEPOSITO_DE_EFECTIVO"].ToString();
            }


            return Usr;
        }

        //FUNCION PARA OBTENER CONFIGURACIONES DE LA TABLA TBL_CONFIG
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
        public static bool UpdateConfig(string Config_Name, string Config_Value) {

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
                return (Execute(QryUpdate) > 0);
            } else {
                return (Execute(QryInsert) > 0);
            }

        }

        //FUNCION PARA OBTENER LA INFORMACION DEL UN ARTICULO
        public static ArticuloInfo GetArticuloInfo(string ArticuloId) {
            ArticuloInfo Articulo = new ArticuloInfo();
            DataTable TblResult;
            string Qry = "SELECT * FROM [TBL_ARTICULOS] WHERE [ARTICULO_ID]='@ART_ID'";
            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0) {
                Articulo.EXIST = true;
                Articulo.ID = TblResult.Rows[0]["ARTICULO_ID"].ToString();
                Articulo.DESCRIPCION = TblResult.Rows[0]["DESCRIPCION"].ToString();
                Articulo.PRECIO = TblResult.Rows[0]["PRECIO"].ToString();
                Articulo.COSTO = TblResult.Rows[0]["COSTO"].ToString();
                Articulo.ES_INVENTARIADO = TblResult.Rows[0]["INV"].ToString();
                Articulo.UNIDAD = TblResult.Rows[0]["UNIDAD"].ToString();
                Articulo.FOTO = GetArticuloFoto(Articulo.ID);//Obtener la foto del articulo.
                Articulo.INVENTARIO = GetInventarioInfo(Articulo.ID);//Obtener la informacion del inventario
            } else {
                Articulo.EXIST = false;
                Articulo.PRECIO = "0";

            }
            return Articulo;
        }

        //FUNCION PARA OBTENER LA INFORMACION DEL INVENTARIO DEL ARTICULO.
        public static InventarioInfo GetInventarioInfo(string ArticuloId) {
            string Qry = "SELECT * FROM [TBL_INVENTARIO_VIEW] WHERE [ARTICULO_ID]='@ART_ID'";
            InventarioInfo InvInfo = new InventarioInfo();
            DataTable TblResult;

            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0) {
                InvInfo.EXISTS = true;
                InvInfo.DISPONIBLE = Convert.ToBoolean(TblResult.Rows[0]["DISPONIBLE"]);
                InvInfo.ID = TblResult.Rows[0]["ARTICULO_ID"].ToString();
                InvInfo.ENTRADA = Convert.ToDouble(TblResult.Rows[0]["ENTRADA"]);
                InvInfo.SALIDA = Convert.ToDouble(TblResult.Rows[0]["SALIDA"]);
                InvInfo.STOCK = Convert.ToDouble(TblResult.Rows[0]["STOCK"]);
                InvInfo.INVERSION = Convert.ToDouble(TblResult.Rows[0]["INVERSION"]);
                InvInfo.GANANCIA_GENERADA = Convert.ToDouble(TblResult.Rows[0]["GANCIAS_GENERADAS"]);
                InvInfo.STATUS_DESC = TblResult.Rows[0]["STATUS_DESC"].ToString();

            } else {
                InvInfo.Clear();
            }
            return InvInfo;
        }

        //FUNCION PARA AGREGAR UN NUEVO ARTICULO ALA BD.
        public static bool SaveArticulo(ArticuloInfo Articulo) {
            string QryInsert = //ESTA INSTRUCCION SQL ES PARA INSERTAR UN ARTICULO EN LA BD.
           " INSERT INTO TBL_ARTICULOS (ARTICULO_ID,DESCRIPCION,UNIDAD,PRECIO,COSTO,INV)" +
           " VALUES('@ID','@DESCRIPCION','@UNIDAD','@PRECIO','@COSTO','@INV')";
            string QryUpdate =
            " UPDATE TBL_ARTICULOS" +
            " SET ARTICULO_ID='@ID',DESCRIPCION='@DESCRIPCION',UNIDAD='@UNIDAD',PRECIO='@PRECIO',COSTO='@COSTO',INV='@INV'" +
            " WHERE ARTICULO_ID='@ID'";

            int Inv = Articulo.ES_INVENTARIADO.ToUpper() == "TRUE" ? 1 : 0;

            //Validamos si no esta registrado ya este articulo
            if (GetArticuloInfo(Articulo.ID).EXIST) { //Llamamos a la funcion GetArticuloInfo para saber si existe
                QryUpdate = QryUpdate.Replace("@ID", Articulo.ID.Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@DESCRIPCION", Articulo.DESCRIPCION.ToUpper().Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@PRECIO", Articulo.PRECIO.Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@COSTO", Articulo.COSTO.Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@UNIDAD", Articulo.UNIDAD.ToUpper().Trim().Replace(",", ""));
                QryUpdate = QryUpdate.Replace("@INV", Convert.ToInt16(Inv).ToString());//Convertimos a entero la variable bool para que guarde 1 o 0

                if (Execute(QryUpdate) > 0) {//Mandamos a llamar la funcion Execute para ejecutar la instruccion SQL 
                    return true;//Retornamos True si la funcion _Execute nos regresa mas 0

                } else {
                    return false;//Retornamos False si la funcion no nos regreso nada
                }


            } else {
                //Remplazamos los valores en la de la instruccion por los valores a insertar
                QryInsert = QryInsert.Replace("@ID", Articulo.ID.Replace(",", ""));
                QryInsert = QryInsert.Replace("@DESCRIPCION", Articulo.DESCRIPCION.ToUpper().Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@PRECIO", Articulo.PRECIO.Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@COSTO", Articulo.COSTO.Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@UNIDAD", Articulo.UNIDAD.ToUpper().Trim().Replace(",", ""));
                QryInsert = QryInsert.Replace("@INV", Convert.ToInt16(Inv).ToString());//Convertimos a entero la variable bool para que guarde 1 o 0

                if (Execute(QryInsert) > 0) {//Mandamos a llamar la funcion Execute para ejecutar la instruccion SQL {
                    return true;//Retornamos True si la funcion _Execute nos regresa mas 0

                } else {
                    return false;//Retornamos False si la funcion no nos regreso nada
                }

            }

        }

        //OBTENER LA FOTO DEL ARTICULO DE LA BD
        public static ImageInfo GetArticuloFoto(string ArticuloId) {
            var ImgInfo = new ImageInfo();
            var Tbl = new DataTable();
            var Qry = "SELECT FOTO FROM TBL_ARTICULOS_FOTO WHERE ARTICULO_ID = '@ARTICULO_ID' ";

            Qry = Qry.Replace("@ARTICULO_ID", ArticuloId.Replace("'", "''"));

            Tbl = Fill(Qry, "Temp");

            if (Tbl.Rows.Count > 0) {
                //Descomprimir foto de la Tbl a byte array
                ImgInfo.FSImage = (byte[])Tbl.Rows[0]["FOTO"];
            }

            return ImgInfo;
        }

        //OBTENER LA FOTO ACTUAL DEL USUARIO
        public static ImageInfo GetUserPicture(string UserId) {
            var ImgInfo = new ImageInfo();
            var Tbl = new DataTable();
            var Qry = "SELECT FOTO FROM TBL_USUARIOS WHERE USR_ID = @USR_ID ";

            Qry = Qry.Replace("@USR_ID", UserId.Replace("'", "''"));

            Tbl = Fill(Qry, "Temp");

            if (Tbl.Rows.Count > 0) {
                if (Tbl.Rows[0]["FOTO"] != DBNull.Value) {
                    //Descomprimir foto de la Tbl a byte array
                    ImgInfo.FSImage = (byte[])Tbl.Rows[0]["FOTO"];
                }
            }

            return ImgInfo;
        }

        //FUNCION PARA GUARDARLA INFORMACION DE LA FOTO DELARTICULO EN LA BD
        public static bool GuardarArticuloFoto(string ArticuloId, object Foto) {
            string InsertQry = "INSERT INTO TBL_ARTICULOS_FOTO (ARTICULO_ID,FOTO) VALUES(?,?)";
            string UpdateQry = "UPDATE TBL_ARTICULOS_FOTO SET ARTICULO_ID = ? ,FOTO = ? WHERE ARTICULO_ID = ?";
            int Counter = -1;
            var Tbl = new DataTable();


            Tbl = Fill("SELECT ARTICULO_ID FROM TBL_ARTICULOS_FOTO WHERE ARTICULO_ID = '" + ArticuloId.Replace("'", "''") + "'", "TblTemp");

            if (Tbl.Rows.Count > 0) {
                //SI LA FOTO DEL ARTICULO YA EXISTE
                _objCmd.Parameters.Clear();
                _objCmd.CommandText = UpdateQry;
                _objCmd.Parameters.Add(new OleDbParameter("?", ArticuloId));
                _objCmd.Parameters.Add(new OleDbParameter("?", Foto));
                _objCmd.Parameters.Add(new OleDbParameter("?", ArticuloId));

            } else {
                //SI NO EXISTE LA FOTO DEL ARTICULO
                _objCmd.Parameters.Clear();
                _objCmd.CommandText = InsertQry;
                _objCmd.Parameters.Add(new OleDbParameter("?", ArticuloId));
                _objCmd.Parameters.Add(new OleDbParameter("?", Foto));

            }

            Counter = _objCmd.ExecuteNonQuery();

            return (Counter > 0);

        }

        //GUARDAR LA FOTO DEL USUARIO EN LA BD
        public static bool GuardarUserFoto(string UserId, object Foto) {
            string UpdateQry = "UPDATE TBL_USUARIOS SET FOTO = ? WHERE USR_ID = ?";
            int Counter = -1;
            var Tbl = new DataTable();


            //SI LA FOTO DEL ARTICULO YA EXISTE
            _objCmd.Parameters.Clear();
            _objCmd.CommandText = UpdateQry;
            _objCmd.Parameters.Add(new OleDbParameter("?", Foto));
            _objCmd.Parameters.Add(new OleDbParameter("?", UserId));


            Counter = _objCmd.ExecuteNonQuery();

            return (Counter > 0);

        }

        //FUNCION PARA BUSCAR UN ARTICULO POR DESCRIPCION EN LA BD
        public static DataTable BuscarArticulo(string Buscar) {
            DataTable TblResult;
            string QryBuscar = @"
                SELECT TOP 1000 ARTICULO_ID AS [CODIGO],DESCRIPCION,UNIDAD,'@CurrencySymbol '+Str(PRECIO)+' @CurrencyCode' as [PRECIO],INV,FOTO 
                FROM TBL_ARTICULOS_SEARCH_VIEW 
                WHERE DESCRIPCION LIKE '%@BUSCAR%'
                ORDER BY ARTICULO_ID,DESCRIPCION
            ";
            QryBuscar = QryBuscar.Replace("@BUSCAR", Buscar.Replace("'", ""));
            QryBuscar = QryBuscar.Replace("@CurrencySymbol", Configurations.CurrencySymbol);
            QryBuscar = QryBuscar.Replace("@CurrencyCode", Configurations.CurrencyCode);

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

        //REMOVE UN ARTICULO DEL SISTEMA DE INVENTARIO
        public static bool RemoverDelInventario(ArticuloInfo Articulo) {

            Articulo.ES_INVENTARIADO = "False";//Indicar que el articulo no se va inventariar
            return SaveArticulo(Articulo);//Guardar los cambios realizados        
        }

        //REGISTRA EL ARTICULO EN LA BASE DE DATOS!
        public static int RegistrarVenta(string Id, string Descripcion, string Precio, string Costo, string Cantidad, string Total, string UsrId) {

            string Qry =
            " INSERT INTO TBL_VENTAS ([ARTICULO_ID],[DESCRIPCION],[PRECIO],[COSTO],[CANTIDAD],[TOTAL],[USR_ID],[OPEN],[FECHA])" +
            " VALUES('@ID','@DESCRIPCION','@PRECIO','@COSTO','@CANTIDAD','@TOTAL','@USR','1',NOW())";
            Qry = Qry.Replace("@ID", Id);
            Qry = Qry.Replace("@DESCRIPCION", Descripcion);
            Qry = Qry.Replace("@PRECIO", Precio);
            Qry = Qry.Replace("@COSTO", Costo);
            Qry = Qry.Replace("@USR", UsrId);
            Qry = Qry.Replace("@CANTIDAD", Cantidad);
            Qry = Qry.Replace("@TOTAL", Total);

            return Execute(Qry);

        }

        //REGISTRA UN ARTICULO AL SYSTEMA DE INVETARIO      
        public static int RegistrarInventario(ArticuloInfo Articulo, UserInfo User, TransactionType Transaccion, double Cantidad) {
            int Change = -1;
            string Qry =
           " INSERT INTO TBL_INVENTARIO (ARTICULO_ID,ENTRADA,SALIDA,FECHA,USR_ID,TRANS_TYPE)" +
           " VALUES('@ART_ID','@ENTRADA','@SALIDA',NOW(),'@USR_ID','@TRANS_TYPE')";

            Qry = Qry.Replace("@ART_ID", Articulo.ID);
            Qry = Qry.Replace("@USR_ID", User.Id.ToString());

            switch (Transaccion) {
                case TransactionType.INVENTARIO:
                    Qry = Qry.Replace("@TRANS_TYPE", "**ENTRADA_DE_INVENTARIO**");
                    Qry = Qry.Replace("@SALIDA", "0");
                    Qry = Qry.Replace("@ENTRADA", Cantidad.ToString());
                    break;
                case TransactionType.VENTA:
                    Qry = Qry.Replace("@TRANS_TYPE", "**VENTA**");
                    Qry = Qry.Replace("@SALIDA", Cantidad.ToString());
                    Qry = Qry.Replace("@ENTRADA", "0");
                    break;
            }

            Change = Execute(Qry);

            if (Change > 0) {
                Events.InventarioChange();
            }

            return Change;
        }

        //OBTIENE EL HISTORIAL DEL INVENTARIO DE UN ARTICULO
        public static DataTable GetInvHistorial(string ArticuloId) {
            string Qry = "SELECT A.*,B.NOMBRE AS USUARIO FROM TBL_INVENTARIO AS A INNER JOIN TBL_USUARIOS AS B ON A.USR_ID =B.USR_ID WHERE ARTICULO_ID='@ART_ID'";
            Qry = Qry.Replace("@ART_ID", ArticuloId.Replace(",", ""));
            return Fill(Qry, "TblResult");
        }

        //OBTIENE LA INFORMACION PARA EL CORTE DE CAJA
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

        //REALIZAR EL CORTE DE CAJA
        public static bool CerrarCaja(string UsrId) {
            string QryCerrarCaja =//CONSULTA PARA CERRAR LA CAJA DEL CAJERO
            " UPDATE TBL_VENTAS " +
            " SET [OPEN]= False,[CORTE_DE_CAJA]=NOW()" +
            " WHERE USR_ID= @USR_ID AND [OPEN]= True ";
            QryCerrarCaja = QryCerrarCaja.Replace("@USR_ID", UsrId.Replace("'", ""));
            if (Execute(QryCerrarCaja) > 0) {//EJECUTAMOS LA CONSULTA , SI HAY HAY REGISTROS AFECTADOS NOS REGRESA EL TOTAL DE REGISTROS AFECTADO POR LA CONSULTA {
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
        public static bool GuardarUsuario(UserInfo User) {
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

            QryExist = QryExist.Replace("@LOGIN", User.UserName.Replace("'", ""));

            QryUpdate = QryUpdate.Replace("@LOGIN", User.UserName.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@NOMBRE", User.Name.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@PASS", User.Password.Replace("'", ""));
            QryUpdate = QryUpdate.Replace("@TIPO", User.LevelType.Replace("'", ""));

            QryInsert = QryInsert.Replace("@LOGIN", User.UserName.Replace("'", ""));
            QryInsert = QryInsert.Replace("@NOMBRE", User.Name.Replace("'", ""));
            QryInsert = QryInsert.Replace("@PASSWORD", User.Password.Replace("'", ""));
            QryInsert = QryInsert.Replace("@TIPO", User.LevelType.Replace("'", ""));

            TblResult = Fill(QryExist, "TblResult");

            if (TblResult.Rows.Count > 0) {
                if (Execute(QryUpdate) > 0) {
                    GuardarUserFoto(User.Id.ToString(), User.Picture.FSImage);
                    return true;
                } else {
                    return false;
                }
            } else {
                if (Execute(QryInsert) > 0) {
                    GuardarUserFoto(User.Id.ToString(), User.Picture.FSImage);
                    return true;
                } else {
                    return false;
                }
            }




        }

        //OBTENEMOS INFORMACION DE UN USUARIO                      
        public static UserInfo GetUserInfo(string UsrId) {
            UserInfo Usr = new UserInfo();
            DataTable TblResult;
            string Qry = "SELECT * FROM TBL_USUARIOS WHERE USR_ID= @USR_ID";
            Qry = Qry = Qry.Replace("@USR_ID", UsrId);
            TblResult = Fill(Qry, "TblResult");

            if (TblResult.Rows.Count > 0) {
                Usr.Exists = true;
                Usr.Id = Convert.ToInt16(TblResult.Rows[0]["USR_ID"].ToString());
                Usr.Name = TblResult.Rows[0]["NOMBRE"].ToString();
                Usr.UserName = TblResult.Rows[0]["LOGIN"].ToString();
                Usr.Password = TblResult.Rows[0]["PASSWORD"].ToString();
                Usr.Date = Convert.ToDateTime(TblResult.Rows[0]["FECHA"].ToString());
                Usr.LevelType = TblResult.Rows[0]["TIPO"].ToString();
                Usr.DepositoEnCaja = TblResult.Rows[0]["DEPOSITO_DE_EFECTIVO"].ToString();
            }


            return Usr;
        }

        //BUSCA EL NOMBRE DE UN USUARIO EN LA DB
        public static DataTable BuscarUsuario(string Nombre) {
            string Qry = "SELECT USR_ID as ID,LOGIN AS USUARIO,NOMBRE,TIPO,FECHA FROM TBL_USUARIOS WHERE NOMBRE LIKE '%@BUSCAR%' OR LOGIN LIKE '%@BUSCAR%'";
            DataTable TblResult;

            Qry = Qry.Replace("@BUSCAR", Nombre.Replace("'", ""));
            TblResult = Fill(Qry, "TblResult");
            return TblResult;
        }

        //OBTIENE TODOS LO PEDIDOS NO CANCELADOS
        public static DataTable GetPedidos() {
            string Qry = "SELECT * FROM TBL_PEDIDOS_VIEW";
            return Fill(Qry, "TblPedidos");
        }

        //ELIMINA UN PEDIDO DE LA LISTA
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

        //OBTENER LA LISTA DE REGIONES
        public static DataTable GetRegionList() {
            string Qry = "SELECT [COUNTRY]+' - '+[LANGUAGE] as [COUNTRY],[CODE] FROM TBL_CULTURE_INFO ORDER BY COUNTRY ASC";
            DataTable Tbl = Fill(Qry, "TblRegionList");

            return Tbl;
        }

        #endregion

        #region  <FUNCION PARA IMPRIMR EL TIKET>

        private static ArticuloItemCollection _ArticulosList = new ArticuloItemCollection();
        private static string _Total = "";//Total de la venta
        private static string _Pago = "";//Pago del efectivo 
        private static string _Cambio = "";//Cambio del cliente

        //PROPIEDAD PARA ESTABLECER LOS ARTICULOS A IMPRIMIR
        public static ArticuloItemCollection ArticulosParaImprimir {
            set {
                _ArticulosList = value;
            }
        }

        //IMPRIME EL TIKET
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
                string Titulo = Configurations.NombreDelNegocio.ToUpper();//Obtenemos el nombre de la empresa de la base de datos
                string PiedeTiket = "Gracias por su compra!";

                Font font1 = new Font("Consolas", 12f, FontStyle.Regular);
                Font font2 = new Font("Consolas", (float)PiedePagTam, FontStyle.Regular);
                Font font4 = new Font("Courier New", 8f, FontStyle.Bold);

                Font font7 = new Font("Courier New", 7f, FontStyle.Bold);
                Font font8 = new Font("Consolas", (float)TituloTam, FontStyle.Bold);
                Font font9 = new Font("Courier New", 8f, FontStyle.Bold);

                string Cajero = "Le Atendio : " + DbRepository.LoggedUser.Name;//Nombre del Cajero
                e.PageSettings.Margins.Top = 0;
                e.PageSettings.Margins.Left = 0;
                e.PageSettings.Margins.Right = 0;
                e.Graphics.DrawString(Titulo, font8, Brushes.Black, PosX, PosY);
                PosY = PosY + 30;
                e.Graphics.DrawString("FECHA : " + DateTime.Now.ToString("dddd, dd-MMMM-yyyy", Configurations.RegionProvider).ToUpper(), font7, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString(Cajero, font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("-------------------------------------------------", font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                int iCount = 1;

                foreach (ArticuloItem Item in _ArticulosList) {

                    var Articulo = iCount.ToString() + "-" + Item.Articulo.DESCRIPCION;
                    var Cantidad = "CANT.: " + Item.Cantidad.ToString("00.00") + " @ $" + Functions.ToCurrency(Item.Articulo.PRECIO) + " = " + Functions.ToCurrency(Item.Total);

                    var FontColor = Item.IsDeleted ? Brushes.Gray : Brushes.Black;
                    var ArticuloDescFont = Item.IsDeleted ? new Font("Courier New", 10f, FontStyle.Strikeout) : new Font("Courier New", 10f, FontStyle.Bold);
                    var ArticuloDetailFont = Item.IsDeleted ? new Font("Courier New", 8f, FontStyle.Strikeout) : new Font("Courier New", 8f, FontStyle.Regular);

                    e.Graphics.DrawString(Articulo, ArticuloDescFont, FontColor, PosX, PosY);
                    PosY += 14;
                    e.Graphics.DrawString(Cantidad, ArticuloDetailFont, FontColor, PosX, PosY);
                    PosY += 14;
                    iCount++;
                }

                e.Graphics.DrawString("-------------------------------------------------", font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("TOTAL    : " + _Total, font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("EFECTIVO : " + _Pago, font4, Brushes.Black, PosX, PosY);
                PosY = PosY + 14;
                e.Graphics.DrawString("SU CAMBIO! " + _Cambio, font2, Brushes.Black, PosX, PosY);
                PosY = PosY + 16;
                e.Graphics.DrawString(PiedeTiket, font2, Brushes.Black, PosX, PosY);//Pie de tiket
                PosY = PosY + 24;
                //Fecha y Hra
                e.Graphics.DrawString(">" + DateTime.Now.ToString("dd-MMMM-yyyy hh:mm:ss tt", Configurations.RegionProvider).ToUpper(), font9, Brushes.Black, PosX, PosY);

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

        public static object ExecuteScalar(string Qry) {
            _objCmd.CommandText = Qry;
            return _objCmd.ExecuteScalar();        
        }

        #endregion

        #region  <EVENTOS DEL SISTEMA>

        public static class Events {

            //Delegados
            public delegate void OnInventarioChangeHandler();
            public delegate void OnVentaRegistradaChangeHandler();
            public delegate void OnCorteDeCajaHandler();
            public delegate void OnDepositoDeCajaChangeHandler(string Monto);

            //Eventos
            public static event OnInventarioChangeHandler OnInventarioChange;
            public static event OnVentaRegistradaChangeHandler OnVentaRegistradaChange;
            public static event OnCorteDeCajaHandler OnCorteDeCaja;
            public static event OnDepositoDeCajaChangeHandler OnDepositoDeCajaChange;


            //EVENTS FUNCTIONS DISPATCHER
            public static void InventarioChange() {
                if (OnInventarioChange != null) {
                    OnInventarioChange.Invoke();
                }
            }

            public static void CorteDeCajaChange() {
                if (OnCorteDeCaja != null) {
                    OnCorteDeCaja.Invoke();
                }
            
            }

            public static void VentaRegistradaChange() {
                if (OnVentaRegistradaChange != null) {
                    OnVentaRegistradaChange.Invoke();
                }
            }

            public static void DepositoDeCajaChange(string Monto) {

                if (OnInventarioChange != null) {

                    OnDepositoDeCajaChange.Invoke(Monto);
                }

            }

        }

        #endregion

    }

}
