using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_PhanTIch
{
    public class XuLiThuoc
    {

        DataThuocDataContext data = new DataThuocDataContext();

        public IQueryable<Thuoc> loadThuoc()
        {
            return data.Thuocs.Select(t => t);
        }

        public IQueryable<Thuoc> timKiem(String pvalues, String pinfo)
        {
            if (pvalues == "Mã Thuốc")
                return data.Thuocs.Select(t => t).Where(t => t.ma_thuoc == "% " + pinfo + " %");
            else if(pvalues == "Tên Thuốc")
                return data.Thuocs.Select(t => t).Where(t => t.ten_thuoc == "% " + pinfo + " %");
            else
                return data.Thuocs.Select(t => t).Where(t => t.ma_nhom == "% " + pinfo + " %");

        }
    }
}
