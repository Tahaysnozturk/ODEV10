using System;

namespace or096
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

            foreach (double burs in a)
            {
                if (burs < 500)
                {
                    double yeniBurs = burs * 1.1 + 50;
                    Console.WriteLine(yeniBurs);
                }
                else
                {
                    Console.WriteLine(burs);
                }
            }

            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
