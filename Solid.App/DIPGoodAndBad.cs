using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.DIPGoodAndBad
{
    public class ProductService
    {

        private readonly IRepository _repoFromSqlServer;

        public ProductService(IRepository repoFromSqlServer)
        {
            _repoFromSqlServer = repoFromSqlServer;
        }


        public List<string> GetAll()
        {
            return _repoFromSqlServer.GetAll();
        }
    }


    public class ProductRepoFromSqlServer:IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "SQL 1", "SQLSERV 2" };
        }
    }
    public class ProductRepoFromOracleServer : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Oracle 1", "OracleSERV 2" };
        }
    }


    public interface IRepository
    {
        List<string> GetAll();
    }
}
