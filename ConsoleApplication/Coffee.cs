using System.Collections.Generic;

namespace ConsoleApplication
{
	public class Coffee
	{
		public string Name { get; set; }
		public IList<CoffeeProperty> CoffeeProperties;

		public Coffee()
		{
			CoffeeProperties = new List<CoffeeProperty>();
		}
	}
}