﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CUAHANGTIENLOI : DbContext
    {
        public CUAHANGTIENLOI()
            : base("name=CUAHANGTIENLOI")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<CTPHIEUNHAP> CTPHIEUNHAPs { get; set; }
        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAISP> LOAISPs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<QUYEN> QUYENs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
    
        public virtual ObjectResult<danhsachhanghoa_Result> danhsachhanghoa()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<danhsachhanghoa_Result>("danhsachhanghoa");
        }
    
        public virtual ObjectResult<DANHSACHHOADON_Result> DANHSACHHOADON()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DANHSACHHOADON_Result>("DANHSACHHOADON");
        }
    
        public virtual ObjectResult<DANHSACHNV_Result> DANHSACHNV()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DANHSACHNV_Result>("DANHSACHNV");
        }
    
        public virtual ObjectResult<DGVHANGHOA_Result> DGVHANGHOA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DGVHANGHOA_Result>("DGVHANGHOA");
        }
    
        public virtual ObjectResult<Nullable<int>> LAYMAHANG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("LAYMAHANG");
        }
    
        public virtual ObjectResult<Nullable<int>> LAYMAHD()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("LAYMAHD");
        }
    
        public virtual ObjectResult<Nullable<int>> LAYMAPN()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("LAYMAPN");
        }
    
        public virtual ObjectResult<rpt_Hoadon_final_Result> rpt_Hoadon_final()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rpt_Hoadon_final_Result>("rpt_Hoadon_final");
        }
    
        public virtual ObjectResult<rpt_Hoadon1_Result> rpt_Hoadon1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rpt_Hoadon1_Result>("rpt_Hoadon1");
        }
    }
}
