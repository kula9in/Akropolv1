﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Akropol.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AkropolKaluginEntities : DbContext
    {
        public AkropolKaluginEntities()
            : base("name=AkropolKaluginEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Aircondit> Aircondit { get; set; }
        public DbSet<Bathroom> Bathroom { get; set; }
        public DbSet<Fond> Fond { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoomArend> RoomArend { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
