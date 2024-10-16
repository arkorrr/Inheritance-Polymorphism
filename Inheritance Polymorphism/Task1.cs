using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Animal
{
    public string Name { get; set; }
    public string Habitat { get; set; }
    public string Diet { get; set; }

    public Animal(string name, string habitat, string diet)
    {
        Name = name;
        Habitat = habitat;
        Diet = diet;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Habitat: {Habitat}, Diet: {Diet}");
    }
}

public class Tiger : Animal
{
    public Tiger(string name) : base(name, "Jungle", "Carnivore") { }
}

public class Crocodile : Animal
{
    public Crocodile(string name) : base(name, "Swamp", "Carnivore") { }
}

public class Kangaroo : Animal
{
    public Kangaroo(string name) : base(name, "Grasslands", "Herbivore") { }
}
