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

           //triming, concatination and string manipulation

           string one = "one";
           string two = "two";
           string three = "123";
           Console.WriteLine(one + two + three);

           string Original = "The Great Programmer";
           string Capital = Original.ToUpper();
           string Lower = Original.ToLower();
           Console.WriteLine(Original + " "+ Capital + " "+ Lower);
           string tobetrim = " Programmers ";
           string trimmed1  = tobetrim.TrimStart();
           string trimmed2  = tobetrim.TrimEnd();
           string trimmed3  = tobetrim.Trim();
           Console.WriteLine("This is Original: "+tobetrim+ "\n This is trimmed1" +trimmed1+ "\n This is trimmed2"+trimmed2+"\n This is trimmed3"+trimmed3);

           //using the substring shorthand version
           string subsbtringVersion = tobetrim.Trim().Substring(0,10);
           Console.WriteLine(subsbtringVersion);
           string name = "Abiola";
           string surname = "Akinnubi";
           string greetme = String.Format("Hello {0} {1}!", name,surname); // Hello Abiola Akinnubi!
           Console.WriteLine(greetme);

        }
    }
}
