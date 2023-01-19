namespace Utility;
using Banking;

//.net type
//it is wrapper for function pointer

//hook functions

public delegate void  SimpleOperation(Account acct);
public delegate int ArithmaticOperation(int op1, int op2);

public static class Handler {
    public static void PayIncomeTax(Account acct){
        
        acct.Balance=acct.Balance- acct.Balance* (0.15);
        Console.WriteLine("15 %  Income Tax is deducted from account");
        }

    public static void PayServiceTax(Account acct){
        Console.WriteLine("18 %  Service Tax is deducted from account");

    }
    public static void SendEmail(Account acct){

        Console.WriteLine("Account summary has been email to your registered email address");

    }
    public static void SendSMS(Account acct){

        Console.WriteLine("Mini statement  has been sent to your registered mobile number");
    }
    public static void BlockAccount(Account acct){
        
        Console.WriteLine("Your account has been blocked temp....");

    }


    //mathematical Operations
    public static int Addition(int op1, int op2){
        return op1+ op2;
    }
     public static int Subtraction(int op1, int op2){
        return op1- op2;
    }
    public static int Multiplication(int op1, int op2){
        return op1* op2;
    }
    public static int Division(int op1, int op2){
        return op1/ op2;
    }
}