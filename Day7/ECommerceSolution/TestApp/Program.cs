using System.Collections.Generic;
using BOL;
using DAL;

string path=@"d:\test\products.json";
ProductIOManager mgr=new ProductIOManager();
List<Product> restoredAllProducts=mgr.Load(path);
restoredAllProducts.Add(new Product{ProductId=999, Title="Sunflower", Description="Energy Flower", UnitPrice=50, StockAvailable=1000,Category="Oil Flower", ImageUrl="/images/sunflower.jpg"});
mgr.Save(path,restoredAllProducts);


/*foreach( Product p in restoredAllProducts){
    Console.WriteLine(p.ProductId +  " "+ p.Title + " "+ p.UnitPrice);
}*/




