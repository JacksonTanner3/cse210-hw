using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddressString()
    {
        return $"{_street}\n{_city}, {_stateProvince}, {_country}";
    }
}
