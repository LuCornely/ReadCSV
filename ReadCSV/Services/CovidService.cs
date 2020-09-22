using CsvHelper;
using ReadCSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReadCSV.Mappers;
using System.IO;
using System.Text;

namespace ReadCSV.Services
{
    public class CovidService
    {
        public List<Covid> ReadCSVFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location, Encoding.Default))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.RegisterClassMap<CovidMap>();
                    var records = csv.GetRecords<Covid>().ToList();
                    return records;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void WriteCSVFile(string path, List<Covid> covid)
        {
            using (StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(true)))
            using (CsvWriter cw = new CsvWriter(sw))
            {
                cw.WriteHeader<Covid>();
                cw.NextRecord();
                foreach (Covid cvd in covid)
                {
                    cw.WriteRecord<Covid>(cvd);
                    cw.NextRecord();
                }
            }
        }
    }
}
