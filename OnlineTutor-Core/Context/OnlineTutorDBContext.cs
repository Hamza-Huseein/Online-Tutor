using Microsoft.EntityFrameworkCore;
using OnlineTutor_Core.Models.Entity;
using OnlineTutor_Core.Models.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor_Core.Context
{
    public class OnlineTutorDBContext : DbContext
    {
        public OnlineTutorDBContext(DbContextOptions<OnlineTutorDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SessionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CourseEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WishlistEntityTypeConfiguration());


        }
        public virtual DbSet<User> Users  { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }
        public virtual DbSet<CourseSession> CourseSessions { get; set; }

    }
}
        
    
