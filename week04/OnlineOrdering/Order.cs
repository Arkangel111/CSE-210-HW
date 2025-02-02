using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private const decimal US_Rate = 5;
    private const decimal EU_Rate = 35;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = new List<Product>(products);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double orderTotal = 0;

        // Sum up the total cost of all products
        foreach (var product in _products)
        {
            orderTotal += product.ProductTotalCost();
        }

        // Add the flat shipping rate
        double shippingCost = _customer.InUSA() ? (double)US_Rate : (double)EU_Rate;
        orderTotal += shippingCost;

        return orderTotal;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetProductName()}  (ID: {product.GetProductID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping to {_customer.GetName()} at:\n{_customer.GetAddress()}";
    }
}
