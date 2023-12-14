using DIP;

Product product = new Product();
Console.WriteLine(product.getProduct());
Console.WriteLine(product.getId());

NewProduct newProduct = new NewProduct();
Console.WriteLine(newProduct.getProduct());
Console.WriteLine(newProduct.getId());

//using base interface for get any object and run his methods
IProduct iProduct = new Product();
Console.WriteLine(iProduct.getProduct());
Console.WriteLine(iProduct.getId());
IProduct iNewProduct = new NewProduct();
Console.WriteLine(iNewProduct.getProduct());
Console.WriteLine(iNewProduct.getId());