namespace  OnlineShopping;
public class Person {

    //private variables
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

    public Person(){
        this.firstName="Ravi";
        this.lastName="Tambade";
        this.BirthDate=new DateTime(1975, 8,18);
    }

    public Person(string fName, string lName, DateTime bDate){
        this.firstName=fName;
        this.lastName=lName;
        this.BirthDate=bDate;
    }

    ~Person(){
        //Clean up code 
    }

    public override string ToString()
    {
        return base.ToString() +" :  "+ this.firstName + " "+ this.lastName + " "+ this.BirthDate;
    }

}


 //struct is value type
        //value types: primitive types are value types
        //int, float, char, boolean, double, flaot,etc.
        //struct, enumeration
        //value type varialbes value are always pushed on stack

