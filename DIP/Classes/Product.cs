namespace DIP;

public class Product:IProduct
{
    public string getProduct()
    {
        return "Product";
    }

    public int getId()
    {
        return 1;
    }
}