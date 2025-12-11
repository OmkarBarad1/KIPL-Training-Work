// // Online C# Editor for free
// // Write, Edit and Run your C# code using C# Online Compiler

 using System;
//  using PATA=ProjectA.TeamA;
//  using PATB=ProjectA.TeamB;

 public class C#_Fundamenatals
 {
     public static void Main(string[] args)
    {
//         // Console.WriteLine ("please enter your name");
//         // string MyName= Console.ReadLine();
//         // Console.WriteLine("Hello " + MyName);
        
        
//         // Console.WriteLine("Min value for int " + int.MinValue + "\nMax value for int " + int.MaxValue);
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