using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.TSQL {

    public class SQLParameter {

        public static int Counter = -1;
        public int Index;
        public string Name;
        public object Value;

        public SQLParameter(string Name, object Value) {
            Counter++;
            this.Name = Name;
            this.Value = Value;
            this.Index = SQLParameter.Counter;

        }
        
        public static void Reset() {
            Counter = -1;
        }

    }

}
