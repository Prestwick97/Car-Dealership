using System;
using Dealership.Models;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    // Console.BackgroundColor = ConsoleColor.DarkGreen;

    Console.WriteLine("White on blue");
    Console.WriteLine("Another line."); 
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "These used to be military jeeps for the german wehrmacht");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "these cars were only sold in America becuase they were so unsafe");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "these cars were the peak of the swaggin' wagon");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "this car was GM's attempt to combat the japanese imports of the 70's");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    yugo.SetPrice(300);

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    int maxMiles = int.Parse(stringMaxMiles); 

    List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
    {
      if (automobile.MeetCriteria(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    if (CarsMatchingSearch.Count > 0)
    {
        foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("-------s--------------");
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine(automobile.Miles + " miles");
        Console.WriteLine("$" + automobile.Price);
        // Console.WriteLine(automobile._info);
      }
    }
    else 
    {
      Console.WriteLine("your search did not return and cars");
    }
  }
}