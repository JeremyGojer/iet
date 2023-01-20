namespace Utility;
public class Helper{

    public static void Swap(ref int num1, ref int num2){
        int temp=num1;
        num1=num2;
        num2=temp;
    }

    public void Calculate(int radius,out double area, out double circumference){
        area= (3.14) * radius*radius;
        circumference= (2)*(3.14) * radius;
    }

    /*public void Display(string name){
        Console.WriteLine(name);
    }

    public void Display(string name1, string name2){
        Console.WriteLine(name1 + " , "+ name2);
    }*/

    public void Display(params object [] instances){
        foreach ( object instance in instances){
            Console.WriteLine(instance);
        }
    }
    

}