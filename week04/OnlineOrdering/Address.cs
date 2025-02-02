using System;

public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;


    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;

    }
    public void Display()
    {
        Console.WriteLine($"Address: {_address} \nCity: {_city} \nState: {_state} \nCountry: {_country}");
    }

}