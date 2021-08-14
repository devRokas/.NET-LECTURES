using System.Collections.Generic;

namespace Persistence
{
    public interface ISqlClient
    {
        int Execute(string sql, object param = null);

        IEnumerable<T> Query<T>(string sql, object param = null);
    }
}