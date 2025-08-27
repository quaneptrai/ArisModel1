using Aris3._0FE.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0.Infrastructure.Data.Context
{
    public class ArisDbContextFactory : IDesignTimeDbContextFactory<ArisDbContext>
    {
        public ArisDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ArisDbContext>();
            optionsBuilder.UseSqlServer("Server=db26092.public.databaseasp.net; Database=db26092; User Id=db26092; Password=585810quan; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
            return new ArisDbContext(optionsBuilder.Options);
        }
    }
}
