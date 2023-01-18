using OnlineShopping;
using Catalog;
 
using HR;
using BI;


Console.WriteLine("Hello, World!");
Person prn1=new Person();
Person prn2=new Person("Sameer", "Patil", new DateTime(1998,2,12));

Console.WriteLine(prn1);
Console.WriteLine(prn2);

 
Dashboard  onlineShoppingBoard=new Dashboard();

ICustomerInfo cInfo=onlineShoppingBoard;
cInfo.ShowDetails();


IOrderInfo oInfo=onlineShoppingBoard;
oInfo.ShowDetails();


IDetails iD=onlineShoppingBoard;
iD.Show();


