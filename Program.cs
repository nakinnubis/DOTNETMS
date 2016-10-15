using System;

namespace ConsoleApplication
{
    public class Program
    {
        
        public static void Main(string[] args) 
         {
            // int number = 40;
             //Console.WriteLine(number);
             var abiola = "Akinnubi Sylvester";  
              var greetings =  "Welcome back to C# it's been a while";     
              string  abbeycity = "Testing a string";      
              if (abiola.Length != abbeycity.Length )
              {
                  Console.WriteLine("They are not of equal lengths");
                  
              }
             //var greetings = "Welcome back to C# it's been a while";
             Console.WriteLine($"{greetings} {abiola} ! & {abbeycity}");
            
            //return 1;
           //return number;
        }
    }
}
