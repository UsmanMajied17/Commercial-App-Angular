using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presistence
{
   
    public class XtheiaDbContextFactory : DesignTimeDbContextFactoryBase<XtheiaContext>
    {
        protected override XtheiaContext CreateNewInstance(DbContextOptions<XtheiaContext> options)
        {
            return new XtheiaContext(options);
        }
    }
}
