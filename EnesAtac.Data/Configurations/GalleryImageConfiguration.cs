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
    public class GalleryImageConfiguration : IEntityTypeConfiguration<GalleryImages>
    {
        public void Configure(EntityTypeBuilder<GalleryImages> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("GalleryImages");
        }
    }
}
