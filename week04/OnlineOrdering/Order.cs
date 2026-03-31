using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _localShipping = 5;
    private double _internationalShipping = 35;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    public string GetPackingLabel()
    {   
        string products ="";
        foreach (Product p in _products)
        {
            products+= $"{p.GetProductID()} - {p.GetProductName()}\n";
        }
        return $"{_customer.GetName()} \n{products}";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetOrderTotal()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total+= p.ComputeTotalPrice();
        }
        
        if (_customer.IsInUS()) {
        
            total += _localShipping;
        }

        else
        {
            total += _internationalShipping;
        }
        return total;
    }

}