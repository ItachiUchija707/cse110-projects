public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string product, string id, double price, int quantity)
    {
        _productName = product;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public double ComputeTotalPrice()
    {
       return _price * _quantity;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public string GetProductName()
    {
        return _productName;
    }
}