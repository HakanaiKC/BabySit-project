using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Acess
{
    public class DataAcess
    {
        //Khai bao đối tượng kết nối va thuc thi cac truy van
        SqlConnection connection;
        SqlCommand command;

        string getConnectionString()
        {
            //Lay chuoi ket noi tu appsettings.json
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return configuration["ConnectionString:MyStoreDB"];
        }
    }
}
