//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyVanBangTotNghiep_BTL
{
    using System;
    using System.Collections.Generic;
    
    public partial class dm_XepLoai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dm_XepLoai()
        {
            this.dm_SinhVien = new HashSet<dm_SinhVien>();
        }
    
        public int Id_XepLoai { get; set; }
        public string Ma_XepLoai { get; set; }
        public string Ten_XepLoai { get; set; }
        public decimal Diem_Toi_Thieu { get; set; }
        public decimal Diem_Toi_Da { get; set; }
        public bool Trang_Thai_Su_Dung { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dm_SinhVien> dm_SinhVien { get; set; }
    }
}
