using Utility;
using Banking;
/*
//early binding, compile time linking
// function is resolve at compile time
// direct call
Handler.BlockAccount();

//function will be resolve at run time
//late binding
//indirect call
//runtime linking

SimpleOperation opn1=new SimpleOperation(Handler.SendEmail);
//Indirect call
//opn1.Invoke();


SimpleOperation opn2=new SimpleOperation(Handler.BlockAccount);
SimpleOperation opn3=new SimpleOperation(Handler.PayIncomeTax);
SimpleOperation opn4=new SimpleOperation(Handler.PayServiceTax);

//opn2.Invoke();

//cascading effect

SimpleOperation masterOpn=opn1;
masterOpn+=opn2;
masterOpn+=opn3;
masterOpn+=opn4;

masterOpn.Invoke();


masterOpn-=opn4;
masterOpn.Invoke();/*

/*ArithmaticOperation math1=new ArithmaticOperation(Handler.Addition);
int result=math1.Invoke(45,56);
Console.WriteLine(result);

*/


Account acct=new Account();
//Event should be registered with event handlers

acct.underBalance+=new SimpleOperation(Handler.BlockAccount);
acct.underBalance+=new SimpleOperation(Handler.SendEmail);
acct.underBalance+=new SimpleOperation(Handler.SendSMS);

acct.overBalance+=new SimpleOperation(Handler.PayIncomeTax);
acct.overBalance+=new SimpleOperation(Handler.SendEmail);
acct.overBalance+=new SimpleOperation(Handler.SendSMS);


acct.Balance=67000;
//acct.Withdraw(65000);
acct.Deposit(300000);
Console.WriteLine( "remaining Balance="+ acct.Balance);




