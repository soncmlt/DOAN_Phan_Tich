using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DEV_PhanTIch
{
    public class XuLiBanHang
    {
        DataThuocDataContext data = new DataThuocDataContext();
        public IQueryable<Thuoc> loadThuoc()
        {

            return data.Thuocs.Select(t => t);
        }
    }
}
