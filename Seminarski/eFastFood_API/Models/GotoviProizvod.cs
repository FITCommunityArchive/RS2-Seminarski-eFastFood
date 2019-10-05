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
    using System.Collections.Generic;

    public partial class GotoviProizvod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GotoviProizvod()
        {
            this.GPProizvod = new HashSet<GPProizvod>();
            this.NarudzbaStavka = new HashSet<NarudzbaStavka>();
            this.Ocjena = new HashSet<Ocjena>();
        }

        public int GotoviProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        public Nullable<int> VrijemePripreme { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaUmanjeno { get; set; }
        public int KategorijaID { get; set; }
        public bool VidljivostMobile { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPProizvod> GPProizvod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NarudzbaStavka> NarudzbaStavka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocjena> Ocjena { get; set; }
    }
}
