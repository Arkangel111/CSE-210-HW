using System;

public class Product
{
    private string _productname;
    private string _productid;
    private int _quantity;
    private int _price;


    public int TotalCost(int _quantity, int _price)
    {
        int quantity = _quantity;
        int price = _price;
        return quantity * price;

    }
}
