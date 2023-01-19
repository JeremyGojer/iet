namespace CRM;
using System.Collections.Generic;
using OrderProcessing;

public class Customer
{
    private string firstName;
    private string lastName;

    //auto property
    public DateTime BirthDate{get;set;}

    //Member functions
    //setter and getter
    public void SetFirstName(string fname){
        this.firstName=fname;
    }
    public string GetFirstName(){
        return this.firstName;
    }

    //Property
    public string LastName{
        set{ this.lastName=value;}
        get{return this.lastName;}
    }

    public string ContactNumber{get;set;}
    public string Email{get;set;}
    public string Location{get;set;}

    public List<Order> Orders= new List<Order>();

    public void ShowAllOrders(){

        foreach (Order order in Orders){
            Console.WriteLine(order);
        }

    }

    public override string ToString()
    {
        return base.ToString() + "Customer "+ firstName + " "+ lastName + " "+ Email;
    }
}
