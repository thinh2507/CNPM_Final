//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCaSi
{
    using System;
    using System.Collections.Generic;
    
    public partial class BaiHat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiHat()
        {
            this.ChiTietAlbum = new HashSet<ChiTietAlbum>();
            this.NhacSi = new HashSet<NhacSi>();
        }
    
        public string MaBaiHat { get; set; }
        public string TenBaiHat { get; set; }
        public string MaNhacSi { get; set; }
        public string GiaiDieu { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietAlbum> ChiTietAlbum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhacSi> NhacSi { get; set; }
    }
}
