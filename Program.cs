using System;
using System.Collections.Generic;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Andrew";
            int age = 23;
            float average = 38.23f;
            decimal price = 99.98m;
            bool found = false; //true

            Console.WriteLine(name);
            Console.WriteLine(age);

            Program p = new Program();
            p.Test();
            p.TestMath();

            bool res1 = p.IsItEven(33);
            System.Console.WriteLine(res1);

            decimal a = p.GetBiggest(34m, 79m);
            System.Console.WriteLine(a);

            bool x = p.IsItPrime(10);
        }

        void Test()
        {
            System.Console.WriteLine("Hello from a method");
            int age = 34;

            if (age < 98)
            {
                System.Console.WriteLine("You are still young, don't worry");
            }
            else
            {
                System.Console.WriteLine("Ouch, kind of getting old, sorry");
            }
            SayHello("Andrew");

        }

        void SayHello(string name)


        {
            System.Console.WriteLine("Hello:" + name);

            for (int i = 0; i < 12; i++)
            {
                if (i != 3 && i != 7)
                    System.Console.WriteLine(i);
            }

            //array   
            string[] names = new string[20];
            names[0] = "Nick";
            names[1] = "Duane";
            names[2] = "Andrew";
            names[3] = "Katelynn";

            //list
            var students = new List<string>();
            students.Add("Jesus");
            students.Add("Matthew");
            students.Add("Nate");
            students.Add("Erick");
            students.Add("D Ross");
            students.Add("Roberto");

            for (int i = 0; i < students.Count; i++)
            {
                System.Console.WriteLine(students[i]);
            }

            //for is usually for everything, while foreach is usually for lists

            foreach (string person in students)
            {
                System.Console.WriteLine(person);
            }
        }

        void TestMath()
        {
            System.Console.WriteLine(21 + 21); //answer to life the universe and everything
            System.Console.WriteLine(42 - 21);
            System.Console.WriteLine(3 * 4);
            System.Console.WriteLine(10 / 2);

            System.Console.WriteLine(11 % 2);
        }


        bool IsItEven(int num)
        {
            return (num % 2) == 0;
        }


        decimal GetBiggest(decimal num1, decimal num2)
        {
            if (num1 > num2) return num1;
            else return num2;
        }

        bool IsItPrime(int num1)
        {

            Console.WriteLine("Enter number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0 || num1 == 1)
            {
                System.Console.WriteLine("It's Not Prime");
                return false;
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        System.Console.WriteLine("It's Not Prime");
                        return false;
                    }

                }
                System.Console.WriteLine("It's Prime");
                return true;
            }
        }
    }
}


