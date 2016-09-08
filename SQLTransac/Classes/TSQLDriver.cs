using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace System.Data.TSQL {
    
    public abstract class TSQLDriver {
        private List<SQLParameter> _lstSqlParameters = new List<SQLParameter>();
        private string _ConnectionString = "";

        [Description("Connection String")]
        public string ConnectionString {
            get {
                return _ConnectionString;
            }
        }
        [Description("SQL parameter list")]
        public List<SQLParameter> SqlVariables {
            set {
                _lstSqlParameters = value;
            }
            get {
                return _lstSqlParameters;
            }
        }
        [Description("Connection String")]
        public TSQLDriver(string ConnectionString) {
            _ConnectionString = ConnectionString;
        }
        [Description("Add SQL parameter. Parameter name must start with @ char")]
        public void AddSqlVar(string Name, object Value) {
            _lstSqlParameters.Add(new SQLParameter(Name, Value));
        }
        [Description("Clear sql parameter list. This function is executed after each transaction automatically")]
        public void ClearSqlVars() {
            _lstSqlParameters.Clear();
            SQLParameter.Reset();
        }

        #region ABSTRACT FUNCTIONS AND METHODS

        [Description("Fill a DataTable. Data Table default table name is TblTemp")]
        public abstract bool FillTbl(ref DataTable Tbl, string Qry, string TblName = "TblTemp");
        [Description("Fill a DataSet")]
        public abstract bool FillDs(ref DataSet Ds, string Qry, string[] TblNames = null);
        [Description("Excute a Qry and return the count of the affected rows.")]
        public abstract int SqlExec(string Qry);
        [Description("Execute a Qry and returns the first column of the first column.")]
        public abstract object SqlExecScalar(string Qry);
        [Description("Returns a prepared Commansd object.This function will add each sql parameter added before.")]
        public abstract object SqlPrepareCmd(string Qry);
        [Description("Close the database connection")]
        public abstract void Close();

        #endregion


    }
    
}
