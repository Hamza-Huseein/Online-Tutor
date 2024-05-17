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
    public class CourseSessionEntityTypeConfiguration : IEntityTypeConfiguration<CourseSession>
    {
        public void Configure(EntityTypeBuilder<CourseSession> builder)
        {
            builder.HasKey(x => x.CourseSessionId);
            builder.Property(x => x.CourseSessionId).UseIdentityColumn();
            builder.Property(x => x.CourseId).IsRequired();
            builder.Property(x => x.SessionId).IsRequired();

        }
    }
}
