namespace HR;
using OnlineShopping;
public  class Employee:Person{
    public int Id{get;set;}
    public double DA{get;set;}
    public double BasicSalary{get;set;}
    public double HRA{get;set;}
    public double PF{get;set;}

    public Employee():base(){
        this.PF=500;
        this.BasicSalary=5000;
        this.HRA=3000;
        this.DA=500;
    }

    public Employee(int id, string fName, string lName, DateTime bDate, double da,
                     double hra, double bsal, double pf):base(fName,lName,bDate){
        this.Id=id;
        this.PF=pf;
        this.BasicSalary=bsal;
        this.HRA=hra;
        this.DA=da;
    }

    public  double CalculateSalary(){
        double salary=this.BasicSalary + this.DA + this.HRA-this.PF;
        return salary;
    }
    //public  abstract void DoWork();

    public override string ToString()
    {
        return base.ToString() +" Montly salary=" +  this.CalculateSalary();
    }
}