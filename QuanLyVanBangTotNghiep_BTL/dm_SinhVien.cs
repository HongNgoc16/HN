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
    
    public partial class dm_SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dm_SinhVien()
        {
            this.VanBangTams = new HashSet<VanBangTam>();
            this.VanBangChinhThucs = new HashSet<VanBangChinhThuc>();
        }
    
        public int Id_SinhVien { get; set; }
        public string Ma_SinhVien { get; set; }
        public string Ho_Va_Ten { get; set; }
        public bool Gioi_Tinh { get; set; }
        public System.DateTime Ngay_Sinh { get; set; }
        public int Id_ChuyenNganh { get; set; }
        public int Id_KhoaHoc { get; set; }
        public string So_Dien_Thoai { get; set; }
        public string Email { get; set; }
        public decimal Diem_Trung_Binh_Tich_Luy { get; set; }
        public int Id_XepLoai { get; set; }
        public int Id_DonViQuanLy { get; set; }
        public bool Trang_Thai { get; set; }
    
        public virtual dm_ChuyenNganh dm_ChuyenNganh { get; set; }
        public virtual dm_DonViQuanLy dm_DonViQuanLy { get; set; }
        public virtual dm_KhoaHoc dm_KhoaHoc { get; set; }
        public virtual dm_XepLoai dm_XepLoai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VanBangTam> VanBangTams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VanBangChinhThuc> VanBangChinhThucs { get; set; }
    }
}
