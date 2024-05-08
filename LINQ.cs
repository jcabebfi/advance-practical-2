public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    static List<Product> products = new List<Product>
    {
        new Product { Name = "Laptop", Price = 999.99 },
        new Product { Name = "Smartphone", Price = 499.99 },
        new Product { Name = "Tablet", Price = 299.99 },
        new Product { Name = "Headphones", Price = 199.99 },
        new Product { Name = "Smartwatch", Price = 249.99 }
    };

    public List<Product> GetProductsPricedOverThreshold(double threshold)
    {
        return products.Where(p => p.Price > threshold).ToList();
    }

    public void SetProductNamesToUpperCase()
    {
        products.ForEach(p => p.Name = p.Name.ToUpper());
    }

    public static void Main()
    {
        
        Product productManager = new Product();
        productManager.GetProductsPricedOverThreshold(300.00);
        productManager.SetProductNamesToUpperCase();

    }

}

