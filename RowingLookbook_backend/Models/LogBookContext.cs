using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RowingLookbook_backend.Models
{
    public class LogBookContext: DbContext
    {
        private static LogBookContext _LogBookContext;
        public DbSet<Person> Persons { get; set; }
        public DbSet<Tour> Tours { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=LogBook.db");
        }

        public static LogBookContext GetContext()
        {
            if (_LogBookContext == null)
            {
                _LogBookContext = new LogBookContext();
            }
            return _LogBookContext;
        }
    }
}
