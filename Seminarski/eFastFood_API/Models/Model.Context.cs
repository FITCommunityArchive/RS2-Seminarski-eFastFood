﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eFastFood_API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class eFastFoodEntitie : DbContext
    {
        public eFastFoodEntitie()
            : base("name=eFastFoodEntitie")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dobavljac> Dobavljac { get; set; }
        public virtual DbSet<GotoviProizvod> GotoviProizvod { get; set; }
        public virtual DbSet<GPProizvod> GPProizvod { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<MjernaJedinica> MjernaJedinica { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<NarudzbaStavka> NarudzbaStavka { get; set; }
        public virtual DbSet<Proizvod> Proizvod { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<Uposlenik> Uposlenik { get; set; }
        public virtual DbSet<Dostava> Dostava { get; set; }
    
        public virtual ObjectResult<esp_BrojNarudzbiAll_Result> esp_BrojNarudzbiAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_BrojNarudzbiAll_Result>("esp_BrojNarudzbiAll");
        }
    
        public virtual int esp_ProizvodOduzmi(Nullable<int> proizvodId, Nullable<decimal> oduzeti)
        {
            var proizvodIdParameter = proizvodId.HasValue ?
                new ObjectParameter("ProizvodId", proizvodId) :
                new ObjectParameter("ProizvodId", typeof(int));
    
            var oduzetiParameter = oduzeti.HasValue ?
                new ObjectParameter("Oduzeti", oduzeti) :
                new ObjectParameter("Oduzeti", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_ProizvodOduzmi", proizvodIdParameter, oduzetiParameter);
        }
    
        public virtual int esp_GPPDeleteByGPID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_GPPDeleteByGPID", idParameter);
        }
    
        public virtual int esp_GPPAdd(Nullable<int> gotoviProizvodID, Nullable<int> proizvodID, Nullable<decimal> kolicinaUtroska, Nullable<int> mjernaJedinicaID)
        {
            var gotoviProizvodIDParameter = gotoviProizvodID.HasValue ?
                new ObjectParameter("GotoviProizvodID", gotoviProizvodID) :
                new ObjectParameter("GotoviProizvodID", typeof(int));
    
            var proizvodIDParameter = proizvodID.HasValue ?
                new ObjectParameter("ProizvodID", proizvodID) :
                new ObjectParameter("ProizvodID", typeof(int));
    
            var kolicinaUtroskaParameter = kolicinaUtroska.HasValue ?
                new ObjectParameter("KolicinaUtroska", kolicinaUtroska) :
                new ObjectParameter("KolicinaUtroska", typeof(decimal));
    
            var mjernaJedinicaIDParameter = mjernaJedinicaID.HasValue ?
                new ObjectParameter("MjernaJedinicaID", mjernaJedinicaID) :
                new ObjectParameter("MjernaJedinicaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_GPPAdd", gotoviProizvodIDParameter, proizvodIDParameter, kolicinaUtroskaParameter, mjernaJedinicaIDParameter);
        }
    }
}
