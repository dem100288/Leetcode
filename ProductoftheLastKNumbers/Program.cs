ProductOfNumbers obj = new ProductOfNumbers();
obj.Add(3);
obj.Add(0);
obj.Add(2);
obj.Add(5);
obj.Add(4);
Console.WriteLine(obj.GetProduct(2)); // 20
Console.WriteLine(obj.GetProduct(3)); // 40
Console.WriteLine(obj.GetProduct(4)); // 0
obj.Add(8);
Console.WriteLine(obj.GetProduct(2)); // 32

public class ProductOfNumbers
{

    public ProductOfNumbers()
    {

    }

    public void Add(int num)
    {

    }

    public int GetProduct(int k)
    {

    }
}