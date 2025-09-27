public class Address
{
    private string _streetName;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address (string streetName, string city, string stateOrProvince, String country)
    {
        _streetName = streetName;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country.Trim().ToLower() == "usa";
    }
    
    public string GetFormattedAddress()
    {
        return $"ADDRESS:{_streetName} - {_city}, {_stateOrProvince} {_country}.";
    }
}