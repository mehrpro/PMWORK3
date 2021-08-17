using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PMWORK.Repository
{
    public interface ISetDatabase
    {
        List<string> GetServerInstance();
        List<string> GetDatabaseListByServerName(ConnectionStrViewModel model);

        bool SqlServerConnect(ConnectionStrViewModel model);

    }

    public class SetDatabase : ISetDatabase
    {
        private readonly AppDbContext _context;

        //private delegate void StartJob();

        public SetDatabase(AppDbContext context)
        {
            _context = context;
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
                var srvConn = new ServerConnection(model.ServerName);
                srvConn.LoginSecure = true;
                var srv = new Server(srvConn);
                foreach (Database database in srv.Databases)
                    result.Add(database.Name);
                return result;
            }
            else
            {
                var srvConn = new ServerConnection(model.ServerName);
                srvConn.LoginSecure = false;
                var srv = new Server(srvConn);
                srv.ConnectionContext.Login = model.UserID;
                srv.ConnectionContext.Password = model.Password;
                foreach (Database database in srv.Databases)
                    result.Add(database.Name);
                return result;
            }
        }




        public bool SqlServerConnect(ConnectionStrViewModel model)
        {
            try
            {
                var servConn = new ServerConnection(model.ServerName)
                {
                    ServerInstance = model.InstanceName,
                    LoginSecure = model.WindowsAuthentication,
                    Login = model.UserID,
                    Password = model.Password
                };
                servConn.Connect();
                return servConn.IsOpen;
            }
            catch
            {
                return false;

            }

        }
    }
}
