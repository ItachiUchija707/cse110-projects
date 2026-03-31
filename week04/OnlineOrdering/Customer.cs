public class Customer
{
    private string _name;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUS()
    {
       return _address.IsInUS();
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
}