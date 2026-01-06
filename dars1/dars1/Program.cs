namespace dars1;

internal class Program
{
    static void Main(string[] args)
    {
        Product product = new Product
        {
            name = "Apple Juce",
            price = 100,
            productId = Guid.NewGuid(),
            period = DateTime.Now,
            endperiod = DateTime.Now.AddMonths(1)
        };
        Product product2 = new Product
        {
            name = "Milk",
            price = 100,
            productId = Guid.NewGuid(),
            period = DateTime.Now,
            endperiod = DateTime.Now.AddMonths(2)
        };
        Console.WriteLine();
        Console.WriteLine(product);
        Console.WriteLine();
        Console.WriteLine(product2);
    }
}
