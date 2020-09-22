using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ReadCSV.Services;

namespace ReadCSV
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Start CSV File Reading...");
            var _covidService = new CovidService();
            var path = @"C:\Covid1.csv";
            List<Models.Covid> lists = _covidService.ReadCSVFile(path);
            var resultData = lists;
           
        }
    }
}
