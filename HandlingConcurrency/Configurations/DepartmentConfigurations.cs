using HandlingConcurrency.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingConcurrency.Configurations
{
    public class DepartmentConfigurations : EntityTypeConfiguration<Department>
    {
        public DepartmentConfigurations()
        {
            var modelBuilder = this;

            modelBuilder
                .Property(p => p.RowVersion)
                .IsConcurrencyToken();
        }
    }
}
