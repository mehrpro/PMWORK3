using Microsoft.SqlServer.Management.Common;
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
        object IsConnectiong(ConnectionStrViewModel model);
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

        public object IsConnectiong(ConnectionStrViewModel model)
        {     
            if (model.UserID == null)
            {
                Server srv1 = new Server(model.ServerName);   // connects to default instance  
                srv1.ConnectionContext.LoginSecure = model.WindowsAuthentication;   // set to true for Windows Authentication  
                //srv1.ConnectionContext.Login = model.UserID;
                //srv1.ConnectionContext.Password = model.Password;
                var re = srv1.Information.Version;


                ServerConnection srvConn = new ServerConnection(model.ServerName);
                var re2 = srv1.Name;
                srvConn.ServerInstance = model.InstanceName;
                srvConn.LoginSecure = model.WindowsAuthentication;
            
                //srvConn.Login = model.UserID;
                //srvConn.Password = model.Password;
                Server srv = new Server(srvConn);
                return srv.Information.Version;
            }
            else
            {
                ServerConnection srvConn = new ServerConnection(model.ServerName);
                srvConn.ServerInstance = model.InstanceName;
                srvConn.LoginSecure = model.WindowsAuthentication;
                srvConn.Login = model.UserID;
                srvConn.Password = model.Password;
                Server srv = new Server(srvConn);
                return srv.Information.Version;
            }


        }
    }
}
