// // Online C# Editor for free
// // Write, Edit and Run your C# code using C# Online Compiler

 using System;
//  using PATA=ProjectA.TeamA;
//  using PATB=ProjectA.TeamB;

 public class CSharp_Fundamenatals
 {
     public static void Main(string[] args)
    {
         // Console.WriteLine ("please enter your name");
         // string MyName= Console.ReadLine();
         // Console.WriteLine("Hello " + MyName);
         // Console.WriteLine("Min value for int " + int.MinValue + "\nMax value for int " + int.MaxValue);
//         // Console.WriteLine("Min value for int " + double.MinValue + "\nMax value for int " + double.MaxValue);
//         // Console.WriteLine("Min value for int " + long.MinValue + "\nMax value for int " + long.MaxValue);
        
//         //escape sequence
        
//         // Console.WriteLine("My Name Is \"Omkar\"");
//         // Console.WriteLine("\"Honda\" And \"BMW\" are Car Companies" );
//         // //If-Else
//         // Console.WriteLine("Enter Your Age");
        
//         // int age=Convert.ToInt32(Console.ReadLine());

//     //         1. Null Handling
//     // 	int.Parse(null)

//     // 	❌ Throws an exception (ArgumentNullException)

//     // 	Convert.ToInt32(null)

//     // 	✅ Returns 0
//     // 	(No exception)
	

// 	//     Type Flexibility
// // int.Parse()
// // ✔ Only works with string.
// // Convert.ToInt32()
// // ✔ Works with many types, like:
// // string
// // bool
// // double
// // object
// // decimal


//         // //If-Else
//         // Console.WriteLine("Enter Your Age");
        
//         // int age=Convert.ToInt32(Console.ReadLine());
//         //  if(age<18 && age>0){
//         //      Console.WriteLine("Your Not Eligiable");
//         //  }
//         //  else if(age>18 && age<100){
//         //      Console.WriteLine("Your Eligiable");
//         //  }
//         //  else{
//         //      Console.WriteLine("Enter the valid Age");
//         //  }
        
//         //Switch case
//         int TotalCost=0;
//         Start:
//         Console.WriteLine("Please select the coffee size: 1.Small, 2.Medium, 3.Large");
//         int choice=Convert.ToInt32(Console.ReadLine());
//         switch(choice){
//             case 1:
//                 Console.WriteLine("your Coffee Cost is 25 ");
//                 TotalCost+=25;
//                 break;
//             case 2:
//                 Console.WriteLine("your Coffee Cost is 50 ");
//                 TotalCost+=50;
//                 break;
//             case 3:
//                 Console.WriteLine("your Coffee Cost is 75 ");
//                 TotalCost+=75;
//                 break;
//             default:
//                 Console.WriteLine("Please Enter the valid Number");
//                 goto Start;
//         }
//         Decide:
//         Console.WriteLine("Do You Want To Buy Anothe Coffee \"Yes\" \"No\"");
//         string UserDecision=Console.ReadLine();
//         switch(UserDecision.ToUpper()){
//             case "YES":
//                 goto Start;
//              //No need of break because program pointer will go to the start;
//              case "NO":
//                 Console.WriteLine("Thank you for the shopping");
//                 Console.WriteLine($"Your Total Cost for coffee is {TotalCost} Rs.");
//                 break;
//             default:
//             goto Decide;
                
//         }
    //  Console.WriteLine("Enter the Number in which You want to Print the even Numbers");
    //      int Target=Convert.ToInt32(Console.ReadLine());
    //     int Start=0;
    //     while(Start<=Target){
    //         Console.Write(Start + " ");
    //         Start+=2;
    //     }
    // Console.WriteLine("Enter the Number in which You want to Print the even Numbers");
    //      int Target=Convert.ToInt32(Console.ReadLine());
    //     int Start=0;
    //     do{
    //         Console.Write(Start + " ");
    //         Start+=2;
    //     }while(Start<=Target);
    
    
        // int[] Nums=new int[3];
        // Nums[0]=1001;
        // Nums[1]=1002;
        // Nums[2]=1003;
        // for(int i=0;i<Nums.Length;i++){
        //     Console.WriteLine(Nums[i]);
        // }
        
        
        // foreach(int Num in Nums){
        //     Console.WriteLine(Num);
        // }
        
        
        
        //method with refereance variable
     //     int Year=2024;
    //     ChangeVariableValue(ref Year);
    //     Console.WriteLine("The year is : "+Year);
    
    //method with out
        // int Sum=0;
        // int Product=0;
        // Calculate(25,63,out Sum,out Product);
        // Console.WriteLine("Sum={0} , Product={1}",Sum,Product);
        
        
        
        //params Method
        // int[] Numbers=new int[3];
        // Numbers[0]=1003;
        // Numbers[1]=1004;
        // Numbers[2]=1005;
        // ParamMethod(Numbers);
        
        
        
        //namespace
        
        // PATA.A.Print();
        // PATB.A.Print();
        
        //class
        
        // Console.WriteLine("Enter your First name");
        // string FirstName=Console.ReadLine();
        
        // Console.WriteLine("Enter your Last name");
        // string LastName=Console.ReadLine();
        
        // Customer Customer1=new Customer();
        
        // Customer1.FullName();
        
        // Customer Customer2=new Customer(FirstName,LastName);
        // Customer2.FullName();
        
        
        //Inheritance
        
        // FullTimeEmployee FTE=new FullTimeEmployee();
        // FTE.FirstName = "Virat";
        // FTE.LastName = "KOhali";
        // FTE.YearlySalary = 600000;
        // FTE.PrintFullName();
        
        // Child C1= new Child();
        
        
        
        //Method Hiding
        
        // FullTimeEmployee FTE=new FullTimeEmployee();
        
        // FTE.FirstName = "FullTime";
        // FTE.LastName = "Employee";
        // FTE.YearlySalary = 600000;
        // //((Employee)FTE).PrintFullName();
        // FTE.PrintFullName();
        
        // PartTimeEmployee PTE=new PartTimeEmployee();
        
        // PTE.FirstName = "PartTime";
        // PTE.LastName = "Employee";
        // PTE.HourRate = 600;
        // PTE.PrintFullName();
        
        
        //PolyMorphism(Method Overrideing)
        
        // Employee[] Emp = new Employee[4];
        // Emp[0] = new Employee();
        // Emp[1] = new PartTimeEmployee();
        // Emp[2] = new FullTimeEmployee();
        // Emp[3] = new TemporaryEmployee();
        
        // foreach(Employee E in Emp)
        // {
        //     E.PrintFullName();
        // }
        
        
        //Method OVERLOADING
        
        // Add(20,10);
        // Add(10,20,30);
        
        //Properties
        
        // Student S1=new Student();
        // S1.SetId(101);
        // Console.WriteLine("Student Id is : " + S1.GetId());
        
        // S1.SetName(null);
        
        // Student S1 = new Student();
        
        // S1.Id=101;
        // Console.WriteLine("the student Id is : "+S1.Id);
        
        // Console.WriteLine("the Pass marks are : " + S1.PassMarks);
        
        //Interfaces
        
        // Customer C1=new Customer();
        // C1.Print1();
        // C1.Print2();
        
        //Explicit Interfaces
        
        // C C1 = new C();
        // ((I1)C1).InterfaceMethod();
        // ((I2)C1).InterfaceMethod();
        
        
        //Abstract class
        
        // Shop s= new Shop();
        // s.Print();
        
    }
    
    
 
    //   public static void ChangeVariableValue(ref int n){
    //       n=2025;
    //   }
    // public static void Calculate(int FirstNumber,int SecondNumber,out int Sum,out int Product){
    //     Sum=FirstNumber+SecondNumber;
    //     Product=FirstNumber*SecondNumber;
    // }
    
    //Params Method
    // public static void ParamMethod(params int[] Numbers){
    //     Console.WriteLine("Size of Array is : "+Numbers.Length);
    //     foreach(int Num in Numbers){
    //         Console.Write(Num+" ");
    //     }
        
    // }
    
    
    //Method Overloading
    
    // public static void Add(int FN, int SN)
    // {
    //     Console.WriteLine("Sum = "+ (FN+SN));
    // }
    
    //  public static void Add(int FN, int SN, int TN)
    // {
    //     Console.WriteLine("Sum = "+ (FN+SN+TN));
    // }
    
    
}
 
 //namespace
 
