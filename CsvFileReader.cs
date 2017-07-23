using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmileBase
{
    public class CsvFileReader : ICsvFileReader
    {
        private readonly CsvReader Reader;

        public CsvFileReader(TextReader stream)
        {
            Reader = new CsvReader(stream);
        }

        public CsvFileReader(TextReader stream, CsvConfiguration configuration)
        {
            Reader = new CsvReader(stream, configuration);
        }

        /// <summary>
        /// Reads a string field from a specified column(name), given the current row position 
        /// </summary>
        public string GetField(string name)
        {
            return Reader.GetField(name);
        }

        /// <summary>
        /// Reads a typed field from a specified column(name), given the current row position 
        /// </summary>
        public T GetField<T>(string name)
        {
            return Reader.GetField<T>(name);
        }

        /// <summary>
        /// Tries to reads a typed field from a specified column(name), given the current row position 
        /// </summary>
        public bool TryGetField<T>(int index, out T intField)
        {
            return Reader.TryGetField(index, out intField);
        }

        /// <summary>
        /// Reads the complete record given the current row position, into a typed .NET object 
        /// </summary>
        public T GetRecord<T>()
        {
            return Reader.GetRecord<T>();
        }

        /// <summary>
        /// Reads all the CSV records, into a typed .NET object 
        /// </summary>
        public IEnumerable<T> GetRecords<T>()
        {
            return Reader.GetRecords<T>();
        }

        public bool Read()
        {
            return Reader.Read();
        }

        /// <summary>
        /// Reads the CSV header, into a typed .NET object 
        /// </summary>
        public bool ReadHeader()
        {
            return Reader.ReadHeader();
        }
    }
}
