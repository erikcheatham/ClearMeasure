
namespace ClearMeasureLibrary
{
    public class Program
    {
        //public string GetValues(int i)
        //{
            //Console.WriteLine("Enter your upper bound");
            //int i = int.Parse(Console.ReadLine());
            //return WriteOut(i);
        //}

        public string[] WriteOut(int upperBound)
        {
            string[] strings = new string[upperBound];
            for (int i = 1; i <= upperBound; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    strings[i - 1] = "Erik Cheatham";
                else if (i % 3 == 0)
                    strings[i - 1] = "Erik";
                else if (i % 5 == 0)
                    strings[i - 1] = "Cheatham";
                else
                    strings[i - 1] = i.ToString();
            }
            return strings;
        }
    }
}

//appropriate number of unit test - unit test project to make sure the program does what it is supposed to do