//  namespace ProjectA{
//         namespace TeamA{
//             class A{
//                 public static void Print(){
//                     Console.WriteLine("This Team A Class A Print Method");
//                 }
//             }
//         }
//         namespace TeamB{
//             class A{
//                 public static void Print(){
//                     Console.WriteLine("This Team B Class A Print Method");
//                 }
//             }
//         }
// }

//class

// class Customer{
//     string _firstname;
//     string _lastname;
    
    
//     public Customer()
//         :this("No FirstName Provided","No FirstName Provided")
//     {
        
//     }
    
//     public Customer(string FirstName,string LastName){
//         this._firstname=FirstName;
//         this._lastname=LastName;
//     }
    
//     public void FullName(){
//         Console.WriteLine("FullName Of The Customer is :"+this._firstname+" "+this._lastname);
//     }
// }




//Inheritance

// public class Employee{
//     public string FirstName;
//     public string LastName;
//     public string Email;
    
//     public void PrintFullName()
//     {
//         Console.WriteLine("Employee Full Name is: " + this.FirstName + this.LastName);
//     }
// }

// public class FullTimeEmployee : Employee
// {
//     public float YearlySalary;
// }

// public class PartTimeEmployee : Employee{
//     public float HourRate;
// }




// public class Parent
// {
//     public Parent()
//     {
//         Console.WriteLine("This Is Parent Class ConstrUctor");
//     }
    
