using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Repository
{
    public   interface ISetDatabase
    {
        List<string> GetServerInstance();
        List<string> GetDatabaseListByServerName(ConnectionStrViewModel model);
    }

    public class SetDatabase : ISetDatabase
    {
        private delegate void StartJob();
        private List<string> Instance()
        {
            var list = new List<string>();
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
                list.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            return list;
        }


        public List<string> GetServerInstance()
        {
            var list = new List<string>();
            list.Add(".");
            list.Add("(local)");
            list.Add(@".\SQLEXPRESS");
            list.Add(@"(LocalDB)\MSSQLLocalDB");
            list.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
                list.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            return list;                          
        }

        public List<string> GetDatabaseListByServerName(ConnectionStrViewModel model)
        {
            var result = new List<string>();
            if (model.WindowsAuthentication)
            {
                var srv = new Server(model.ServerName);
                foreach (Database database in srv.Databases)                
                    result.Add(database.Name);                
                return result;
            }
            else
            {
                var srv = new Server($"Data Source = {model.ServerName};User ID={model.UserID};Password={model.Password};");
                foreach (Database database in srv.Databases)                
                    result.Add(database.Name);                
                return result;
            }
        }
    }
}
