using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Persistence
{
    public class FileClient : IFileClient
    {
        public IEnumerable<T> ReadAll<T>(string fileName)
        {
            var jsonItems = File.ReadAllLines(fileName);
            
            return jsonItems.Select(jsonItem => JsonSerializer.Deserialize<T>(jsonItem));
        }

        public void Append<T>(string fileName, T item)
        {
            var jsonItem = JsonSerializer.Serialize(item);
            
            File.AppendAllLines(fileName, new []{ jsonItem });
        }

        public void WriteAll<T>(string fileName, IEnumerable<T> items)
        {
            var jsonItems = items.Select(item => JsonSerializer.Serialize(item));
            
            File.WriteAllLines(fileName, jsonItems);
        }

        public void DeleteFileContents(string fileName)
        {
            File.WriteAllLines(fileName, Array.Empty<string>());
        }
    }
}