namespace HR;
public sealed class SalesEmployee:Employee{

    public SalesEmployee() :base(){
        this.Incentive=2500;
        this.Target=670000;
    }
    public SalesEmployee(int id, string fname, string lname, DateTime bDate, double da,
                     double hra, double bsal, double pf, double target, double revenue, double incentive)
                     :base(id, fname,lname, bDate, da, hra,bsal,pf){
        this.Incentive=incentive;
        this.Target=target;
        this.Revenue=revenue;
                        
    }
    public double Incentive{get;set;}
    public double Target{get;set;}
    public double Revenue{get;set;}

    public override double CalculateSalary()
    {
        double salary=base.CalculateSalary();
        if(Revenue > Target){
                salary=salary+Incentive;
        }
        return salary;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}