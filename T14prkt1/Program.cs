using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14prkt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите координаты 1 точки x,y");
            Point points = new Point();
            points.GetX = double.Parse(Console.ReadLine());
            points.GetY = double.Parse(Console.ReadLine());
            //Console.WriteLine(points.ToString());
            Console.WriteLine($"Kоординаты 2 точки x,y");
            Point points1 = new Point();
            points1.GetX = 1.0;
            points.GetY = 1.0;
            Console.WriteLine(points1.ToString());
            Console.ReadKey();
            
            
        }
    }
}
