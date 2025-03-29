using System;

class Customer
{
    private string _fullName;
    private Address _homeAddress;

    public Customer(string name, Address address)
    {
        _fullName = name;
        _homeAddress = address;
    }

    // Checks if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _homeAddress.IsDomestic();
    }

    // Generates a shipping label with customer details
    public string PrintShippingDetails()
    {
        return $"Ship To:\n{_fullName}\n{_homeAddress.GetFullAddress()}";
    }
}