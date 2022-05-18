using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class TblDatHang
    {
        public int Id { get; set; }
        public string? MaHang { get; set; }
        public int? SoLuongDat { get; set; }

        public virtual TblKhoHang TblKhoHang { get; set; } = null!;
    }
}
