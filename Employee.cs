// Employee.cs
public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Position: {Position}";
    }
}
