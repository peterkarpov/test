﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ESN3Entities : DbContext
    {
        public ESN3Entities()
            : base("name=ESN3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
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
    }
}
