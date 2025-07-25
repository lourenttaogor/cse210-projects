using System;

public class Address
{
    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }
    public string ZipCode { get; }

    public Address(string street, string city, string state, string country, string zipCode)
    {

        Street = street;
        City = city;
        State = state;
        Country = country;
        ZipCode = zipCode;
    }

    public bool IsUSA()
    {
        return Country == "USA";
    }

    public string GetFullAddress()
    {
        return $"Street: {Street}\n City: {City}\n State: {State}\n Country: {Country}\n Zipcode: {ZipCode}";
    }
}