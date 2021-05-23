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

        //Hàm load nhân viên - Sơn
        public IQueryable<NhanVien> loadNV()
        {
            return data.NhanViens.Select(t => t);
        }

        //Kiểm tra thành viên có tồn tại chưa - Sơn
        public bool ktraNV(String pmaNV)
        {
            if (data.NhanViens.Select(t => t).Where(t => t.maNV == pmaNV).Count() > 0)
                return false;
            return true;
        }

        //Hàm Thêm Nhân Viên  - Sơn
        public bool ThemNV(String pmaNV, String phoTen, String pgioitinh, int ptuoi, String pdiaChi, String pchucvu,String pSDT)
        {
            if (ktraNV(pmaNV))
            {
                NhanVien nv = new NhanVien()
                {
                    maNV = pmaNV,
                    ho_ten = phoTen,
                    gioi_tinh = pgioitinh,
                    tuoi = ptuoi,
                    dia_chi = pdiaChi,
                    chuc_vu = pchucvu,
                    ten_DN = pmaNV,
                    matkhau = pSDT,
                    soDT =pSDT,
                    email = "",
                };
                data.NhanViens.InsertOnSubmit(nv);
                data.SubmitChanges();
                loadNV();
                return true;
            }
            else
                return false;
        }

        //Hàm Sửa Thông Tin Nhân Viên
        public void editNV(String pmaNV, String phoTen, String pgioitinh, int ptuoi, String pdiaChi, string pchucvu, String pEmail, String pSDT)
        {
            NhanVien nv = data.NhanViens.Where(t => t.maNV == pmaNV).Single();
            nv.maNV = pmaNV;
            nv.ho_ten = phoTen;
            nv.gioi_tinh = pgioitinh;
            nv.tuoi = ptuoi;
            nv.dia_chi = pdiaChi;
            nv.chuc_vu = pchucvu;
            nv.ten_DN = pmaNV;
            nv.matkhau = pSDT;
            nv.soDT = pSDT;
            nv.email = pEmail;
            data.SubmitChanges();
        }

        //Hàm Xóa Nhân Viên - Sơn
        public void deleteNV(String pmaNV)
        {
            NhanVien nv = data.NhanViens.Where(t => t.maNV == pmaNV).Single();
            nv.maNV = pmaNV;
            data.NhanViens.DeleteOnSubmit(nv);
            data.SubmitChanges();
        }


    }
}
