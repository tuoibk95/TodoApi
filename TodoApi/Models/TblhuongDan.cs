using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class TblhuongDan
    {
        public int Masv { get; set; }
        public string? Madt { get; set; }
        public int? Magv { get; set; }
        public decimal? KetQua { get; set; }

        public virtual TbldeTai? MadtNavigation { get; set; }
        public virtual TblgiangVien? MagvNavigation { get; set; }
    }
}