//     public Parent(string Message)
//     {
//         Console.WriteLine(Message);
//     }
// }

// public class Child : Parent
// {
//     public Child() : base("This Message form Child Class")
//     {
//         Console.WriteLine("This Is Child Class ConstrUctor");
//     }
// }


//Method Hiding

// public class Employee{
//     public string FirstName;
//     public string LastName;
//     public string Email;
    
//     public void PrintFullName()
//     {
//         Console.WriteLine("Employee Full Name is: " + this.FirstName + " " + this.LastName);
//     }
// }

// public class FullTimeEmployee : Employee
// {
//     public float YearlySalary;
    
//     public new void PrintFullName()
//     {
//         //base.PrintFullName();
//         Console.WriteLine("Full Time Employee Full Name is: " + this.FirstName + " " + this.LastName);
//     }
// }

// public class PartTimeEmployee : Employee{
//     public float HourRate;
// }

//Polymorphism(Method Overriding)

// public class Employee
// {
//     public string FirstName = "FN";
//     public string LastName = "LN";
    
//     public virtual void PrintFullName()
//     {
//         Console.WriteLine("Full Name Of the Employee is : " + FirstName + " " + LastName);
//     }
// }

// public class PartTimeEmployee : Employee
// {
//     public override void PrintFullName()
//     {
//         Console.WriteLine("Full Name Of the Employee is : " + FirstName + " " + LastName + " Part Time Employee");
//     }
// }

// public class FullTimeEmployee : Employee
// {
//     public override void PrintFullName()
//     {
//         Console.WriteLine("Full Name Of the Employee is : " + FirstName + " " + LastName + " Full Time Employee");
//     }
// }

// public class TemporaryEmployee : Employee
// {
//     public override void PrintFullName()
//     {
//         Console.WriteLine("Full Name Of the Employee is : " + FirstName + " " + LastName + " Temporary Employee");
//     }
// }

//Properties

// public class Student
// {
//     private int _Id;
//     private string _Name;
//     private int _PassMarks = 35;
    
//     public void SetId(int Id)
//     {
//         if(Id<=0)
//         {
//             throw new Exception("Stident Id cannot be Negative");
            
//         }
//         else
//         {
//             this._Id = Id;
//         }
//     }
    
//     public int GetId()
//     {
//         return this._Id;
//     }
    
//     public void SetName(int Name)
//     {
//         if(string.IsNullOrEmpty(Name))
//         {
//             throw new Exception("Stident Name cannot be Null or empty");
            
//         }
//         else
//         {
//             this._Name = Name;
//         }
//     }
    
//     public int GetName()
//     {
//         if(string.IsNullOrEmpty(this._Name))
//         {
//             return "No Name";
//         }
//         else
//         {
//             return this._Name;
//         }
//     }
// }


// public class Student
// {
//     private int _Id;
//     private string _Name;
//     private int _PassMarks=35;
    
//     public int Id
//     {
//         set
//         {
//             if(value <= 0)
//             {
//                 throw new Exception("Student id should not be negative");
//             }
//             this._Id = value;
//         }
//         get
//         {
//             return this._Id;
//         }
//     }
    
//     public int PassMarks
//     {
//         get
//         {
//             return this._PassMarks;
//         }
//     }
// }


//Interfaces

// interface ICustomer
// {
//     void Print1();
// }

// interface JCustomer
// {
//     void Print2();
// }

// public class Customer : ICustomer,JCustomer
// {
//     public void Print1()
//     {
//         Console.WriteLine("INTERFACE PRINT 1 METHOD");
//     }
    
//     public void Print2()
//     {
//         Console.WriteLine("INTERFACE PRINT 2 METHOD");
//     }
// }


//Explicit interfaces

// interface I1
// {
//     void InterfaceMethod();
// }

// interface I2
// {
//     void InterfaceMethod();
    
// }

// public class C : I1,I2
// {
//     void I1.InterfaceMethod()
//     {
//         Console.WriteLine("I1 Interface method");
//     }
    
//     void I2.InterfaceMethod()
//     {
//         Console.WriteLine("I2 Interface Method");
//     }
// }

// public abstract class Customer
// {
//     //public abstract  void Print();
    
//     public void Print()
//     {
//         Console.WriteLine("This is Print Method");
//     }
// }

// public class Shop : Customer
// {
//     // public override void Print()
//     // {
//     //     Console.WriteLine("This is Print of Abstract Class");
//     // }
// }
