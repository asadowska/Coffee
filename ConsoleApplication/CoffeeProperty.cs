namespace ConsoleApplication
{
	public class CoffeeProperty
	{
		public string Name { get;private set; }
		public bool Property { get; set; }

		public CoffeeProperty(string name)
		{
			Name = name;
		}
	}
}