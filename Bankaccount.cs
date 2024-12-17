using System;
using System.IO;
using System.Dynamic;
using System.Transactions;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Intrinsics.X86;
namespace Banking;

public class Bankaccount
{
    public int current_amt;
    private string name= "", city ="";
    private int num=0;
    public string Name
    {
        get => name;
        set => name= value;
    }
    public string City
    {
        get => city;
        set => city= value;
    }
    public int Number
    {
        get => num;
        set => num= value;
    }
        public void GetInfo()
        {
        System.Console.WriteLine("Enter customer name");
        Name= Console.ReadLine();
        System.Console.WriteLine("Enter customer City");
        City= System.Console.ReadLine();
        System.Console.WriteLine("Enter customer Account Number");
        int v = int.Parse(System.Console.ReadLine());
        Number= v;

        System.Console.WriteLine("Enter current amount");
        current_amt = int.Parse(Console.ReadLine());
        }
        public void Deposit(int dep)
        {
           int D= dep;
            current_amt += D;
            System.Console.WriteLine("Balance after deposit:");
            System.Console.WriteLine(current_amt);
        }

        public void Withdrawal(int wth)
        {
            int W= wth;   
            current_amt -= W;
            System.Console.WriteLine("Balance after withdrawal:");
            System.Console.WriteLine(current_amt);
        }

        
        public void Basicfunction()
        {
            GetInfo();
            System.Console.WriteLine("Enter your choice 1. Deposit, 2. Withdrawal");
            int c = int.Parse(Console.ReadLine());

            switch (c)
            {   
                case 1:
                 System.Console.WriteLine("Enter amount to deposit");
                int d= int.Parse(System.Console.ReadLine());
                Deposit(d);
                break;

                case 2:
                System.Console.WriteLine("Enter amount to withdraw");
                int w= int.Parse(System.Console.ReadLine());
                Withdrawal(w);
                break;

                default: System.Console.WriteLine("Enter valid option");
                break;
            }
        }
}

      interface FundTransfer
      {
        public void Fundtransfer(int x, int y);
      } 

      interface Loans
      {
        public void LoanEligibility(int a, int b);
      } 
      interface FD
      {
        public void FixedDeposit(int i, double d);
      }
