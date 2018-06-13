using Microsoft.EntityFrameworkCore;
using System;

namespace PropertyApp.API.Data
{
    public class PropertyContext:DbContext
    {
        public PropertyContext(DbContextOptions<PropertyContext> options)
            : base(options)
        {
        }
        public DbSet<Property> Properties { get; set; }
    }
}
