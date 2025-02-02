using System;

public class Product
{
    private string _productName;
    private string _productID;
    private int _quantity;
    private double _price;

    public Product(string productname, string productid, int quantity, double price)
    {
        _productName = productname;
        _productID = productid;
        _quantity = quantity;
        _price = price;
    }

    public double ProductTotalCost()
    {
        return _quantity * _price;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public void DisplayProduct()
    {
        Console.WriteLine("Product Name: " + _productName);
        Console.WriteLine("Product ID: " + _productID);
        Console.WriteLine("Quantity: " + _quantity);
        Console.WriteLine("Price: " + _price);
        Console.WriteLine($"Total Cost: {ProductTotalCost}");
    }

}
