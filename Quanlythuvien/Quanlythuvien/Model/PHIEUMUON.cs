//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlythuvien.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUMUON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUMUON()
        {
            this.CHITIETPHIEUMUONs = new HashSet<CHITIETPHIEUMUON>();
        }
    
        public string MaMuon { get; set; }
        public string SoThe { get; set; }
        public Nullable<System.DateTime> NgayMuon { get; set; }
        public Nullable<System.DateTime> HanTra { get; set; }
        public string MaNV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUMUON> CHITIETPHIEUMUONs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual THETHUVIEN THETHUVIEN { get; set; }
    }
}