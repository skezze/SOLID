namespace LSP;

public abstract class Vehicle
{
    public abstract void Drive();
}

public class Car : Vehicle
{
    public override void Drive() => Console.WriteLine("Drive a car");
}

public class Truck : Vehicle
{
    public override void Drive() => Console.WriteLine("Drive a truck");
}

public class Program
{
    //send child object as argument to base interface or abstract class
    public static void TestDrive(Vehicle vehicle)
    {
        vehicle.Drive();
    }
    public static void Main(string[] args)
    {
        var car = new Car();
        TestDrive(car);

        var truck = new Truck();
        TestDrive(truck);
    }
}