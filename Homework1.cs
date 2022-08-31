namespace Homework1;
class Program
{
    static void Main(string[] args)
    { 
    Console.WriteLine("Homework1:");
    string LinearEquation; 
    LinearEquation = "Solve Z = 4X^2 + 3Y";
    Console.WriteLine(LinearEquation);
    double x = 2.5, y=3.3;
    double z = 4*x*x + 3*y;
    Console.WriteLine($"Substitute X = {x} & y = {y} to solve.");
    Console.WriteLine($"The value of Z is = {z}");
    
    }
}
