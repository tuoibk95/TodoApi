using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class TbldeTai
    {
        public TbldeTai()
        {
            TblhuongDans = new HashSet<TblhuongDan>();
        }

        public string Madt { get; set; } = null!;
        public string? Tendt { get; set; }
        public int? Kinhphi { get; set; }
        public string? Noithuctap { get; set; }

        public virtual ICollection<TblhuongDan> TblhuongDans { get; set; }
    }
}
