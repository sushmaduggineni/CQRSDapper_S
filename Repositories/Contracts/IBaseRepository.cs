using System.Collections.Generic;

namespace CQRSWithDapper.Repositories.Contracts
{
    public interface IBaseRepository
    {
        void Execute(string query, object param = null);
        IEnumerable<T> Query<T>(string query, object param = null);
    }
}