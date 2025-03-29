using System;

class Product
{
    private string _productName;
    private string _code;
    private double _unitPrice;
    private int _stock;

    public Product(string name, string code, double price, int quantity)
    {
        _productName = name;
        _code = code;
        _unitPrice = price;
        _stock = quantity;
    }

    // Calculates the total cost for this product (price * quantity)
    public double CalculateTotal()
    {
        return _unitPrice * _stock;
    }

    // Returns a label with the product name and reference code
    public string GetLabel()
    {
        return $"Product: {_productName} | Ref: {_code}";
    }
}