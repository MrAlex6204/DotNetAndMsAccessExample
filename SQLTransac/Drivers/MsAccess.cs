using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.TSQL.Drivers {

    public class MsAccess : TSQL.TSQLDriver, IDisposable {

        #region VARIABLES DECLARATIONS

        private System.Data.OleDb.OleDbConnection _objConn = null;

        #endregion


        #region CONSTRUCTOR AND DESTRUCTOR CLASS

        public MsAccess(String ConnectionString)
            : base(ConnectionString) {

            try {
                _objConn = new System.Data.OleDb.OleDbConnection(this.ConnectionString);
                _objConn.Open();

            } catch (System.Data.OleDb.OleDbException ex) {
                throw ex;
            }
        }

        ~MsAccess() {
            Dispose();
        }

        public void Dispose() {

            try {
                _objConn.Dispose();
            } catch {

            }

        }

        #endregion

        #region OVERRIDDEN FUNCTIONS & METHODS

        public override bool FillTbl(ref DataTable Tbl, string Qry, string TblName = "TblTemp") {
            System.Data.OleDb.OleDbDataReader rd;
            using (System.Data.OleDb.OleDbCommand cmd = (System.Data.OleDb.OleDbCommand)SqlPrepareCmd(Qry)) {

                rd = cmd.ExecuteReader();
                using (rd) {
                    Tbl.Load(rd, LoadOption.OverwriteChanges);
                }
            }

            Tbl.TableName = TblName;

            ClearSqlVars();
            return (Tbl.Rows.Count > 0);
        }

        public override bool FillDs(ref DataSet Ds, string Qry, string[] TblNames = null) {
            using (System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter()) {
                int counter = 0;
                foreach (string iQry in Qry.Split(';')) {
                    if (iQry.Trim() != "") {
                        using (System.Data.OleDb.OleDbCommand cmd = (System.Data.OleDb.OleDbCommand)SqlPrepareCmd(iQry)) {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(Ds, counter.ToString());
                        }
                        counter++;
                    }
                }
            }

            if (TblNames != null & Ds.Tables.Count > 0) {
                for (int Idx = 0; Idx < TblNames.Length - 1; Idx++) {
                    Ds.Tables[Idx].TableName = TblNames[Idx];
                }
            }

            ClearSqlVars();
            return (Ds.Tables.Count > 0);
        }

        public override int SqlExec(string Qry) {

            using (System.Data.OleDb.OleDbCommand cmd = (System.Data.OleDb.OleDbCommand)SqlPrepareCmd(Qry)) {
                return cmd.ExecuteNonQuery();
            }
        }

        public override object SqlExecScalar(string Qry) {
            using (System.Data.OleDb.OleDbCommand cmd = (System.Data.OleDb.OleDbCommand)SqlPrepareCmd(Qry)) {
                return cmd.ExecuteScalar();
            }
        }

        public override object SqlPrepareCmd(string Qry) {
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            SQLParameter[] OledbVariables = _GetPreparedOledbVariables(ref Qry);

            foreach (SQLParameter iSqlVariable in OledbVariables) {
                cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("?", iSqlVariable.Value));
            }

            if (_objConn == null) {
                _objConn = new System.Data.OleDb.OleDbConnection(ConnectionString);
            }

            cmd.CommandText = Qry;
            cmd.Connection = _objConn;
            return cmd;
        }

        internal SQLParameter[] _GetPreparedOledbVariables(ref string Qry) {

            List<SQLParameter> LstOledbVariables = new List<SQLParameter>();
            SQLParameter[] SortedVariables = null;
            bool bNeedReSort = true;

            foreach (SQLParameter iSql in SqlVariables) {
                int Index = -1;
                do {
                    Index++;
                    Index = Qry.ToUpper().IndexOf(iSql.Name.ToUpper(), Index);
                    if (Index > -1) {
                        SQLParameter iTemp = new SQLParameter("?", iSql.Value);
                        iTemp.Index = Index;
                        LstOledbVariables.Add(iTemp);
                    }

                } while (Index > -1);

                Qry = Qry.Replace(iSql.Name, "?");
            }

            SortedVariables = LstOledbVariables.ToArray();

            while (bNeedReSort) {
                bNeedReSort = false;
                for (int Index = 0; Index < SortedVariables.Length - 1; Index++) {
                    if (SortedVariables[Index].Index > SortedVariables[Index + 1].Index) {
                        SQLParameter temp = SortedVariables[Index + 1];
                        SortedVariables[Index + 1] = SortedVariables[Index];
                        SortedVariables[Index] = temp;
                        bNeedReSort = true;
                    }
                }
            }
            return SortedVariables;
        }

        public override void Close() {

            if (_objConn.State != ConnectionState.Closed) {
                _objConn.Close();
            }

        }

        #endregion




    }

}
