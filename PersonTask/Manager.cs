namespace PersonTask;

public class Manager : Person
{
    public Manager(string name, string surname):base(name,surname)
    {
        
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Manager Name: {Name}, Surname: {Surname}");
    }
}
