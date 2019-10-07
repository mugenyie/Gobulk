using System;
using System.Collections.Generic;
using System.Text;

namespace Gobulk.Data
{
    public static class GobulkDbInitializer
    {
        public static void Initialize(GobulkDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
