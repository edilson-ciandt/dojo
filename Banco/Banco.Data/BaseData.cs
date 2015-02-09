using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Data
{
    public abstract class BaseData
    {
        public Database GetDataBaseConnection()
        {
            return new DatabaseProviderFactory().Create("DataBase");
        }
    }
}
