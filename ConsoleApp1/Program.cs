using ConsoleApp1;

void TrackerTest()
{
    var tracker1 = new Tracker();
    var tracker2 = new Tracker();
    var tracker3 = new Tracker();
    var tracker4 = new Tracker();
    var tracker5 = new Tracker();

    Console.WriteLine(tracker1.id);
    Console.WriteLine(tracker2.id);
    Console.WriteLine(tracker3.id);
    Console.WriteLine(tracker4.id);
    Console.WriteLine(tracker5.id);
}

void SerializeTest()
{
    Person person = new Person("Chelton Evans", 23, 192);
    person.Serialize("CheltonEvans.dat");
    Person loadedChelton = new Person("CheltonEvans.dat");
    Console.WriteLine($"{loadedChelton.Name} {loadedChelton.Age} {loadedChelton.Height}");

    if (person == loadedChelton)
    {
        Console.WriteLine("Chelton is successfully loaded!!");
    }
}

void InputOutput()
{
    string fileName = "hello.txt";
    string textToWrite = "Chelton Evans";

//Writing
    File.WriteAllText(fileName, textToWrite);

//Reading
    var textFromFile = File.ReadAllText(fileName);
    Console.WriteLine(textFromFile);
}

void Q6(int x)
{
    if (x is >= 1 and <= 100)
    {
        Console.WriteLine("X is between 1 and 100 inclusive");
    }
    else
    {
        Console.WriteLine("X is NOT between 1 and 100 inclusive");
    }
}

void Q7()
{
    //fowards
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("___________________");
    //backwards
    for (int i = 10; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}

void Q8()
{
    //DATA TYPES
    int age = 12;
    float speed = 9.81f;
    string name = "Chelton";
    
    //operators and expressions?
    int addition = 3 + 6;
    float division = speed / 1.2f;
    float multiplication = speed * 3.0f;
    
}

void Q9()
{
    //I'm going to use nested functions so I don't have to deviate from this function to answer this question
    //suppose i want to calculate the area of a square for the user
CalculateArea();
    void CalculateArea()
    {
        var length = RequestSquareLength();
        var area = Calculate(length);
        PrintArea(area);
    }

    float RequestSquareLength()
    {
        Console.WriteLine("Please input the length of the square");
        return float.Parse(Console.ReadLine());
    }
    
    float Calculate(float squareLength)
    {
        return squareLength * squareLength;
    }

    void PrintArea(float area)
    {
        Console.WriteLine($"The area of the square is {area}");
        Console.WriteLine("Thank you for using this application");
    }

}

void Q10()
{
    Interval interval = new Interval();
    interval.dataset1();
    interval.IterateAndTest();
}

void Q11()
{
    List<string> products = new List<string>();


    string input = "y";
    do
    {
        Console.WriteLine("Enter product name: \n");
        string product = Console.ReadLine();
        products.Add(product);
        Console.WriteLine("Press y to add another product");
        input = Console.ReadLine();
    } while (input == "y");

    Console.WriteLine("Now listing all products... \n");
    foreach (var product in products)
    {
        Console.WriteLine(product);
    }
}

Q11();

// 2 classes 4 attribtues
public class Man
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public string Address { get; set; }
}

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}


