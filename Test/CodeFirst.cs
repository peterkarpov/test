namespace Test
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Common;
    using Entities;
    using System.Collections.Generic;

    public class SampleInitializer
        : DropCreateDatabaseIfModelChanges<CodeFirst>
    {
        // В этом методе можно заполнить таблицу по умолчанию
        protected override void Seed(CodeFirst context)
        {
            List<City> cities = new List<City>
            {
                new City { Name = "Москва" },
                new City { Name = "Санкт-Петербург" },
                new City { Name = "Казань" }
                // ...
            };

            foreach (City city in cities)
                context.Cities.Add(city);

            context.SaveChanges();
            base.Seed(context);
        }
    }









    public partial class CodeFirst : DbContext
    {





        public CodeFirst()
            : base("SSN2")
        {
            //Database.SetInitializer(
            //    new DropCreateDatabaseIfModelChanges<CodeFirst>());

            //Database.SetInitializer<CodeFirst>(new SampleInitializer());

        }

        public CodeFirst(DbConnection connection)
            : base(connection, false)
        {
        }

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Dislikes> Dislikes { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Photobooks> Photobooks { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Talks> Talks { get; set; }
        public virtual DbSet<Users> Users { get; set; }


        //custom

        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profiles>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Profiles)
                .HasForeignKey(e => e.from)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profiles>()
                .HasMany(e => e.Messages1)
                .WithRequired(e => e.Profiles1)
                .HasForeignKey(e => e.to)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profiles>()
                .HasMany(e => e.Talks)
                .WithRequired(e => e.Profiles)
                .HasForeignKey(e => e.Profile1Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profiles>()
                .HasMany(e => e.Talks1)
                .WithRequired(e => e.Profiles1)
                .HasForeignKey(e => e.Profile2Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Friends)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.ProfileId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.Profiles)
                .WithRequired(e => e.Users);
        }
    }
}
