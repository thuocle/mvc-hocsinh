using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HocSinhMVC.Model;
using HocSinhMVC.Helper;
namespace HocSinhMVC.Controller
{
     class HocSinhController
    {
        List<HocSinh> listHS = new List<HocSinh>();
        public ErrorType Them(HocSinh hs)
        {
            if (listHS.Count == 0)
            {
                listHS.Add(hs);
                return ErrorType.ThanhCong;
            }
            else
            {
                int pos = listHS.FindIndex(x => x.HocSinhID == hs.HocSinhID);
                if (pos == -1)
                {
                    listHS.Add(hs);
                    return ErrorType.ThanhCong;
                }
                return ErrorType.TrungMa;
            }
        }
        public ErrorType Sua(HocSinh hs)
        {
            if (listHS.Count == 0)
            {
                return ErrorType.DanhSachTrong;
            }
            else
            {
                int pos = listHS.FindIndex(x => x.HocSinhID == hs.HocSinhID);
                if (pos == -1) 
                    return ErrorType.KhongTimThayMa;
                listHS[pos] = hs;
                return ErrorType.ThanhCong;
            }
        }
        public ErrorType Xoa(HocSinh hs)
        {
            if (listHS.Count == 0)
            {
                return ErrorType.DanhSachTrong;
            }
            else
            {
                int pos = listHS.FindIndex(x => x.HocSinhID == hs.HocSinhID);
                if (pos == -1) 
                    return ErrorType.KhongTimThayMa;
                listHS.RemoveAt(pos);
                return ErrorType.ThanhCong;
            }
        }

        public ErrorType Hien()
        {
            if (listHS.Count == 0)
                return ErrorType.DanhSachTrong;
            else
            {
                listHS.ForEach(x => x.HienThi());
                return ErrorType.ThanhCong;
            }
        }
    }
}
