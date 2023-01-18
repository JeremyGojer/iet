namespace BI;

//Explicit Interface Inheritance
public class Dashboard:ICustomerInfo,IOrderInfo{
    //Fully Qualified Name
    void ICustomerInfo.ShowDetails(){
        Console.WriteLine("Showing Customer Profile");
    }

    void IOrderInfo.ShowDetails(){
        Console.WriteLine("Showing Order History");
    }
    
    public void Show(){
        Console.WriteLine("Showing Content .....");
    }
}