namespace DAL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BOL;

public class CustomerIOManager
{

    public bool Remove(Customer cst){
        bool status=false;
         //1.Load all customers
         //2.Remove  customer from  list
         //3.Save list
         return status;

    }
    public bool Insert(Customer cst){
        bool status=false;
         //1.Load all customers
         //2.Add new customer inside list
         //3.Save list
         return status;

    }

     public bool Update(Customer cst){
        bool status=false;
         //1.Load all customers
         //2.Add new customer inside list
         //3.Save list
         return status;

    }

    public bool  Validate(string email, string password){
        bool status=false;
        //1.Load all customers
        //1.Iterate list
        //3.Check email and password matching with existing customer from list
        //4.if yes  set status to true
        return status;
    }
    public List<Customer> GetAll(){
        string path=@"D:\test\customers.json";
        List<Customer> allCustomers=Load(path);
        return allCustomers;
    }

    public bool Save(string path, List<Product> products)
    {
        bool status=false;
        //Serialize all products collection into file
        
        if(products ==null){
        List<Product> allProducts=new List<Product>();
        allProducts.Add(new Product { ProductId = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", StockAvailable = 7000 });
        allProducts.Add(new Product { ProductId = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", StockAvailable = 3400 });
        allProducts.Add(new Product { ProductId = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", StockAvailable = 27000 });
        allProducts.Add(new Product { ProductId = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", StockAvailable = 1000 });
        allProducts.Add(new Product { ProductId = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Category = "Flower", StockAvailable = 2000 });
        allProducts.Add(new Product { ProductId = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Category = "Flower", StockAvailable = 159 });
        allProducts.Add(new Product { ProductId = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Category = "Flower", StockAvailable = 67 });
        allProducts.Add(new Product { ProductId = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", StockAvailable = 5000 });
        allProducts.Add(new Product { ProductId = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Category = "Flower", StockAvailable = 0 });
        allProducts.Add(new Product { ProductId = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Category = "Flower", StockAvailable = 0 });
        allProducts.Add(new Product { ProductId = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Category = "Flower", StockAvailable = 700 });
        allProducts.Add(new Product { ProductId = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Category = "Flower", StockAvailable = 1500 });
        allProducts.Add(new Product { ProductId = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Category = "Flower", StockAvailable = 2300 });
        allProducts.Add(new Product { ProductId = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", StockAvailable = 10000 });
        products=allProducts;
        }
        try{
            string jsonString=JsonSerializer.Serialize(products);
            File.WriteAllText(path,jsonString);
            status=true;
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        } 
        return status;
    }

    public List<Customer> Load(string path){
        string jsonString=File.ReadAllText(path);
        List<Customer> restoredCustomers=JsonSerializer.Deserialize<List<Customer>>(jsonString);
        return restoredCustomers;
    }
}
