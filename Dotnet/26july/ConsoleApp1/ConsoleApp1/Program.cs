using System;
using System.Transactions;

public class RBI
{
    int  acNo;
    String iFSCCode;
    String userName;
    String password;
   /* public RBI() EXAMPLE OF CONSTRUCTOR CHAINIING WE CAN'T PERFORM OVERRIDING OF CONSTRUCTOR IN CONSTRUCTOR
    {

    }
    public RBI(int acNo, String iFSCCode ,String uSerName,String password):this()
    {
       
        this.acNo = acNo;
        this.iFSCCode = iFSCCode;
        this.userName = userName;
        this.password = password;
    }
   */
   public  void data()
    {
     
        Console.WriteLine("enter the account No");
        acNo=Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("enter the iFacCode");
        iFSCCode = Console.ReadLine();
        Console.WriteLine("enter the Name");
        userName = Console.ReadLine();
        Console.WriteLine("enter the Password");
        password = Console.ReadLine();
    }
    public void deposite()
    {
        Console.WriteLine("Deposite for Rbi");
    }
    public void withdraw()
    {
        Console.WriteLine("withdraw for RBI");
    }

}
public class SBI : RBI
{
    static String bankName = "State Bank of India";
    void bank()
    {
        Console.WriteLine(bankName);
    }
    
 public void deposite ()
    {
        Console.WriteLine("Deposite for SBI");
    }
    public void Withdraw()
    {
        Console.WriteLine("Deposite for SbI");
    }
}
public class PNB : RBI
{
    static String bankName = "PNB";
    void bank()
    {
        Console.WriteLine(bankName);
    }

    public void deposite()
    {
        Console.WriteLine("Deposite for PNB");
    }
    public void Withdraw()
    {
        Console.WriteLine("Deposite for PNB");
    }
}public class Controller
{
    static void Main()
    {
        Console.WriteLine("press 1 for SBI \n press 2 for PNB ");
        int ch=Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                SBI S = new SBI();

                S.data();
                S.deposite();
                S.withdraw();
                break;
            case 2:
                PNB p = new PNB();

                p.data();
                p.deposite();
                p.withdraw();
                break;
            default:
                Console.WriteLine("you enter the invalid code :");
                break;
        }

      
    }
    }
        
    

    


