using System.Reflection.Metadata;

namespace ConsoleApp1;

public class Interval
{
    public int[] data;

    public Interval()
    {
        data = new int[4];
    }

    public void dataset1()
    {
        data[0] = 2;
        data[1] = 30;
        data[2] = 0;
        data[3] = 7;
    }

    public void IterateAndTest()
    {
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);
            if (data[i] is >= 1 and <= 10)
            {
                Console.WriteLine("Inside 1-10");
            }
            else
            {
                Console.WriteLine("Outside 1-10");
            }
        }
    }
}