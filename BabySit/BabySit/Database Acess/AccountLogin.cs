using BabySit.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Acess
{
    public class AccountLogin
    {
        private ProjectPRNContext context = null;
        public DbSet<User> SomeModels { get; set; }
        public AccountLogin()
        {
            context = new ProjectPRNContext();
        }
        
    }
}
