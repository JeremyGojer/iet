
using HR;
using Utility;
using System.Reflection;


Employee emp1=new Employee() { FirstName="Raju", LastName="Sharma"};
Console.WriteLine(emp1.country + " "+ emp1.FirstName + " "+ emp1.LastName);

Employee emp2=new Employee() { FirstName="Sarika", LastName="Vartak"};
Console.WriteLine(emp2.country + " "+ emp2.FirstName + " "+ emp2.LastName);

emp1.country="USA";
emp2.country="UK";
Console.WriteLine(emp1.country + " "+ emp1.FirstName + " "+ emp1.LastName + " "+ emp1.religion);
Console.WriteLine(emp2.country + " "+ emp2.FirstName + " "+ emp2.LastName+ " " + emp1.religion);

//emp1.religion="Boudhism";

const double PI=3.14;
Console.WriteLine ( "PI= "+ PI);
//emp1.religion="Hindu";


int value1=765;
int value2=984;

Console.WriteLine("Before Swapping numbers");

Console.WriteLine ( "Value1= "+ value1);
Console.WriteLine ( "Value2= "+ value2);


Helper.Swap(ref value1, ref value2);

Console.WriteLine("After Swapping numbers");

Console.WriteLine ( "Value1= "+ value1);
Console.WriteLine ( "Value2= "+ value2);

int radius=7;
double area=0;
double circumference=0;
Console.WriteLine("Before calculation");
Console.WriteLine ( "radius= "+ radius + " , area="+ area + "  circumference="+ circumference);

Helper h1=new Helper();
h1.Calculate(radius, out area, out circumference);

Console.WriteLine("After calculation");
Console.WriteLine ( "radius= "+ radius + " , area="+ area + "  circumference="+ circumference);


h1.Display("Ravi Tambade");
h1.Display("Rohit Gore", "Rishikesh Chikane");
h1.Display("Rohit Gore", "Rishikesh Chikane", "Akshay Tanpure");
h1.Display("Rohit Gore", "Rishikesh Chikane", "Akshay Tanpure", "Pragati Bangar");
h1.Display("Rohit Gore", "Rishikesh Chikane", "Akshay Tanpure", "Pragati Bangar", "Rajiv Sharma", "Chetana Pandit");
h1.Display("Software Engg", 23, 65.3, true, new Employee{FirstName="Sanjay", LastName="Bhansali"});


int result=567;
object obj=result;   //Boxing

//int result2=(int)obj;    //UnBoxing


Employee emp3=new Employee() { FirstName="Manu", LastName="Narang"};

Object obj2=emp3;

//Employee emp4=(Employee)obj2;
Employee emp4=obj2 as Employee;

Console.WriteLine(emp3);
Console.WriteLine(emp4);

if(emp4 is Employee){
    Console.WriteLine("emp4 is of type Employee");
}
else{
    Console.WriteLine("emp4 is not  of type Employee");
}

//Reflection

Console.WriteLine( "\n \n \nReflection Demo......");

Type t=emp4.GetType();
Console.WriteLine(t.FullName);

Assembly asm=Assembly.GetExecutingAssembly();
Console.WriteLine(asm.FullName);

Type [] allTypes=asm.GetTypes();
foreach( Type theType in allTypes){
    Console.WriteLine(theType.Name);
    MethodInfo [] methods=theType.GetMethods();
    foreach( MethodInfo mi in methods){
        Console.WriteLine(mi.Name + " public="+ mi.IsPublic);
    }

     Console.WriteLine("Members of class "+ theType.Name);
    MemberInfo [] members=theType.GetMembers();
     foreach( MemberInfo member in members){
        Console.WriteLine(member.Name);
    }
    Console.WriteLine("\n");
}

