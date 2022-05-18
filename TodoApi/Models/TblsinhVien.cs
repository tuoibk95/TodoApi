using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class TblsinhVien
    {
        public int Masv { get; set; }
        public string? Hotensv { get; set; }
        public string? Makhoa { get; set; }
        public int? Namsinh { get; set; }
        public string? Quequan { get; set; }

        public virtual Tblkhoa? MakhoaNavigation { get; set; }
    }
}
