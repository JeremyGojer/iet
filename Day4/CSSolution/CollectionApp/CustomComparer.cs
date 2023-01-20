namespace BCCI;
public class  CustomComparer:IComparer<Player>{
public int Compare(Player e1, Player e2)
 { 
    int ret = e1.Age.CompareTo(e2.Age); 
    return ret;
 }

}