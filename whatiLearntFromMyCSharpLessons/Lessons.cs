using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace whatiLearntFromMyCSharpLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //allows me to write stuff on console
            
            /* look
             * at
             * this
             * long
             * comment
             */

            //variables
            
            /*
            int = stores numbers from 2^-31 to 2^31-1
            short = stores numbers from 2^-15 to 2^15-1
            long = stores numbers from 2^-63 to 2^63-1
            float = stores fractional numbers with 6 or 7 decimal digits
            double = stores fractional numbers with 15 decimal digits (damn)
            decimal = this one is a big boy, it can hold 28 or 29 digits (god damn)
            bool = means boolean. only stores two values: true and false
            char = stores a character (text)
            string = stores multiple character
            var = this mf can hold anything
            */
            
            int firstNumber;
            firstNumber = 5;
            
            int secondNumber;
            secondNumber = 10;
            
            Console.WriteLine(firstNumber);
            Console.WriteLine("Second number is {0} and first number is {1}", secondNumber, firstNumber);

            short shawty = 32767;
            Console.WriteLine("{0} equals to 2^15-1", shawty);

            long longNumberIDK =  2147483648;
            Console.WriteLine("{0} is such a big number.", longNumberIDK);

            bool checkOne = true;
            bool checkTwo = false;

            if (checkOne == true)
            {
                Console.WriteLine("Reality is often disappointing.");
            }
            else if (checkTwo == true)
            {
                Console.WriteLine("Impossible.");
            }

            char fourthLetter = 'd';
            char ninthLetter = 'i';
            char fifthLetter = 'e';

            string name = "Inigo";
            string lastName = "Montoya";
            string fullName = name + " " + lastName;

            Console.WriteLine("My name is {0}, you killed my father. Prepare to {1}{2}{3}.", fullName, fourthLetter, ninthLetter, fifthLetter);
            
            Console.WriteLine("Inigo starts with an {0}", fullName[0]);

            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine(fullName[i]);
            }

            float pi = 3.14f; //f stands for float, without it, this variable has no difference from double
            double aRandomNumber = 5.765312;
            decimal decimalNumber = 69.765373524m; //m stand for money(why????), again its the same reason with ^^

            var variable1 = "a string";
            var variable2 = 74; //a number (much cool)
            
            Console.Read(); //makes the console not disappear immediately
        }
    }
}