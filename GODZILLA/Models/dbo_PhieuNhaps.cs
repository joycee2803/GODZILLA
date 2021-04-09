namespace GODZILLA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[dbo.PhieuNhaps]")]
    public partial class dbo_PhieuNhaps
    {
        [Key]
        [StringLength(20)]
        public string MaPhieuNhap { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [Required]
        [StringLength(15)]
        public string MaNCC { get; set; }
    }
}
