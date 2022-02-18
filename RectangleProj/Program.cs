using System;

namespace RectangleProj
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter Legnth:");

            string legnth = Console.ReadLine();



            Console.WriteLine("Enter Width: ");

            string width = Console.ReadLine();


            Console.WriteLine("Legnth: " + legnth);

            Console.WriteLine("Width: " + width);*/

            int l = 0;
            int w = 0;

           // Console.WriteLine(l);
            //Console.WriteLine(w);

            GetRandomValue(out l, out w, 1, 100);

            Console.WriteLine(l);
            Console.WriteLine(w);

            Rectangle r = new Rectangle();

            r.legnth = l;
            r.width = w;

            Console.WriteLine("Area: " + Utility.Area(l, w ));

            Console.WriteLine("Perimeter: " + Utility.Parameter(l, w));




        }

        static void GetRandomValue(out int n1, out int n2, int min, int max)
        {
            Random ran = new Random();
            n1 = ran.Next(min, max);
            n2 = ran.Next(min, max);
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

    }


}

public class Rectangle
{
    public int width;

    public int legnth;
}


public class Utility
{

    static public int Area(int l, int w)
    {
        return l * w;
    }

    static public int Parameter(int l, int w)
    {
        return 2 * (l + w);
    }
}
