namespace ConsoleApp1;

public class Tracker
{
    public static int counter;
    public int id;

    public Tracker()
    {
        id = inc();
    }

    public int inc()
    {
        return ++counter;
    }
}