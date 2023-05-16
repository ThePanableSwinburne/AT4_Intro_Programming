using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }

    public Person(string name, int age, int height)
    {
        Name = name;
        Age = age;
        Height = height;
    }

    public Person(string fileName)
    {
        Deserialize(fileName);
    }

    private void Deserialize(string fileName)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open);
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            var person = (Person)formatter.Deserialize(fs);
            Name = person.Name;
            Age = person.Age;
            Height = person.Height;
        }
        catch (SerializationException e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            fs.Close();
        }
    }

    public void Serialize(string fileName)
    {
        FileStream fs = new FileStream(fileName, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        try
        {
            formatter.Serialize(fs, this);
        }
        catch (SerializationException e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            fs.Close();
        }
    }

    public static bool operator ==(Person a, Person b)
    {
        bool Name, Age, Height;
        Name = a.Name == b.Name;
        Age = a.Age == b.Age;
        Height = a.Height == b.Height;
        return Name && Age && Height;
    }
    
    public static bool operator !=(Person a, Person b)
    {
        return !(a == b);
    }
}