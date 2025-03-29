using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _items;
    private Customer _buyer;

    public Order(Customer buyer)
    {
        _buyer = buyer;
        _items = new List<Product>();
    }

    // Adds a product to the order
    public void AddItem(Product product)
    {
        _items.Add(product);
    }

    // Calculates the total cost, including shipping fees
    public double ComputeTotal()
    {
        double sum = 0;
        foreach (Product item in _items)
        {
            sum += item.CalculateTotal();
        }

        // Apply shipping cost based on customer's location
        double shippingCost = _buyer.LivesInUSA() ? 5 : 35;
        return sum + shippingCost;
    }

    // Generates a packing slip listing all ordered products
    public string GeneratePackingSlip()
    {
        List<string> details = new List<string>();
        foreach (Product item in _items)
        {
            details.Add(item.GetLabel());
        }
        return "📦 Packing List:\n" + string.Join("\n", details);
    }

    // Generates the shipping label with customer details
    public string GenerateShippingLabel()
    {
        return _buyer.PrintShippingDetails();
    }
}