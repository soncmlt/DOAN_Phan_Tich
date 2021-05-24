using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_PhanTIch
{
    public class XuLiKhachHang
    {
        DataThuocDataContext data = new DataThuocDataContext();

        public IQueryable<KhachHang> loadKH()
        {
            return data.KhachHangs.Select(t => t);
        }
        public bool ktraKH(String pmaKH)
        {
            if (data.KhachHangs.Select(t => t).Where(t => t.maKH == pmaKH).Count() > 0)
                return false;
            return true;
        }

        public bool ThemKH(String pmaKH, String phoTen, String pgioitinh, int ptuoi, String pSDT)
        {

            if (ktraKH(pmaKH))
            {
                KhachHang kh = new KhachHang()
                {
                    maKH = pmaKH,
                    ho_ten = phoTen,
                    gioi_tinh = pgioitinh,
                    tuoi = ptuoi,
                    soDT = pSDT,
                    diem = 0,
                    
                };
                data.NhanViens.InsertOnSubmit(nv);
                //data.SubmitChanges();
                loadNV();
                return true;
            }
        }
    }
}
