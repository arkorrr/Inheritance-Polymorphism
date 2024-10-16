public class Program
{
    static void Main()
    {
        {
            //Task1 
            var tiger = new Tiger("Tiger");
            var crocodile = new Crocodile("Crocodile");
            var kangaroo = new Kangaroo("Kangaroo");

            tiger.PrintInfo();
            crocodile.PrintInfo();
            kangaroo.PrintInfo();

            //Task2
            Worker president = new President("Alice");
            Worker security = new Security("Bob");
            Worker manager = new Manager("Charlie");
            Worker engineer = new Engineer("Dave");

            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();

            //Task3
            Vehicle plane = new Plane("Boeing 747");
            Vehicle car = new Car("Toyota Corolla");

            plane.Display();
            car.Display();

            //Task4
            Equation linearEq = new LinearEquation(1, -5);
            Equation quadraticEq = new QuadraticEquation(1, -3, 2);

            linearEq.Solve();
            quadraticEq.Solve();

            //Task5
            Vehicle2[] vehicles = new Vehicle2[2];
            vehicles[0] = new Car2();
            vehicles[1] = new Truck();

            foreach (var vehicle in vehicles)
            {
                vehicle.Input();
                vehicle.Output();
            }

            //Task6
            var triangle = new Triangle(3, 4, 5);
            var circle = new Circle(10);
            var compositeFigure = new CompositeFigure();

            compositeFigure.AddFigure(triangle);
            compositeFigure.AddFigure(circle);

            Console.WriteLine($"Total Area of Composite Figure: {compositeFigure.TotalArea()}");
        }
    }

}