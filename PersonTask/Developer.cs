namespace PersonTask;

public class Developer:Person
{

    public Developer(string name, string surname) : base(name, surname)
    {

    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Manager Name: {Name}, Surname: {Surname}");
    }
}
