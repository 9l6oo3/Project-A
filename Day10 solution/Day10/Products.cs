namespace Day10
{
	public class Products
	{
		public static int id;
		public int productId;
		public string productName;
		public double price;
		public string discription;



		public Products()
		{

		}

		public Products(string name, double price)
		{
			id += 1;
			productId = id;
			this.productName = name;
			this.price = price;

		}

		public void printProduct()
		{
			Console.WriteLine($"product id {productId} name {productName} ,discription, price {price} OMR");
            Console.WriteLine($"");
		}

	}
}

