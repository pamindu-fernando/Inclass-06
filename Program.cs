using System;
using System.Collections.Generic;

// Factory that stores prototypes and hands out clones
class RobotFactory
{
    private readonly Dictionary<string, Robot> _prototypes = new();

    public void Register(string key, Robot prototype) => _prototypes[key] = prototype;

    public Robot Create(string key)
    {
        if (!_prototypes.TryGetValue(key, out var prototype))
            throw new ArgumentException($"Unknown robot type: {key}");
        return prototype.Clone();
    }
}

class Program
{
    static void Main()
    {
        var factory = new RobotFactory();
        factory.Register("service", new ServiceRobot("CareBot X1", 10, "1.0", "Patient assistance"));
        factory.Register("industrial", new IndustrialRobot("WeldMaster 500", 16, "2.1", "Welding"));
        factory.Register("entertainment", new EntertainmentRobot("FunBot Pro", 8, "1.5", "Interactive dancing"));

        // Clone and customize instead of building from scratch
        var service1 = factory.Create("service");
        var service2 = (ServiceRobot)factory.Create("service");
        service2.BatteryCapacity = 14;
        service2.SoftwareVersion = "1.1";
        service2.ServiceTask = "Hotel concierge";

        var industrial = (IndustrialRobot)factory.Create("industrial");
        industrial.SoftwareVersion = "2.2";
        industrial.IndustrialTask = "Assembly";

        var entertainment = factory.Create("entertainment");
        entertainment.BatteryCapacity = 12;

        Console.WriteLine(service1);
        Console.WriteLine(service2);
        Console.WriteLine(industrial);
        Console.WriteLine(entertainment);
        Console.WriteLine($"service1 == service2 ? {ReferenceEquals(service1, service2)}");
    }
}
