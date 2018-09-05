using CQRSWithDapper.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Repositories
{
    public class BaseRepository<T> : IBaseRepository where T : class
    {
        public ISession Session => new Session(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=CQRSWithDapper;Integrated Security=True");

        public IEnumerable<T> Query<T>(string query, object param = null)
        {
            return Session.Query<T>(query, param);
        }
        public void Execute(string query, object param = null)
        {
             Session.Execute(query, param);
        }
    }
}
