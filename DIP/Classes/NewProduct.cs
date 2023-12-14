namespace DIP;

public class NewProduct:IProduct
{
    public string getProduct()
    {
        return "newProduct";
    }

    public int getId()
    {
        return 2;
    }
}