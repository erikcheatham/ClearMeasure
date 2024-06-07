using ClearMeasureLibrary;

namespace ClearMeasure
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter your upper bound");
        //    int i = int.Parse(Console.ReadLine());
        //    WriteOut(i);
        //}

        //public static void WriteOut(int upperBound)
        //{
        //    for (int i = 1; i <= upperBound; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //            Console.WriteLine("Erik Cheatham");
        //        else if (i % 3 == 0)
        //            Console.WriteLine("Erik");
        //        else if (i % 5 == 0)
        //            Console.WriteLine("Cheatham");
        //        else
        //            Console.WriteLine(i);
        //    }
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your upper bound");
            int upperBound = int.Parse(Console.ReadLine());
            
            ClearMeasureLibrary.Program p = new ClearMeasureLibrary.Program();
            
            string[] v = p.WriteOut(upperBound);
            
            for (int i = 0; i <= upperBound - 1; i++)
                Console.WriteLine(v[i]);
        }
    }
}
