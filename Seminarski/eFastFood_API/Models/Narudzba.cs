//------------------------------------------------------------------------------
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
    
    public partial class Narudzba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Narudzba()
        {
            this.NarudzbaStavka = new HashSet<NarudzbaStavka>();
            this.Dostava = new HashSet<Dostava>();
            this.Racun = new HashSet<Racun>();
        }
    
        public int NarudzbaID { get; set; }
        public string VrstaNarudzbe { get; set; }
        public System.DateTime Datum { get; set; }
        public decimal UkupnaCijena { get; set; }
        public int KlijentID { get; set; }
        public string Status { get; set; }
    
        public virtual Klijent Klijent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NarudzbaStavka> NarudzbaStavka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostava> Dostava { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }
    }
}
