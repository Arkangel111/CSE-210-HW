using System;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private const decimal US_Rate = 5;
    private const decimal EU_Rate = 35;


    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal TotalCost()
    {
        decimal prodTotal = 0;

        foreach (var product in _products)
        {
            prodTotal += product.TotalCost();
        }

        if (_customer.InUSA())
        {
            return prodTotal + (prodTotal * US_Rate / 100);
        }

        else
        {
            return prodTotal + (prodTotal * EU_Rate / 100);
        }


        public string GetPackingLabel()
    {
        string label = "Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetProductName()}  (ID: {product.GetProductID()})\n";
        }
    }
}
}