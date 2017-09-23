using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan2.Bai6
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Console.WriteLine("Year:");
            int year = Int32.Parse(Console.ReadLine());
            if (checkValidation(year))
                Console.WriteLine(CAN(year) + " " + CHI(year));
            else
                Console.WriteLine("Year invalid");
            Console.ReadLine();
        }
        public bool checkValidation(int year)
        {
            if (year >= 1900)
                return true;
            return false;
        }
        public string CAN(int year)
        {
            switch ((year - 1900) % 10)
            {
                case 0:
                    return "CANH";
                case 1:
                    return "TAN";
                case 2:
                    return "NHAM";
                case 3:
                    return "QUY";
                case 4:
                    return "GIAP";
                case 5:
                    return "AT";
                case 6:
                    return "BINH";
                case 7:
                    return "DINH";
                case 8:
                    return "MAU";
                case 9:
                    return "KY";
            }
            return "";
        }
        public string CHI(int year)
        {
            switch ((year - 1900) % 12)
            {
                case 0:
                    return "TY";
                case 1:
                    return "SUU";
                case 2:
                    return "DAN";
                case 3:
                    return "MEO";
                case 4:
                    return "THIN";
                case 5:
                    return "TI";
                case 6:
                    return "NGO";
                case 7:
                    return "MUI";
                case 8:
                    return "THAN";
                case 9:
                    return "DAU";
                case 10:
                    return "TUAT";
                case 11:
                    return "HOI";
            }
            return "";
        }
    }
}
