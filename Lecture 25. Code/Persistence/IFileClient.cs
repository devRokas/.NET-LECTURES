using System.Collections.Generic;

namespace Persistence
{
    public interface IFileClient
    {
        IEnumerable<T> ReadAll<T>(string fileName);

        void Append<T>(string fileName, T item);
        
        void WriteAll<T>(string fileName, IEnumerable<T> items);

        void DeleteFileContents(string fileName);
    }
}