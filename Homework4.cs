namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
//     <-----HW4 Q1----->
        
        int a, b, max_num;
        a= 3;
        b= 5;
        if(a>b){
            max_num = a;
        }
        else {
            max_num = b;
        }
        Console.WriteLine( "a= 3; b= 5");
        Console.WriteLine($"The largest number is: {max_num}");

//   <-----HW4 Q2----->

    Console.Write("N is: 5; shape is left");
    Console.Write("\n");
    int val = 5;  
         int x, y, z ;  
         for (x = 1; x <= val; x++)  
         {  
            for (y = 1; y <= val-x; y++)  
            {  
                
            }  
            for (z = 1; z <= x; z++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
    }
}

    