public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;

    public Product(string name, string productId, decimal price)
    {
        _name = name;
        _productId = productId;
        _price = price;
    }

    public decimal GetCost()
    {
        return _price;
    }

    public string GetPackingLabel()
    {
        return $"Name: {_name}, ID: {_productId}";
    }
}