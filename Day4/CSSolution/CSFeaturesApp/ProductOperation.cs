
namespace Catalog;

public partial class Product{
    public Product(){
        this.Id=12;
        this.Title="Rose";
        this.Description="Valentine Flower";

    }
    public Product(int id, string title, string description){

        this.Id=id;
        this.Title=title;
        this.Description=description;
    }
    public override string ToString()
    {
        return base.ToString() + " " +this.Id + " "+ this.Title + " "+ Description;
    }
}