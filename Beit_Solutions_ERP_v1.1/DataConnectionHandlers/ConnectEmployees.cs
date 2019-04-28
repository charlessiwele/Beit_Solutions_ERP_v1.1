using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Beit_Solutions_ERP_v1._1.DataConnectionHandlers
{
    class ConnectEmployees : Connection
    {
        List<Object> SelectList(Object ObjectType, int CallCode)
        {
            List<Object> objectSelection = new List<object>();
            return objectSelection;
        }

        SqlDataAdapter SelectAdapter(Object ObjectType, int CallCode)
        {
            SqlDataAdapter objectSelection = new SqlDataAdapter();
            return objectSelection;
        }

        int Insert(List<Object> ObjectType, int CallCode)
        {
            int objectInsertion = 0;
            return objectInsertion;
        }

        int Update(List<Object> ObjectType, int CallCode)
        {
            int objectUpdate = 0;
            return objectUpdate;
        }

        int Delete(List<Object> ObjectType, int CallCode)
        {
            int objectDelete = 0;
            return objectDelete;
        }
    }
}
