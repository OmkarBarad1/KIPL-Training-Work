using System;


// using Assembaly;
using Assembaly1;
using Assembaly2;

//private

// public class Customer
// {
//     private int _id;
    
//     public int ID
//     {
//         get
//         {
//             return _id;
//         }
//         set
//         {
//             _id = value;
//         }
//     }
// }

//Protected

// public class Customer
// {
//     protected int ID;
    
// }

// public class CorporateCustomer :Customer
// {
//     public void PrintID()
//     {
//         CorporateCustomer cc = new CorporateCustomer();
        
//         cc.ID = 101;
        
//         Console.WriteLine(cc.ID);
//     }
// }


//Internal
// namespace Assembaly
// {
//     public class AssembalyClass1
//     {
//         internal int ID = 101;
        
//     }
    
//     public class AssembalyClass2
//     {
//         AssembalyClass1 A1 = new AssembalyClass1();
//         public void SampleMethod()
//         {
//             Console.WriteLine(A1.ID);
//         }
//     }
// }


//Protected internal

namespace Assembaly1
{
   public class Assembaly1Class1
   {
       protected internal int ID=101;
   }
}

namespace Assembaly2
{
    public class Assembaly2Class1 : Assembaly1Class1
    {
       public void Print()
       {
           Assembaly1Class1 A = new Assembaly1Class1();
           
           Console.WriteLine(A.ID);
       }
    }
}
public  class AccessModifiers
{
    private static void Main()
    {
        //private
        
        // Customer C1 = new Customer();
        // Console.WriteLine(C1.ID);
        
        //protected
        
        // CorporateCustomer c1 = new CorporateCustomer();
        
        // c1.PrintID();
        
        //Internal
        
        // AssembalyClass2 A =  new AssembalyClass2();
        
        // A.SampleMethod();
        
        //protected internal
        
        Assembaly2Class1 A1 = new Assembaly2Class1();
        
        A1.Print();
        
    }
}