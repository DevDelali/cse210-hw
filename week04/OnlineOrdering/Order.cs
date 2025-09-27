public class Order
{
    private List<Product> _product;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _product = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public decimal GetOrderCost()
    {
        decimal productTotal = 0;
        foreach (Product product in _product)
        {
            productTotal += product.GetCost();
        }
        decimal shipping = _customer.IsInUSA() ? 2 : 10;
        return productTotal + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";
        foreach (Product product in _product)
        {
            label += $"{product.GetPackingLabel()}\n";
        }
        return label.TrimEnd();
    }
    
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}";
    }
}