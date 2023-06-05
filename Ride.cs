// See https://aka.ms/new-console-template for more information

class Ride
{
    public string Name {get;set;}
    int Capacity;
    string Color;
    bool Engine;
    int Milage = 0;

    public Ride(string name, string color)
    {
        Name = name;
        Color = color;
        Engine = true;
        Capacity = 5;
    }

    public Ride(string name, int capacity, string color, bool engine)
    {
        Name = name;
        Capacity = capacity;
        Color = color;
        Engine = engine;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Capacity: {Capacity}, Color: {Color}, Engine: {Engine}, Milage: {Milage}");
    }

    public void Travel(int miles)
    {
        Milage +=  miles;
        Console.WriteLine($"Your {Name} has traveled {miles}");
    }
}

