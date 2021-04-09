namespace GODZILLA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[dbo.PhieuXuats]")]
    public partial class dbo_PhieuXuats
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaPhieuXuat { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string MaKhachHang { get; set; }
    }
}
