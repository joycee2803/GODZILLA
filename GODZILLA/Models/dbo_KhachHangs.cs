namespace GODZILLA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[dbo.KhachHangs]")]
    public partial class dbo_KhachHangs
    {
        [Key]
        [StringLength(20)]
        public string MaKhachHang { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKhachHang { get; set; }

        [Required]
        [StringLength(15)]
        public string SoDienThoai { get; set; }
    }
}
