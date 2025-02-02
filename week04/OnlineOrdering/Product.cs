using System;

public class Product
{
    private string _productName;
    private string _productID;
    private int _quantity;
    private int _price;

    public Product(string productname, string productid, int quantity, int price)
    {
        _productName = productname;
        _productID = productid;
        _quantity = quantity;
        _price = price;
    }

    public int TotalCost(int _quantity, int _price)
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
        Console.WriteLine($"Total Cost: {TotalCost(_quantity, _price)}");
    }

}
