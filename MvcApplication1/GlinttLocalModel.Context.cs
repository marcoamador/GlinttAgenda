﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class glinttLocalEntities : DbContext
    {
        public glinttLocalEntities()
            : base("name=glinttLocalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accesstokens> Accesstokens { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<LanguagePatient> LanguagePatient { get; set; }
        public DbSet<LanguagePractitioner> LanguagePractitioner { get; set; }
        public DbSet<OauthClients> OauthClients { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Practitioner> Practitioner { get; set; }
        public DbSet<Visit> Visit { get; set; }
    }
}
