using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HocSinhMVC.Helper;

namespace HocSinhMVC.Model
{
    class HocSinh
    {
        public int HocSinhID { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }

        public HocSinh(InputType iptype)
        {
            if (iptype == InputType.Them || iptype == InputType.Sua) 
            {
                HocSinhID = InputHelper.InputINT(res.InpIDHS, res.ErrIDHS);
                Ten = InputHelper.InputSTRING(res.InpTen, res.ErrTen, 6, 20);
                NgaySinh = InputHelper.InputDATETIME(res.InpNgSinh, res.ErrNgSinh, new DateTime(2005, 01, 01), new DateTime(2016, 12, 31));
            }
            else if(iptype == InputType.Xoa)
            {
                HocSinhID = InputHelper.InputINT(res.InpIDHS, res.ErrIDHS);
            }

        }
        public void HienThi()
        {
            Console.WriteLine($"ID: {HocSinhID} Ho va Ten: {Ten} - sinh ngay {NgaySinh.ToShortDateString()}");
        }
    }
}
