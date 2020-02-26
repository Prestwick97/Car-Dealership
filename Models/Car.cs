using System;
using System.Collections.Generic;

namespace Dealership.Models {

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _info;

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public Car(string makeModel, int price, int miles, string info)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _info = info;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
    public bool MeetCriteria(int maxPrice, int maxMiles)
    {
      return (_price < maxPrice && _miles < maxMiles);
    }
  }
}

