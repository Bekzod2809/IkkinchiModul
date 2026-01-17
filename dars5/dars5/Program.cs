using dars5.Models;
using dars5.Services;

namespace dars5;

internal class Program
{
    static void Main(string[] args)
    {
        //ICountryService countryService = new CountryService();
        //Country country = new Country()
        //{
        //    CountryId = Guid.NewGuid(),
        //    Name = "Uzbekistan",
        //    Square = "50000 sq km",
        //    Population = "36 million"
        //};
        //Console.WriteLine(country.CountryId);
        //Console.WriteLine(country.Name);
        //Console.WriteLine(country.Square);
        //Console.WriteLine(country.Population);



        IBoardService boardservice = new BoardService();
        Board board = new Board()
        {
            BoardId = Guid.NewGuid(),
            Color = "Black",
            Price = 100,
            Razmer = "10x15"
        };
        Console.WriteLine();
        Console.WriteLine($"  {board.BoardId}");
        Console.WriteLine($"  {board.Color}");
        Console.WriteLine($"  {board.Razmer}");
        Console.WriteLine($"  {board.Price}");
        Console.WriteLine();

        ISingerService singerservice = new SingerService();
        Singer singer = new Singer()
        {
            SingerId = Guid.NewGuid(),
            FirstName = "Yulduz",
            LastName = "Usmonova",
            SingerAge = 70
        };
        Console.WriteLine();
        Console.WriteLine($"  {singer.SingerId}");
        Console.WriteLine($"  {singer.FirstName}");
        Console.WriteLine($"  {singer.LastName}");
        Console.WriteLine($"  {singer.SingerAge}");
        Console.WriteLine();

        IAirLineService airlineservice = new AirLineService();
        AirLine airline = new AirLine()
        {
            AirLineId = Guid.NewGuid(),
            Name = "Islom Karimov",
            Country = "Uzbekistan",
            FoundedYear = 1991,
            FleetSize = 100

        };
        Console.WriteLine();
        Console.WriteLine($"  {airline.AirLineId}");
        Console.WriteLine($"  {airline.Name}");
        Console.WriteLine($"  {airline.Country}");
        Console.WriteLine($"  {airline.FoundedYear}");
        Console.WriteLine($"  {airline.FleetSize}");
        Console.WriteLine();
    }
}