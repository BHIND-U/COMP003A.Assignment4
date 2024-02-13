/* Author: Joshua Isidro 
 * Course: COMP003A-L01
 * Purpose: Code for assignment 4
 */


namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("for loop section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("*************************************************************");

            Console.WriteLine("Enter a positive whole number:");
            int limit = Convert.ToInt32(Console.Read());

            string output = "#";
            for (int i = 0; i < limit; i++)
            {
                output += "#";
                Console.WriteLine(output);
            }

            Console.WriteLine("*************************************************************");
            Console.WriteLine("foreach section");
            Console.WriteLine("Output all of the friends in an array");
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe"};
            foreach (string friend in friends)
            {
                Console.WriteLine($"{friend}");
            }


            Console.WriteLine("*************************************************************");
            Console.WriteLine("do-while section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("*************************************************************");

            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);

            Console.WriteLine("*************************************************************");
            Console.WriteLine("while section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("*************************************************************");

            int counter2 = 1;
            while (counter2 <= 20) 
            {
            if (counter2 %2 == 0) { Console.WriteLine("Foo"); }
            if (counter2 %5 == 0) { Console.WriteLine("Bar"); }
            if (counter2 %10 ==0) { Console.WriteLine("FooBar"); }
                else
                    {
                            Console.WriteLine(counter2);
                        }
                counter2++;
            }
        }

    }
}
