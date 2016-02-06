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

			var lines = File.ReadLines("cofee_names.csv");

			foreach (var line in lines)
			{
				var partsOfLine = line.Split(';');
				coffeesDescriptions.Add(partsOfLine[0],partsOfLine[1]);
			}
		}
	}
}
