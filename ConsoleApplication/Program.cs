using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			var coffeesDescriptions = new Dictionary<string, string>();
			var coffeeslist = new List<Coffee>();

			var lines = File.ReadLines("cofee_names.csv");

			foreach (var line in lines)
			{
				var partsOfLine = line.Split(';');
				coffeesDescriptions.Add(partsOfLine[0].Trim(), partsOfLine[1].Trim());
			}

			lines = File.ReadLines("coffeeplan.csv");

			foreach (var line in lines)
			{
				var coffee = new Coffee();
				var properties = new CoffeeProperty[9]
				{
					new CoffeeProperty("milkExist"),
					new CoffeeProperty("milkFrothed"),
					new CoffeeProperty("milkCoco"),
					new CoffeeProperty("milkIntensity"),
					new CoffeeProperty("icecream"),
					new CoffeeProperty("liqueur"),
					new CoffeeProperty("foam"),
					new CoffeeProperty("whippedCream"),
					new CoffeeProperty("ice")
				};

				var partsOfLine = line.Split(';');

				coffee.Name = partsOfLine[0];

				for (int i = 0; i < 9; i++)
				{
					properties[i].Property = Int32.Parse(partsOfLine[i + 1]) == 1;
				}

				foreach (var coffeeProperty in properties)
				{
					coffee.CoffeeProperties.Add(coffeeProperty);
				}

				coffeeslist.Add(coffee);
			}

		}
	}
}
