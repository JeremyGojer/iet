namespace BCCI;
using System.Collections;


public class Player:IComparable{
    public string Name{get;set;}
    public int Score{get;set;}
    public int Age{get;set;}

    int IComparable.CompareTo(object obj)
    {
        Player temp= (Player) obj;
        if (this.Age > temp.Age)
        return 1;
        if (this.Age < temp.Age)
        return -1;
        else 
        return 0;
    }

}