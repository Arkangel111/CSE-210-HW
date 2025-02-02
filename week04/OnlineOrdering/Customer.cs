using System;

public class Customer
{
    private Address _address;
    private string _name;


    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer: {_name}");
        _address.Display();
    }
}