using System;

class Address
{
    private string _street;
    private string _city;
    private string _region;
    private string _country;

    public Address(string street, string city, string region, string country)
    {
        _street = street;
        _city = city;
        _region = region;
        _country = country;
    }

    // Checks if the address is in the USA (case insensitive)
    public bool IsDomestic()
    {
        return _country.ToLower() == "usa";
    }

    // Returns the full address as a formatted string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_region}\n{_country}";
    }
}