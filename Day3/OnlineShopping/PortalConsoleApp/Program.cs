using Catalog;
using BI;
using CRM;
using OrderProcessing;

Product p1=new Product();
p1.Title="Rose";
p1.Description="Valentine Flower";
p1.UnitPrice=45;
p1.Quantity=6000;
p1.Id=4543;

Console.WriteLine(p1);


Dashboard board=new Dashboard();
IDetails iD=board;
iD.Show();

//Create customer object
Customer c1=new Customer();

//Set Customer object properties 

c1.SetFirstName("Rajan");
c1.LastName="Gore";
c1.BirthDate=new DateTime(2000,5,3);
c1.ContactNumber="9881735801";
c1.Email="rajan.gore@transflower.in";
c1.Location="Pune";
//Add orders inside customer objects collection

c1.Orders.Add(new Order(){ OrderId=1,
                           OrderDate=new DateTime(2023,1,16),
                           Status="InProgress", 
                           TotalAmount=6000});
c1.Orders.Add(new Order(){ OrderId=2,
                           OrderDate=new DateTime(2023,1,17),
                           Status="Rejected", 
                           TotalAmount=56000});

Console.WriteLine(c1);
c1.ShowAllOrders();

