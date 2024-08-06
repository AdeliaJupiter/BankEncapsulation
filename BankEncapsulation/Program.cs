namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a new public class named BankAccount
            //In the main method of your application, create a new instance of the BankAccount class. 
            //Allow the user of the application to Deposit money and retrieve their balance through the console.
            var account = new BankAccount();
            int choice = 0;

            do
            { 
                Console.WriteLine("What would you like to do?\n[1] Check Balance\n[2] Deposit\n[3] Exit");
                choice = Convert.ToInt32(Console.ReadLine());
          
                    switch (choice)
                    {
                        case 1:
                            account.GetBalance();
                            break;
                        case 2:
                            Console.WriteLine("Enter deposit amount:");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            account.Deposit(amount);
                            break;
                        default:
                            break;
                    }
            } while (choice != 3);
        }
    }
}
