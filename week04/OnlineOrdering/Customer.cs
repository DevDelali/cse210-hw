using System.Collections.Concurrent;

public class Customer
{
    private string _name;
    private string _address;
    private bool _isInUSA;

    public Customer(string name, string address, bool isInUSA)
    {
        _name = name;
        _address = address;
        _isInUSA = isInUSA;
    }

    public bool IsInUSA()
    {
        return _isInUSA;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_name}\nAddress: {_address}";
    }
}