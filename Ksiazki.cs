//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ksiazki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ksiazki()
        {
            this.Wypozyczenia = new HashSet<Wypozyczenia>();
        }
    
        public int id_ksiazka { get; set; }
        public string isbn { get; set; }
        public int id_kategoria { get; set; }
        public string tytul { get; set; }
        public string opis { get; set; }
        public int id_autor { get; set; }
        public int id_wydawnictwo { get; set; }
        public int rok_wydania { get; set; }
    
        public virtual Autorzy Autorzy { get; set; }
        public virtual Kategorie Kategorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wypozyczenia> Wypozyczenia { get; set; }
        public virtual Wydawnictwa Wydawnictwa { get; set; }
    }
}
