// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<Product> products = new List<Product>()
{
	new Product { Id = 1, Name = "IPhone16", Price = 90000 },
	new Product { Id = 2, Name = "IPhone15", Price = 80000 },
	new Product { Id = 3, Name = "IPhone14", Price = 65000 },
	new Product { Id = 4, Name = "IPhone13", Price = 55000 }
};


Sort<Product>(products, Product.Compare);

foreach (Product product in products)
{
	Console.WriteLine(product.Name);
}

Console.ReadLine();

static void Sort<T>(List<T> lists, Func<T, T, bool> compare)
{
	bool change = false;

	do
	{
		change = false;
		for (int i = 0; i < lists.Count -1; i++)
		{
			if (compare(lists[i], lists[i + 1]))
			{
				change = true;
				var temp = lists[i];
				lists[i] = lists[i + 1];
				lists[i + 1] = temp;
			}
		}
	} while (change);
}


public class Product
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Price { get; set; }

	public static bool Compare(Product product1, Product product2)
	{
		return product1.Price > product2.Price;
	}

}