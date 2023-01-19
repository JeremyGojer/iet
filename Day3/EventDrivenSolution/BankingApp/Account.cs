namespace Banking;
using Utility;
public class Account{


    public double Balance{get;set;}

    public event SimpleOperation underBalance;
    public event SimpleOperation overBalance;

    //unidirectional operations
    public void Deposit(double amount){

        this.Balance+=amount;
        if(this.Balance >=250000){
            //call an event
            overBalance(this);
        }
    }
    public void Withdraw(double amount){
        this.Balance-=amount;
        if(this.Balance <=5000){

            //call event
            underBalance(this);
        }
    }
}