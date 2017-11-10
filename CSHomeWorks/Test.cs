using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSHomeWorks.Test
{
    class Test : HomeWork
    {

        static string dir;
        public void RunHomeWork()
        {
            dir = AppDomain.CurrentDomain.BaseDirectory + "\\demo.bmp";
            Bitmap map = new Bitmap(dir);
            for(int y = 0; y < map.Height; y++)
            {
                for(int x = 0; x < map.Width; x++)
                {
                    if (map.GetPixel(x, y) != Color.FromArgb(255, 255, 255, 255))
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("{0,2}"," ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        continue;
                    }
                    Console.Write("{0,2}"," ");

                }
                Console.WriteLine();
            }

        }
    }
}
