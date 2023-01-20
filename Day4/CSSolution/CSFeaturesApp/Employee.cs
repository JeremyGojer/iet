namespace HR;
public class Employee{
    public   string country="India";
    public readonly string religion;
    public string FirstName{get;set;}
    public string LastName{get;set;}

    public Employee(){
        this.religion="Hindu";
    }

    public override string ToString()
    {
        return base.ToString() + " " + this.FirstName + " " + this.LastName;
    }
}