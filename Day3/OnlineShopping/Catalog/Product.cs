namespace Catalog;
public class Product
{
     public int Id{get;set;}
    public string Title{get;set;}
    public string Description{get;set;}
    public double UnitPrice{get;set;}
    public int Quantity{get;set;}

    public override string ToString()
    {
        return base.ToString()+" Details---> " + Title + "  "+ Quantity;
    }
}
