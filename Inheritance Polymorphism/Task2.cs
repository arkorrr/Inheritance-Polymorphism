using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Worker
{
    public string Name { get; set; }

    public Worker(string name)
    {
        Name = name;
    }

    public abstract void Print();
}

public class President : Worker
{
    public President(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"President: {Name}");
    }
}

public class Security : Worker
{
    public Security(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Security: {Name}");
    }
}

public class Manager : Worker
{
    public Manager(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Manager: {Name}");
    }
}

public class Engineer : Worker
{
    public Engineer(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Engineer: {Name}");
    }
}
