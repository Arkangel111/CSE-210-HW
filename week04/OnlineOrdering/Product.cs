using System;

public class Product
{
    private string _productName;
    private string _productId;
    private int _quantity;
    private double _price;

    public Product(string productname, string productid, int quantity, double price)
    {
        _productName = productname;
        _productId = productid;
        _quantity = quantity;
        _price = price;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productId;
    }

}
