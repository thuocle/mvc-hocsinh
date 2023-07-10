using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinhMVC.Helper
{
    enum ErrorType
    {
        ThanhCong,
        TrungMa,
        DanhSachTrong,
        KhongTimThayMa
    }
    class ErrorHelper
    {
       public static void Log(ErrorType et)
        {
            switch (et)
            {
                case ErrorType.ThanhCong:
                    Console.WriteLine(res.ErrThanhCong);
                    break;
                case ErrorType.TrungMa:
                    Console.WriteLine(res.ErrTrungMa);
                    break;
                case ErrorType.DanhSachTrong:
                    Console.WriteLine(res.ErrDanhSachTrong);
                    break;
                case ErrorType.KhongTimThayMa:
                    Console.WriteLine(res.ErrKhongThayMa);
                    break;
            }
        }
    }
}
