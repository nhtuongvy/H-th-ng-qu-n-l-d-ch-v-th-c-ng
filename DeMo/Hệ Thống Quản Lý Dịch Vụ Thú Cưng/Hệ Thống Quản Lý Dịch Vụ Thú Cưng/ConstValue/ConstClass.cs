using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng.ConstValue
{
    class ConstClass
    {
        /// <summary>
        /// Tạo connect string để liên kết đến Database
        /// Muốn sử dụng thì cần đổi tên Data Source phù hợp với tên SQL Server
        /// </summary>
        public static string ConnectString = @"Data Source = VYVY\VY; Initial Catalog = DEMO; Integrated Security = True";
        public static string username;
        public static string dathang;
    }
}
