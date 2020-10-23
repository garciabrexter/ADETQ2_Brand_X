using ADETQ2_Brand_X.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADETQ2_Brand_X.Data
{
    public class datalist : DbContext
    {
        public datalist(DbContextOptions<datalist> options) : base(options)
        {

        }
        public DbSet<list> list { get; set; }
    }
}
