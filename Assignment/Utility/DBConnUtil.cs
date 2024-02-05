using Microsoft.Extensions.Configuration;
using System.IO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Utility
{
    //Install the Following Packages
    //Microsoft.Extension Configuration
    //Microsoft.Extension.Configuration.FileEXtension
    //Microsoft.Extension.Configuration.json
    internal static class DBConnUtil
    {
        private static IConfiguration _iConfiguration;
        //constructor
        static DBConnUtil()
        {
            GetAppSettingsFile();
        }
        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _iConfiguration = builder.Build();
        }
        public static string GetConnectionString()
        {
            return _iConfiguration.GetConnectionString("LocalConnString");
        }
    }
}
