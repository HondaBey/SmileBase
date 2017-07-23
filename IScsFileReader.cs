using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmileBase
{
    public interface ICsvFileReader
    {
        string GetField(string name);
        T GetField<T>(string name);
        bool TryGetField<T>(int index, out T intField);

        T GetRecord<T>();
        IEnumerable<T> GetRecords<T>();

        bool Read();
        bool ReadHeader();
    }
}
