using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Info;

  public Car(string makeModel, int price, int miles, string info)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Info = info;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);
  }
  public bool MeetCriteria(int maxPrice, int maxMiles)
  {
    return (Price < maxPrice && Miles < maxMiles);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "These used to be military jeeps for the german wehrmacht");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "these cars were only sold in America becuase they were so unsafe");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "these cars were the peak of the swaggin' wagon");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "this car was GM's attempt to combat the japanese imports of the 70's");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

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
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine(automobile.Info);
      }
    }
    else 
    {
      Console.WriteLine("your search did not return and cars");
    }
  }
}