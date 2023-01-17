using OnlineShopping;
using Catalog;
using Maths;
using HR;


Console.WriteLine("Hello, World!");
Person prn1=new Person();
Person prn2=new Person("Sameer", "Patil", new DateTime(1998,2,12));

Console.WriteLine(prn1);
Console.WriteLine(prn2);

Product flower1=new Product();

flower1.Id=45;
flower1.Title="Gerbera";
flower1.Description="Wedding Flower";
flower1.UnitPrice=12;
flower1.Quantity=4000;

Console.WriteLine(flower1);
Console.WriteLine( flower1.Id + " " +flower1.Title+ " "+flower1.Description);

Complex c1=new Complex(45,32);
Complex c2=new Complex(12,3);
Complex c3=c1+c2;

Console.WriteLine(c3);

Employee emp=new Employee();
Console.WriteLine(emp);

