using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KBCsv;


namespace FinishLine.Core
{
    public class CountryRepository
    {
        private Dictionary<string, string> _countries = new Dictionary<string, string>();
        public const string DATA_PATH = @"Data\countries.csv";

        public CountryRepository()
        {
            ReadCSVFromFile();
        }

        private void ReadCSVFromFile()
        {
            string localPathToData = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, DATA_PATH);

            using (var streamReader = new StreamReader(localPathToData))
            using (CsvReader reader = new CsvReader(streamReader))
            {
                reader.ValueSeparator = ';';
                reader.ReadHeaderRecord();
                while (reader.HasMoreRecords)
                {
                    var dataRecord = reader.ReadDataRecord();
                    _countries.Add(dataRecord[0], dataRecord[1]);
                }
            } 
        }

        public Dictionary<string, string> GetCountries()
        {
            return _countries;
        }
    }
}
