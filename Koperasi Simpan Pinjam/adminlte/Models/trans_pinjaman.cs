//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace adminlte.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class trans_pinjaman
    {
        public int no_pinj { get; set; }
        public Nullable<System.DateTime> tglpinj { get; set; }
        public Nullable<double> bunga { get; set; }
        public double jlh { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> angsuran { get; set; }
        public string status { get; set; }
        public string kd_pinj { get; set; }
        public string no_ang { get; set; }
        public string keterangan { get; set; }
        public Nullable<double> lama { get; set; }
    }
}
