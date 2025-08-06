using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotalCost()
    {
        double productsTotal = 0;
        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.IsInUSA() ? 5.00 : 35.00;

        return productsTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---";
        foreach (Product product in _products)
        {
            label += $"\nName: {product.GetName()}, ID: {product.GetProductId()}";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- Shipping Label ---";
        label += $"\nCustomer: {_customer.GetName()}";
        label += $"\nAddress:\n{_customer.GetAddress().GetFullAddressString()}";
        return label;
    }
}
