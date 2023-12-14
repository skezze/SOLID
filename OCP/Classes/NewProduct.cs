namespace OCP.Classes;

public class NewProduct:Product,IProduct
{
    public string getProduct()
    {
        return base.getProduct()+"extension";
    }

    public int getId()
    {
        return base.getId()+1;
    }
}