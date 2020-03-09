using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
  class Program
  {
    static void Main(string[] args)
    {
      // Find the words in the collection that start with the letter 'L'
      List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

      IEnumerable<string> LFruits = fruits.Where(fruit =>
      {
        return fruit.StartsWith("L");
      });

      Console.Write("Fruits starting with L: ");
      foreach (var fruit in LFruits)
      {
        Console.Write($"{fruit}, ");
      }

      Console.WriteLine(" ");

      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

      IEnumerable<int> fourSixMultiples = numbers.Where(num =>
      {
        return (num % 4 == 0 || num % 6 == 0);
      });
      Console.Write("Multiples of 4 or 6: ");
      foreach (var num in fourSixMultiples)
      {
        Console.Write($"{num}, ");
      }
      Console.WriteLine(" ");

      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

      List<string> descend = names.OrderByDescending(name => name).ToList();
      Console.Write("Names Z to A: ");
      foreach (var name in descend)
      {
        Console.Write($"{name}, ");
      }
      Console.WriteLine(" ");

      // Build a collection of these numbers sorted in ascending order
      List<int> numberCollection = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };


      var ascending = numberCollection.OrderBy(num => num).ToList();
      Console.Write("Ascending Order: ");
      foreach (var num in ascending)
      {
        Console.Write($"{num}, ");
      }
      Console.WriteLine(" ");

      // Output how many numbers are in this list
      List<int> listOfNumbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

      var numberCount = listOfNumbers.Count();
      Console.Write($"The number of the counting is {numberCount}!");
      Console.WriteLine(" ");

      // How much money have we made?
      List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };

      var totalPurchase = purchases.Sum();
      Console.Write($"How much money we've made: ${totalPurchase}");
      Console.WriteLine(" ");

      // What is our most expensive product?
      List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };

      var mostExpensive = prices.Max();
      Console.Write($"Most Expensive Product: {mostExpensive}");
      Console.WriteLine(" ");


      List<int> wheresSquaredo = new List<int>()
        {
            66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };
      var squareRootNum = wheresSquaredo.TakeWhile(num =>
      {
        return num % Math.Sqrt(num) != 0;
      });

      Console.Write("List of numbers: ");
      foreach (var num in squareRootNum)
      {
        Console.Write($"{num}, ");
      };
      Console.WriteLine(" ");
    }

  }
}