using EnesAtac.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Data.Configurations
{
    class MenuListConfiguration : IEntityTypeConfiguration<MenuList>
    {
        public void Configure(EntityTypeBuilder<MenuList> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.ToTable("MenuLists");
        }
    }
}
