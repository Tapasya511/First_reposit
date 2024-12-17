using System;
using System.Runtime.Intrinsics.X86;


namespace Banking;

class ICICI : Bankaccount
{
    
    public void Fundtransfer(int amount, int curr)
        {
            int a= amount;
            int c= curr;
           if(a<0 && a>c)
            System.Console.WriteLine("Insufficient funds");
           else
            c = c - a;
            System.Console.WriteLine("Remaining balance:");
            System.Console.WriteLine(c);
        }  
     
}

class SBI : Bankaccount, Loans
{
    public void LoanEligibility(int Monthly, int req_amt)
        {
        
            if(Monthly< req_amt/15)
             System.Console.WriteLine("Not Eligible for loan");

            else
             System.Console.WriteLine("Eligible for loan, Please contact customer executive for further steps");
        }
}

class PNB : Bankaccount, FD 
{
      public void FixedDeposit(int time, double fd_amount)
        {
            int t= time; double A = fd_amount;
            A = A+ ((A * t * 6.5)/100);
            System.Console.WriteLine("Maturity value of the given amount for requested time is:");
            System.Console.WriteLine(A);
        }
}


