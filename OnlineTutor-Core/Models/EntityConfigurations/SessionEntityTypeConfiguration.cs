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
    public class SessionEntityTypeConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
           builder.HasKey(x => x.SessionId);
           builder.Property(x => x.SessionId).UseIdentityColumn();
           builder.Property(x => x.Capacity).IsRequired().HasDefaultValue(0).HasMaxLength(100);
           builder.Property(x => x.Topics).IsRequired();

           builder.HasMany<Session>().WithOne().HasForeignKey(x => x.CourseId);

        }
    }
}
