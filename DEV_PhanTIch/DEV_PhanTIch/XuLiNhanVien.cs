using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_PhanTIch
{
    public class XuLiNhanVien
    {
        DataThuocDataContext data = new DataThuocDataContext();


        public IQueryable<NhanVien> loadNV()
        {
            return data.NhanViens.Select(t => t);
        }


        public bool ThemNV(String pmaNV, String phoTen, String pgioitinh, int ptuoi, String pdiaChi, string pchucvu, String pphanQuyen, String ptenDN, String pMK)
        {

        }
    }
}
