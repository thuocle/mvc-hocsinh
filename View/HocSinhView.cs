using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HocSinhMVC.Controller;
using HocSinhMVC.Model;
using HocSinhMVC.Helper;

namespace HocSinhMVC.View
{
    class HocSinhView
    {
        HocSinhController hc = new HocSinhController();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------QUAN LY HOC SINH------------");
            Console.WriteLine("1. Hien thi hoc sinh\n" +
                "2. Them hoc sinh vao lop\n" +
                "3. Sua thong tin hoc sinh\n" +
                "4. Xoa hoc sinh\n" +
                "5. Thoat\n" +
                "Chon:");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
        }
        private void DoAction(char c) 
        {
            switch (c)
            {
                case '1':
                    ErrorHelper.Log(hc.Hien());
                    break;
                case '2':
                    ErrorHelper.Log(hc.Them(new HocSinh(InputType.Them)));
                    break;
                case '3':
                    ErrorHelper.Log(hc.Sua(new HocSinh(InputType.Sua)));
                    break;
                case '4':
                    ErrorHelper.Log(hc.Xoa(new HocSinh(InputType.Xoa)));
                    break;
                case '5':
                    return;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
