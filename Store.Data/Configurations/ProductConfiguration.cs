using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "dbo").HasKey(x => x.Id);
          //  builder.HasMany(_ => _.Category).WithOne(_ => _.Product).HasForeignKey(_ => _.VesselId);
         // builder.HasOne(_ => _.category).WithMany(x => x.product).HasForeignKey(x => x.Id);
        }
    }
}
