using System;

public class Enums
{
    public static void Main()
    {
        int[] Values = (int[])Enum.GetValues(typeof(Gender));
        
        foreach(int value in Values)
        {
            Console.WriteLine(value);
        }
        // Customer[] customer = new Customer[3];
        
        // customer[0] = new Customer
        // {
        //     Name = " Mark",
        //     Gender = Gender.Male
        // };
        
        // customer[1] = new Customer
        // {
        //     Name = " Mary",
        //     Gender = Gender.Female
        // };
        
        // customer[2] = new Customer
        // {
        //     Name = " Sam",
        //     Gender = Gender.Unknown
        // };
        
        // foreach(Customer cust in customer)
        // {
        //     Console.WriteLine("Name = {0} && Gender = {1}", cust.Name, GetGender(cust.Gender));
        // }
        
        
    }
    
//     public static string GetGender(Gender gender)
//     {
//         switch(gender)
//         {
//             case Gender.Unknown:
//                 return "Unknown";
//                 break;
//             case Gender.Male:
//                 return "Male";
//                 break;
//             case Gender.Female:
//                 return "Female";
//                 break;
//             default :
//                 return "Invalid";
//                 break;
//         }
//     }
 }

// public class Customer
// {
//     public string Name { get; set; }
//     public Gender Gender { get; set; }
    
// }


//Instead of Doing this We can use the Enums

public enum Gender 
{
    Unknown,
    Male=9,
    Female
}

