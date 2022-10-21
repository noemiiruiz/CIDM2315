namespace Week8;
class Customer{
 private int cus_id;
 public string cus_name;
 public int cus_age;
 public Customer(int cus_id, string cus_name, int cus_age) {
 //CONSTRUCTOR 
     this.cus_id = cus_id;
     this.cus_name = cus_name;
     this.cus_age = cus_age;
 }
 public void ChangeID(int new_id) {
     cus_id = new_id;
 }
  // method used to print customer information(id, name, age) 
 public void PrintCusInfo(){
    //  Printing the values of corresponding customer 
     Console.WriteLine($"Customer : {cus_id} ,name : {cus_name} ,age :{cus_age}");
 }
 public void CompareAge(Customer objCustomer){
     if(objCustomer.cus_age > this.cus_age)
     {
      Console.WriteLine(objCustomer.cus_name + " is older ");
     }
     else if(objCustomer.cus_age < this.cus_age)
     {
      Console.WriteLine(this.cus_name + " is older ");
     }
}
}
// Main class to run the program
class Program {
  static void Main() {

    Customer cust1 = new Customer(110, "Alice", 28);
    cust1.PrintCusInfo();
    
    Customer cust2 = new Customer(111, "Bob", 30);
    cust2.PrintCusInfo();
    //New id for customer 1 
    cust1.ChangeID(220);
    //New id for customer 2 
    cust2.ChangeID(221);
    //Printing new id
    cust1.PrintCusInfo();
    cust2.PrintCusInfo();
    
    cust1.CompareAge(cust2);
  
    
  }  
}