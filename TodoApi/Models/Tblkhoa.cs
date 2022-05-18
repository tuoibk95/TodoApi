using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class Tblkhoa
    {
        public Tblkhoa()
        {
            TblgiangViens = new HashSet<TblgiangVien>();
            TblsinhViens = new HashSet<TblsinhVien>();
        }

        public string Makhoa { get; set; } = null!;
        public string? Tenkhoa { get; set; }
        public string? Dienthoai { get; set; }

        public virtual ICollection<TblgiangVien> TblgiangViens { get; set; }
        public virtual ICollection<TblsinhVien> TblsinhViens { get; set; }
    }
}
