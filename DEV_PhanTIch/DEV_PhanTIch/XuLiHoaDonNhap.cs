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
    public class XuLiHoaDonNhap
    {
        DataThuocDataContext data = new DataThuocDataContext();

        public IQueryable<HoaDonNhap> loadhd_MaHD(string maHD)
        {
            return data.HoaDonNhaps.Where(c => c.maHD_Nhap.Contains(maHD));
        }
        public IQueryable<HoaDonNhap> loadhd_MaNV(string maNV)
        {
            return data.HoaDonNhaps.Where(c => c.maNV.Contains(maNV));
        }
    }
    
}
