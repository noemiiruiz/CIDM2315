namespace Week9;
class Program
{   
public static void Main(string[] args)
    {
        int[] int_array = {11, 23, 31, 42, 53};
        ArraySum(int_array);
    {
        int[,] array_2d = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        Console.WriteLine("Q1: Print all odd numbers:");
        PrintAllOddNumber(array_2d);
        Console.WriteLine("Q2: The sum of array elements: " + ElementSum(array_2d));
        Console.WriteLine("Q3: The new 2d array:");
        int[,] result = DoubleArray(array_2d);
        
        for (int a = 0; a < array_2d.GetLength(0); a++)
        {
            for (int b = 0; b < array_2d.GetLength(1); b++)
            {
                Console.Write(result[a, b] + " ");
            }
        }
        Console.WriteLine();
    }    
    }
public static void ArraySum(int[] int_array)
    {
        int sum = 0;
        for (int a = 0; a < int_array.Length; a++)
        {
            sum += int_array[a];
        }

        Console.WriteLine("The sum of int_array is: " + sum);
    }  

public static void PrintAllOddNumber(int[,] array_2d)
    {
        for (int a = 0; a < array_2d.GetLength(0); a++)
        {
            for (int b = 0; b < array_2d.GetLength(1); b++)
            {
                if (array_2d[a, b] % 2 != 0)
                {
                    Console.Write(array_2d[a, b] + " ");
                }
            }
        }
        Console.WriteLine();
    }

public static int ElementSum(int[,] array_2d)
    {
        int sum = 0;
        for (int a = 0; a < array_2d.GetLength(0); a++)
        {
            for (int b = 0; b < array_2d.GetLength(1); b++)
            {
                sum += array_2d[a, b];
            }
        }
        return sum;
    }

public static int[,] DoubleArray(int[,] array_2d)
    {
        int[,] result = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
        for (int a = 0; a < array_2d.GetLength(0); a++)
        {
            for (int b = 0; b < array_2d.GetLength(1); b++)
            {
                result[a, b] = array_2d[a, b] * 2;
            }
        }
        return result;
} 
}



