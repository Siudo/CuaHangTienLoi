//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuaHangTienLoi
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHOADON
    {
        public int MAHD { get; set; }
        public int MAHANG { get; set; }
        public Nullable<int> SLBAN { get; set; }
    
        public virtual HANGHOA HANGHOA { get; set; }
        public virtual HOADON HOADON { get; set; }
    }
}
