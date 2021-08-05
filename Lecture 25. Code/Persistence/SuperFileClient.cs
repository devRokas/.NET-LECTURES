using System.Collections.Generic;

namespace Persistence
{
    public class SuperFileClient : IFileClient
    {
        public IEnumerable<T> ReadAll<T>(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void Append<T>(string fileName, T item)
        {
            throw new System.NotImplementedException();
        }

        public void WriteAll<T>(string fileName, IEnumerable<T> items)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteFileContents(string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}