using System;

namespace ConsoleApplication
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // int number = 40;
            //Console.WriteLine(number);
            //var abiola = "Akinnubi Sylvester";
            /* var greetings = "Welcome back to C# it's been a while";
             string abbeycity = "Testing a string";
             if (abiola.Length != abbeycity.Length)
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
             Console.WriteLine(Original + " " + Capital + " " + Lower);
             string tobetrim = " Programmers ";
             string trimmed1 = tobetrim.TrimStart();
             string trimmed2 = tobetrim.TrimEnd();
             string trimmed3 = tobetrim.Trim();
             Console.WriteLine("This is Original: " + tobetrim + "\n This is trimmed1" + trimmed1 + "\n This is trimmed2" + trimmed2 + "\n This is trimmed3" + trimmed3);

             //using the substring shorthand version
             string subsbtringVersion = tobetrim.Trim().Substring(0, 10);
             Console.WriteLine(subsbtringVersion);
             string name = "Abiola";
             string surname = "Akinnubi";
             string greetme = String.Format("Hello {0} {1}!", name, surname); // Hello Abiola Akinnubi!
             Console.WriteLine(greetme);

             //Date and time and looping through a particular date 

             var someTime = new DateTime(2016, 10, 1, 11, 10, 9); // 1 October 2016 11:10:09 AM
             int year = someTime.Year; // 2016
             int month = someTime.Month; // 7
             int day = someTime.Day; // 1
                                     // int hour = someTime.Hour; // 11
                                     //int minute = someTime.Minute; // 10
                                     //int second = someTime.Second; // 9
             int yearprev = 1960;
             for (int i = yearprev; i <= year; i++)
             {
                 Console.WriteLine(i + " " + $"{month} {day}");
             }

             //Console.WriteLine($"{nameof(someTime)}: {someTime}");
             // Console.WriteLine($"{nameof(year)}: {year}");
             // Console.WriteLine($"{nameof(month)}: {month}");
             //Console.WriteLine($"{nameof(day)}: {day}");
             //Console.WriteLine($"{nameof(hour)}: {hour}");
             //Console.WriteLine($"{nameof(minute)}: {minute}");
             // Console.WriteLine($"{nameof(second)}: {second}");
             //int y = Console.Read();
             //int x = Console.Read();

             //  if (x > y)
             //  {
             // Console.WriteLine (-1);
             // }
             // else if(x == y) {
             //      Console.WriteLine("equals");

             //  }
             //  else{
             //    Console.WriteLine("Y is greater");
             //}
             // int validNumber = new Random().Next(100);
             // Console.Write("Enter a number to guess");
             //int userInput = int.Parse(Console.ReadLine()) ;
             //if (validNumber == userInput)
             // {
             //   Console.WriteLine ("you guess right ! yooooh!!!!");
             //  }else{
             //   Console.WriteLine("Try again Next time");
             // }
             var myTime = new DateTime(2016, 10, 1, 11, 10, 9);
             var meTime = new DateTime(2016, 10, 1, 03, 30, 00);
             var presentDayGreeting = DateTime.Now;
             // while ((presentDayGreeting == meTime) && (presentDayGreeting <= myTime) )
             // {
             //   Console.WriteLine(" Good Evening");
             //}

             if (presentDayGreeting >= meTime)
             {
                 Console.WriteLine("Good Evening");
             }
             else if (presentDayGreeting < meTime)
             {
                 Console.WriteLine("Good day what time is it now: ");

             }
             else
             {
                 Console.WriteLine("Good Bye!");
             }*/

         /*   Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1)
            {
                int candidateFactor = 2;

                while (candidateFactor <= number) // convert this to while
                {
                    if (number % candidateFactor == 0) // found a factor
                    {
                        number = candidateFactor;

                        Console.Write(number);
                        // divide number by the factor you found and assign this back to number
                        // print a comma if number is still greater than 1
                    }
                    else if (number % candidateFactor > 0)
                    {
                        candidateFactor += candidateFactor;
                        Console.WriteLine(candidateFactor);

                    }
                    // don't forget to increment factor!
                }
                break;

            }
            while (number > 100) // convert this to while
            {
                number += number;

            }
            Console.WriteLine();*/

            //looping at an odd value
           /* for (int i = 1; i < 50; i+=2)
            {
                Console.WriteLine(i);
                 Console.WriteLine("\n\n");
            }

            for (int i = 51 - 1; i >= 0 ; i--)
            {
                Console.WriteLine(i);
                Console.WriteLine("\n\n");
            }
              for (int i = 50 - 1; i >= 1 ; i-=2)
            {
                Console.WriteLine(i);
                Console.WriteLine("\n\n");
            }

            var counting = 24;
            var startcount = 0;
            for (var i = startcount; i <= counting; i+=3)
            {
                Console.WriteLine(i);
            }

             for (var i = startcount; i <= counting; i+=4)
            {
                Console.WriteLine(i);
            }*/

            //playing with arrays in c#

            int [] someArray = new [] {1,2,3}; // is valid way of declaring arrays
            int [] anotherArray = new int [] {4,5,6}; // another valid way of declaring an arrays
           for (int i = 0; i < someArray.Length; i++){
               //Console.WriteLine(i);
               Console.WriteLine(someArray[i]);
           }

           //converting string to an arrays
           string someStrings = "they,are,here,as,expected,we,know,them";
           string [] sentence = someStrings.Split(',');
           string finalSentence = String.Join(" ",sentence);
           Console.WriteLine(finalSentence);
           







        }
    }
}
