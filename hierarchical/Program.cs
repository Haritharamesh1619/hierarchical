using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical
{
    using System;

// create a Interface
 interface IDevice // interface
    {
        // method for interface
        string GetDeviceDetails(); // Returns the details of the device.
    }

// Base Class
public abstract class Device : IDevice //inherite the interface using  abstract class
    {
    public string Brand { get; set; }//Attributes
        public string Model { get; set; } //Attributes

        public string GetBasicDetails() // Returns the basic details of the device.
        {
        return $"Brand: {Brand}, Model: {Model}";// String Interpolation
        }

    public abstract string GetDeviceDetails(); // abstract method
}

// Derived Class 1: Phone
public class Phone : Device
{
    public string OperatingSystem { get; set; }

    public override string GetDeviceDetails() //override method to include basic details from Device
        {
        return $"{GetBasicDetails()}, Operating System: {OperatingSystem}";
            //Property specific to" Phone " for storing the operating system.
        }
}

// Derived Class 2: Laptop
public class Laptop : Device
{
    public string Processor { get; set; }

    public override string GetDeviceDetails()
    {
        return $"{GetBasicDetails()}, Processor: {Processor}";
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Phone phone = new Phone // instances  class of phone
        {
            //sets the properties of the  phone.
            Brand = "Apple",
            Model = "iPhone 13",
            OperatingSystem = "iOS"
        };

        Laptop laptop = new Laptop // instances  class  of  Laptop
        {
            //sets the properties of the Laptop
            Brand = "Dell",
            Model = "XPS 13",
            Processor = "Intel i7"
        };

        Console.WriteLine("Phone Details:");
        Console.WriteLine(phone.GetDeviceDetails());// call method :GetDeviceDetails()

            Console.WriteLine("\nLaptop Details:");
        Console.WriteLine(laptop.GetDeviceDetails());

        Console.ReadLine();
    }
}

}
