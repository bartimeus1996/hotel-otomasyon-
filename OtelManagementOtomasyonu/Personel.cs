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
    
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.UrunSatis = new HashSet<UrunSati>();
        }
    
        public int PersonelID { get; set; }
        public int GorevId { get; set; }
        public Nullable<decimal> SicilNo { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }
        public string maas { get; set; }
        public Nullable<int> DogumYil { get; set; }
    
        public virtual GorevTbl GorevTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunSati> UrunSatis { get; set; }
    }
}
