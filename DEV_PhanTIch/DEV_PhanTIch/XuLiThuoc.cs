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
    }
}
