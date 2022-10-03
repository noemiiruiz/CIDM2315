namespace Homework5;
class Program
{
    // --Q1------------------------------------------------
    public static void Main(string[] args)
    {
        Console.Write("Enter first integer:");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer:");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second));
        Console.Write("Enter third integer: ");
        int third = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fourth integer: ");
        int fourth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second, third, fourth));

        createAccount();
    }
    // --Q2-----------------------------------------------
    public static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    public static int largest(int n1, int n2, int n3, int n4)
    {
        return largest(largest(n1, n2), largest(n3, n4));
    }
  
 
    //--Q3--------------------------------------------------
    public static bool checkAge(int birth_year)
    {
        if ((2022 - birth_year) >= 18)
            return true;
        else
            return false;
    }
    public static void createAccount()
    {
        Console.Write("Enter the userName: ");
        string userName = Console.ReadLine();
        Console.Write("Enter the password: ");
        string password = Console.ReadLine();
        Console.Write("Enter the password again: ");
        string confirm_password = Console.ReadLine();
        Console.Write("Enter the birth year: ");
        int birth_year = Convert.ToInt32(Console.ReadLine());
        if (checkAge(birth_year))
        {
            if (password==confirm_password)
                Console.WriteLine("Account is created Successfully.");
            else
                    Console.WriteLine("Wrong Password.");
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
    }
}
