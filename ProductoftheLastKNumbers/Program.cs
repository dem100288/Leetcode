ProductOfNumbers obj = new ProductOfNumbers();
obj.Add(3);
Console.WriteLine(obj.GetProduct(1)); // 3
obj.Add(2);
Console.WriteLine(obj.GetProduct(1)); // 2
obj.Add(5);
Console.WriteLine(obj.GetProduct(1)); // 5
obj.Add(4);
Console.WriteLine(obj.GetProduct(2)); // 20
Console.WriteLine(obj.GetProduct(3)); // 40
Console.WriteLine(obj.GetProduct(4)); // 120
obj.Add(8);
Console.WriteLine(obj.GetProduct(1)); // 8
Console.WriteLine(obj.GetProduct(2)); // 32
Console.WriteLine(obj.GetProduct(3)); // 160
Console.WriteLine(obj.GetProduct(4)); // 320
Console.WriteLine(obj.GetProduct(5)); // 960
obj.Add(0);
Console.WriteLine(obj.GetProduct(1)); // 0
Console.WriteLine(obj.GetProduct(2)); // 0
Console.WriteLine(obj.GetProduct(3)); // 0
Console.WriteLine(obj.GetProduct(4)); // 0
Console.WriteLine(obj.GetProduct(5)); // 0


Console.ReadKey();

public class ProductOfNumbers
{
    private List<int> prods = new List<int>();
    public ProductOfNumbers()
    {

    }

    public void Add(int num)
    {
        if (num == 0)
        {
            prods.Clear();
            return;
        }
        else if (prods.Count == 0)
        {
            prods.Add(1);
        }
        prods.Add(prods.Last() * num);
    }

    public int GetProduct(int k)
    {
        if (k + 1 > prods.Count) return 0;
        return prods.Last() / prods[prods.Count - k - 1];
    }
}