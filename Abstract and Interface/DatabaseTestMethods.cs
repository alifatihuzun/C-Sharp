﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class BaseDb
    {   
        public abstract string GetDbVersion();
        public DataTable ExecuteSql(string sql)
        {
            // generate sql
            return new DataTable();
        }
    }
    public class SqlServerDb: BaseDb
    {
        public override string GetDbVersion() => "SqlServer 2012";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID = {id}";
        }
        
    }
    public class OracleDb: BaseDb
    {
        public override string GetDbVersion() => "SqlServer 2012";
        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WHERE USER_ID = {id}";
        }
    }
}
