//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelManagementOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class GorevTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GorevTbl()
        {
            this.Personels = new HashSet<Personel>();
        }
    
        public int GorevID { get; set; }
        public string GorevAd { get; set; }
        public string GorevKodu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personel> Personels { get; set; }
    }
}
