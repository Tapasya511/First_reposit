using System.Security.Cryptography.X509Certificates;
using Banking;

class Program
{
        public static void Main(String[] args)      
        {
            Bankaccount b1= new Bankaccount();
            ICICI I1 = new ICICI();
            SBI S1 = new SBI();
            PNB P1 = new PNB();
        
            Console.WriteLine("Choose your bank: 1. ICICI 2. SBI 3. PNB");
            int choice= int.Parse(Console.ReadLine());

              switch(choice)
                {
                case 1:
                b1.Basicfunction();
                Console.WriteLine("ICICI has fund transfer too, do you want to proceed: Yes or No");
                string opt= Console.ReadLine();
                if(opt.Equals("Yes") || opt.Equals("yes"))
                {
                    System.Console.WriteLine("Enter amount to transfer");
                    int a= int.Parse(System.Console.ReadLine());
                    I1.Fundtransfer(a, b1.current_amt);
                }
                break;

                case 2: 
                b1.Basicfunction();
                Console.WriteLine("SBI is offering aloan, do you want to check your eligibility, please state yes or No");
                string op= Console.ReadLine();
                if(op.Equals("Yes"))
                {
                    System.Console.WriteLine("Enter monthly salary");
                    int m= int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("Enter requested loan amount");
                    int L= int.Parse(System.Console.ReadLine());
                    S1.LoanEligibility(m, L);
                }
                break;

                case 3:
                b1.Basicfunction();
                Console.WriteLine("PNB is offering FD, do you want to check your FD maturity values, state Yes or No");
                string o= Console.ReadLine();
                if(o.Equals("Yes"))
                { 
                    System.Console.WriteLine("Enter amount you want to enquire for FD");
                    double fd_amount= double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("Enter duration of FD");
                    int t= int.Parse(System.Console.ReadLine());
                    P1.FixedDeposit(t, fd_amount);
                }
                break;
             
                default: System.Console.WriteLine("Enter valid option");
                break;
                }
            
        }
}
   


            


