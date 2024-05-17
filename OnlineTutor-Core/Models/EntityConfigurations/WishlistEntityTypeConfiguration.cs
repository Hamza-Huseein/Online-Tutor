using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTutor_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor_Core.Models.EntityConfigurations
{
    public class WishlistEntityTypeConfiguration : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder.HasKey(x => x.WishListId);
            builder.Property(x => x.WishListId).UseIdentityColumn();
            builder.Property(x => x.ItemImage).IsRequired();
            builder.Property(x => x.ItemName).IsRequired();

            builder.HasMany<WishList>().WithOne().HasForeignKey(x => x.UserId);

        }
    }
}
