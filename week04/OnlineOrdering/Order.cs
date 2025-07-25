using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;


    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void GetProducts(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalProductsCost = _products.Sum(product => product.CalculteCost());
        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
        return totalProductsCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }


}