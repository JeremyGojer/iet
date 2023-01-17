namespace Maths;

public class Complex{
    public int Real{get;set;}
    public int Imag{get;set;}
    public Complex(){
        this.Real=this.Imag=0;
    }
    public Complex(int r, int i){
        this.Real=r;
        this.Imag=i;
    }

    //Operator overloading
    public static Complex operator+ (Complex c1, Complex c2){
        Complex temp=new Complex();
        temp.Real=c1.Real+ c2.Real;
        temp.Imag=c1.Imag + c2.Imag;
        return temp;
    }
    public static Complex operator- (Complex c1, Complex c2){
        Complex temp=new Complex();
        temp.Real=c1.Real- c2.Real;
        temp.Imag=c1.Imag - c2.Imag;
        return temp;
    }

    public override string ToString()
    {
        return this.Real+"+" +this.Imag+"i";
    }

}