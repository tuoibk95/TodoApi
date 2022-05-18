using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class TblgiangVien
    {
        public TblgiangVien()
        {
            TblhuongDans = new HashSet<TblhuongDan>();
        }

        public int Magv { get; set; }
        public string? Hotengv { get; set; }
        public decimal? Luong { get; set; }
        public string? Makhoa { get; set; }

        public virtual Tblkhoa? MakhoaNavigation { get; set; }
        public virtual ICollection<TblhuongDan> TblhuongDans { get; set; }
    }
}
