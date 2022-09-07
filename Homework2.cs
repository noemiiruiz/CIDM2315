namespace Homework2;
class Program
{
    static void Main(string[] args)
      {
       
        // Homework2---Q1---
        Console.WriteLine("Please input a letter grade:");
        char grade = Convert.ToChar(Console.ReadLine());
        // switch statement
        switch(grade){
        case 'A':
            Console.WriteLine("GPA point: 4");
            break;
        case 'B':
            Console.WriteLine("GPA point: 3");
            break;
        case 'C':
            Console.WriteLine("GPA point: 2");
            break;
        case 'D':
            Console. WriteLine("GPA point: 1");
            break;
        case 'F':
            Console.WriteLine("GPA point: 0"); 
            break; 
        // if input any other letter
        default:
            Console.WriteLine("Wrong Letter Grade!");
            break;
        }
        //Homework2---Q2---
        Console.WriteLine("Please input the first num:");
        int a = 12;
        a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num:");
        int b = 11;
        b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num:");
        int c = 14;
        c = Convert.ToInt16(Console.ReadLine());
        int smallest = 0;
        if (a<b){
            if(a<c){
                smallest = a;
            }
        }       
        if (b<a){
            if(b<c){
                smallest = b;
            }
        }
        if (c<a){
            if (c<b){
                smallest = c;
            }
        }
        Console.WriteLine($"The smallest value is: {smallest}");


    }  
}

