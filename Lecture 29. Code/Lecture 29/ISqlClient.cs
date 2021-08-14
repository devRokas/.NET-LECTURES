using System.Collections.Generic;

namespace Lecture_29
{
    public interface ISqlClient
    {
        int Execute(string sql, object param = null);

        IEnumerable<T> Query<T>(string sql, object param = null);
    }
}