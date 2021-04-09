namespace GODZILLA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[dbo.ChiTietXuats]")]
    public partial class dbo_ChiTietXuats
    {
        [Key]
        [StringLength(20)]
        public string MaPhieuXuat { get; set; }

        [Required]
        [StringLength(20)]
        public string MaHangHoa { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngayxuat { get; set; }

        [Required]
        [StringLength(20)]
        public string MaKhachHang { get; set; }
    }
}
