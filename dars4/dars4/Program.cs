using dars4.Models;

namespace dars4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Name = "Toyota",
                Speed = 120,
                Weight = 1500,
                Height = 1.5,
                NumOfTyre = 4
            };
            Console.WriteLine(car.Name);
            Console.WriteLine(car.Speed);
            Console.WriteLine(car.Weight);
            Console.WriteLine(car.Height);
            Console.WriteLine(car.NumOfTyre);
        }
    }
}
