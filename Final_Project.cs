namespace FPP;
using System;
using System.Collections;
class Order 
{
    static void Main() 
    {

        string username,password;
        int choice;
        
        string[] entree = {"BLT Sandwich","Chicken Strips","Shrimp Alfredo","Beef Burger"};
        float[] entreePrice = {5.99f,8.99f,9.99f,6.99f};
        string[] drink = {"Iced Tea", "Soda","Lemonade","Coffee"};
        float[] drinkPrice = {2.99f,1.99f,2.99f,3.99f};
        string[] side = {"Potato Fries","Salad","Fruit Cup","Potato Chips"};
        float[] sidePrice = {3.99f,4.99f,9.99f,2.99f};
        
        int index, menu;
        float total;
        
        string[] orderItem = new string[3];
        float[] orderPrice = new float[3];
        ArrayList customer = new ArrayList();
        ArrayList price = new ArrayList();

        Console.WriteLine(" \n -CIDM2315 Final Project: Noemi Ruiz-");
        Console.WriteLine("-------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" *-*-*-Welcome to Buff Kitchen-*-*-*");
        Console.ResetColor();
        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Please input username:");
        username = Console.ReadLine();
        Console.WriteLine("Please input password:");
        password = Console.ReadLine();
        
        if(username == "Alice" && password == "321" ){

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------");
            Console.WriteLine("Login Successfully!");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\n** Hello Cashier: Alice **");
            Console.ResetColor();
        
        do{

            index = 0;
            total = 0;
        
            Console.WriteLine("**************************");
            Console.WriteLine("Please select");
            Console.WriteLine("1. Start new order");
            Console.WriteLine("2. Check submitted orders");
            Console.WriteLine("3. Remove finished orders");
            Console.WriteLine("4. Log out system");
            Console.WriteLine("***************************");
            choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
        case 1:

            Console.WriteLine("-->Customer Name:");
            customer.Add(Console.ReadLine());
            
            Console.WriteLine("-->Select Entree:");
            for( int i = 0; i < 4; i++){
                Console.WriteLine("{0} - Food: {1}\tPrice: {2}",i,entree[i],entreePrice[i]);
                }
                menu = Convert.ToInt32(Console.ReadLine());
                orderItem [index] = entree[menu];
                orderPrice[index] = entreePrice[menu];
                total = total + entreePrice[menu];
                index++;
            
            Console.WriteLine("-->Select Drink:");
            for( int i = 0; i < 4; i++){
                Console.WriteLine("{0} - Food: {1}\tPrice: {2}",i,drink[i],drinkPrice[i]);
                }
                menu = Convert.ToInt32(Console.ReadLine());
                orderItem [index ] = drink[menu];
                orderPrice[index] = drinkPrice[menu];
                total = total + drinkPrice[menu];
                index++;
            
            Console.WriteLine("-->Select Side:");
            for( int i = 0; i < 4; i++){
                Console.WriteLine("{0} - Food: {1}\tPrice: {2}",i,side[i],sidePrice[i]);
                }
                menu = Convert.ToInt32(Console.ReadLine());
                orderItem[index] = side[menu];
                orderPrice[index] = sidePrice[menu];
                total = total + sidePrice[menu];

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("--------Order Summary--------");
                Console.ResetColor();
                for( int i = 0; i < 3; i++)
                Console.WriteLine("Food: {0}\tPrice: {1}",orderItem[i],orderPrice[i]);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--------Total: {0}--------",total);
                Console.ResetColor();
                price.Add(total);
                break;
        
        case 2: 
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------Number of Orders: {0}--------",customer.Count);
            for( int i = 0; i < customer.Count; i++)
            Console.WriteLine("-->{0} - Customer: {1}\t Total: {2}",i,customer[i],price[i]);
            Console.WriteLine("----------------------------------");
            Console.ResetColor();
            break;
        
        case 3: 

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------Number of Orders: {0}--------",customer.Count);
            for( int i = 0; i < customer.Count; i++)
            Console.WriteLine("-->{0} - Customer: {1}\t Total: {2}",i,customer[i],price[i]);
            Console.WriteLine("----------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Input order ID to remove a finished order:");
            Console.ResetColor();

            menu = Convert.ToInt32(Console.ReadLine());
            customer.RemoveAt(menu);
            price.RemoveAt(menu);
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------Number of Orders: {0}--------",customer.Count);
            for( int i = 0; i < customer.Count; i++)
            Console.WriteLine("-->{0} - Customer: {1}\t Total: {2}",i,customer[i],price[i]);
            Console.WriteLine("----------------------------------");
            Console.ResetColor();
            break;
        
        case 4:

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("  See you next time!");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-");
            Console.ResetColor();
            break;
        }} 

        while(choice != 4);
        }

        else 
        Console.WriteLine("Invalid username/password. Try again.");     
    }
}
