namespace Day10;
class Program
{
    static void Main(string[] args)
    {
        Products products = new Products("product 1", 33.2);
        Products products2 = new Products("product 2", 3.4);
        Products products3 = new Products("product 3", 99.0);

        Products[] product = { products, products2, products3 };
        foreach (Products item in product)
        {
           item.printProduct();
        }
    }
}

