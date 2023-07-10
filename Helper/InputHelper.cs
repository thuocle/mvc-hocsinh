using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinhMVC.Helper
{
    enum InputType
    {
        Them,
        Sua,
        Xoa
    }
    class InputHelper
    {
      
        public static int InputINT(string msg, string err)
        {
            bool check = true;
            int ret;
            do
            {
                Console.WriteLine(msg);
                check = int.TryParse(Console.ReadLine(), out ret);
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
        public static string InputSTRING(string msg, string err, int minLength = 0, int maxLength = int.MaxValue)
        {
            bool check = true;
            string ret;
            do
            {
                Console.WriteLine(msg);
                ret = Console.ReadLine();
                check = ret.Length >= minLength && ret.Length <= maxLength;
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
        public static DateTime InputDATETIME(string msg, string err, DateTime minDate, DateTime maxDate)
        {
            bool check = true;
            DateTime ret;
            do
            {
                Console.WriteLine(msg);
                check = DateTime.TryParse(Console.ReadLine(), out ret);
                check = check && ret >= minDate && ret <= maxDate;
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
    }
}
