using System;
using System.IO;


// public class ExceptionHandling
// {
//     public static void Main()
//     {
//         StreamReader SR=null;
//         try 
//         {
//              SR = new StreamReader(@"C:\Desktop\C#\KIPL-Training-Work 1\data.txt");
//             Console.WriteLine(SR.ReadToEnd());
//         }
//         catch(FileNotFoundException Ex)
//         {
//             Console.WriteLine(Ex.FileName);
            
//         }
//         catch(Exception Ex)
//         {
//             Console.WriteLine("the error" +Ex.Message);
//         }
//         finally
//         {
//             if(SR!=null)
//             {
//                 SR.Close();
//             }
            
//             Console.WriteLine("The Code is Over");
//         }
        
//     }
// }


//Inner Exception
// class InnerException
// {
//     public static void Main()
//     {
//         try
//         {
//             try
//         {
            
//             Console.WriteLine("Enter the first Number");
//             int Fn = Convert.ToInt32(Console.ReadLine());
            
//             Console.WriteLine("Enter the Second Number");
//             int Sn = Convert.ToInt32(Console.ReadLine());
            
//             int Result = Fn/Sn;
//             Console.WriteLine("The result is : " + Result);
//         }
//         catch(Exception Ex)
//         {
//             string filePath = @"C:\Desktop\data.txt";
            
//             if(File.Exists(filePath))
//             {
//                 StreamWriter Sr= new StreamWriter(filePath);
//                 Sr.Write(Ex.GetType().Name);
//                 Sr.WriteLine();
//                 Sr.Write(Ex.Message);
//                 Sr.Close();
//                 Console.WriteLine("There is Problem Try Again");
                
//             }
//             else
//             {
//                 throw new FileNotFoundException(filePath+ "is not present",Ex); 
//             }
//         }
//         }
//         catch(Exception Ex)
//         {
//             Console.WriteLine("current Exception : " + Ex.GetType().Name);
//             Console.WriteLine("Inner Exception : " +Ex.InnerException.GetType().Name);
//         }
//     }
// }


//Custom Exception

public class CustomException
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("The user Already Logged in");
        }
        catch(UserAlreadyLoggedInException Ex)
        {
            Console.WriteLine(Ex.Message);
        }
    }
}

public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException (string Message) : base(Message)
    {
    
    }
    
     public UserAlreadyLoggedInException () : base()
    {
        
    }
}

