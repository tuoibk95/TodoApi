using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class TblKhoHang
    {
        public int Id { get; set; }
        public string? MaHang { get; set; }
        public string? TenHang { get; set; }
        public int? SoLuongTon { get; set; }

        public virtual TblDatHang IdNavigation { get; set; } = null!;
    }
}
