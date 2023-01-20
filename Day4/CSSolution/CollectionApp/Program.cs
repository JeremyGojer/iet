using System.Collections.Generic;
using Catalog;
using HR;
using Graphics;
using BCCI;





List<string> names=new List<string> ();
names.Add("Transflower");
names.Add("IET");
names.Add("IACSD");
names.Add("KNOWIT");


List<Product> products=new List<Product>();
products.Add( new Product{ Id=1, Title="Gerbera", Description="Wedding Flower"});
products.Add( new Product{ Id=2, Title="Rose", Description="Valentine Flower"});
products.Add( new Product{ Id=3, Title="Jasmine", Description="Fregrance Flower"});
products.Add( new Product{ Id=4, Title="Marigold", Description="Festival Flower"});
products.Add( new Product{ Id=5, Title="Tulip", Description="Kashmir Flower"});

Console.WriteLine( "Stack implementation");

Stack<string> complaints=new Stack<string>();
complaints.Push("water problem");
complaints.Push("Microphone not working");
complaints.Push("Understanding problem");

Console.WriteLine(" Resolving complaints");
string complaint=complaints.Pop();
Console.WriteLine(complaint);

Queue<Product> produductsTobeServiced=new Queue<Product>();
produductsTobeServiced.Enqueue(new Product{ Id=6, Title="Gear", Description="Car Vehicle"});
produductsTobeServiced.Enqueue(new Product{ Id=10, Title="shaft", Description="Car Vehicle"});
produductsTobeServiced.Enqueue(new Product{ Id=12, Title="piston", Description="Car Vehicle"});
produductsTobeServiced.Enqueue(new Product{ Id=617, Title="windhill", Description="Car Vehicle"});



Product theProduct =produductsTobeServiced.Dequeue();


LinkedList<int> numbers=new LinkedList<int>();

Dictionary<string, Employee> staff=new Dictionary<string, Employee>();
staff.Add("ceo", new Employee{ FirstName="Shubham", LastName="Shinde"});
staff.Add("cto", new Employee{ FirstName="Akshay", LastName="Bhise"});
staff.Add("cfo", new Employee{ FirstName="Kali", LastName="Charan"});
staff.Add("director", new Employee{ FirstName="Ram", LastName="Charan"});
staff.Add("president", new Employee{ FirstName="Manish", LastName="Malhotra"});
staff.Add("mentor", new Employee{ FirstName="Ravi", LastName="Tambade"});

Employee theEmployee=staff["director"];
Console.WriteLine(theEmployee);


//Single dimensional array

int [] marks= {45, 56, 23, 76, 78};
int  score=marks[2];
marks[3]=99;

string  []  students={ "Sham", "Ram", "Geeta", "Seeta"};
foreach( string name in students){
    Console.WriteLine(name);
}

//Multi dimensional Array
//Rectangular Array\
//Balanced Array

int [,] matrix=new int[3,3]{
                    {56, 112,87},
                    {45, 76,45},
                    {76,55, 98}
};


string [,] classroom=new string[2,2]{
    {"Manish", "Rajesh"},
    {"Sham", "Mahesh"}
};

 

int [] pgDMCStudentsScore={45,23, 54};
int [] pgDacStudentsScore={45,23, 54, 34, 45};
int [] pgDBDAStudnetsScore={44,65,33,65,45,65,34,65,45};


//Array of Array
//Jagged Array
//Unbalance Array
int [] []dacStudentsScore =new int[3][];
dacStudentsScore[0]=pgDacStudentsScore;
dacStudentsScore[1]=pgDBDAStudnetsScore;
dacStudentsScore[2]=pgDMCStudentsScore;

for( int i=0; i<dacStudentsScore.Length;i++){
    for(int j=0;j<dacStudentsScore[i].Length;j++){
        Console.WriteLine(dacStudentsScore[i][j]);
    }
}




Console.WriteLine( "Indexer Demonstration.....");

Team india=new Team();
string player=india[0];
Console.WriteLine(player);
india[0]="Virat Kohli";
string newplayer=india[0];
Console.WriteLine(newplayer);


Console.WriteLine( "Football Players list");

List<Player> soccerTeam=new List<Player>();
soccerTeam.Add(new Player{ Name="Pele", Score=1000, Age=80});
soccerTeam.Add(new Player{ Name="Mbappe", Score=400, Age=23});
soccerTeam.Add(new Player{ Name="Ronaldo", Score=700, Age=37});
soccerTeam.Add(new Player{ Name="Messi", Score=900, Age=35});

Console.WriteLine( "Football Players list before Sort");
foreach( Player thePlayer in soccerTeam){
    Console.WriteLine(thePlayer.Name + " "+ thePlayer.Score + " "+ thePlayer.Age);

}

//soccerTeam.Sort();
IComparer<Player> customComparer=new CustomComparer();
soccerTeam.Sort(customComparer);
Console.WriteLine( "Football Players list after Sort");
foreach( Player thePlayer in soccerTeam){
    Console.WriteLine(thePlayer.Name + " "+ thePlayer.Score + " "+ thePlayer.Age);

}
