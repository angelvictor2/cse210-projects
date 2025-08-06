
public class Product
{
    private string _productName = "";
    private string _productId = "";
    private double _price = 0;
    private int _quantity = 0;

    public Product(string ProductName, string ProductId, double Price, int Quantity)
    {
        _productName = ProductName;
        _productId = ProductId;
        _price = Price;
        _quantity = Quantity;
    }

    public double GetFullPrice()
    {
        double fullprice = _price * _quantity;
        return fullprice;
    }

    public string GetLabel()
    {
        return $"-{_productName}, {_productId}, Units: {_quantity}" ;
    }

}