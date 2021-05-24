using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DEV_PhanTIch
{
    public class XuLiBanHang
    {
        DataThuocDataContext data = new DataThuocDataContext();
        public IQueryable<Thuoc> loadThuoc()
        {
            return data.Thuocs.Select(t => t);
        }
        public IQueryable<Thuoc> loadThuoc(string ten)
        {
            return data.Thuocs.Where(t => t.ten_thuoc == ten);
        }
        public IQueryable<KhachHang> loadKH(string pMaKH)
        {
            return data.KhachHangs.Where(t => t.maKH == pMaKH);
        }
        public void themHoaDon(string maHD, string maNV, string maKH, DateTime NgayXuat, int tongTien)
        {
            HoaDonXuat hd = new HoaDonXuat();
            hd.maHD_Xuat = maHD;
            hd.maNV = maNV;
            hd.maKH = maKH;
            hd.ngay_xuat = NgayXuat;
            hd.tong_tien = 111;

            data.HoaDonXuats.InsertOnSubmit(hd);
            data.SubmitChanges();
        }

    }
}
