namespace OrderProcessing;
public class Order
{
    public int OrderId{get;set;}
    public string Status{get;set;}

    public DateTime OrderDate{get;set;}
    public double TotalAmount{ get;set;}

    public override string ToString()
    {
        return base.ToString() + OrderId + "  Status="+Status +  "  Total="+ TotalAmount ;
    }
}
