using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace orel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kwh();
        }

        static void Myfanc1()
        {
            bool isRain;
            bool teacherfree;
            bool principalapproved;
            int parentscount; bool cango;


            Console.WriteLine("is it raining");
            isRain = bool.Parse(Console.ReadLine());

            Console.WriteLine("is the teacher free");
            teacherfree = bool.Parse(Console.ReadLine());

            Console.WriteLine("is the principal approved");
            principalapproved = bool.Parse(Console.ReadLine());

            Console.WriteLine("how many parnts coming");
            parentscount = int.Parse(Console.ReadLine());

            cango = (!isRain) && teacherfree && (parentscount > 1) && principalapproved;
            Console.WriteLine(cango ? "can go" : "cant go");

        }

        static void Myfanc()
        {
            Random rnd = new Random();
            int x1 = rnd.Next(0, 11);
            int x2 = rnd.Next(0, 11);
            int y1 = rnd.Next(0, 11);
            int y2 = rnd.Next(0, 11);

            Console.WriteLine(Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2)));

        }

        static void Ifelse()
        {

            int num;
            Console.WriteLine("say a number ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("not even number");
            }
        }
        static void Temp()
        {

            int num;
            Console.WriteLine("say a temp number ");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("cold");
            }
            else if (num <= 30)
            {
                Console.WriteLine("nice temp");
            }
            else { Console.WriteLine("hot"); }


        }

        static void Password()
        {

            int num;
            Console.WriteLine("type the password ");
            num = int.Parse(Console.ReadLine());

            if (num == 1234)
            {
                Console.WriteLine("get in");
            }


            else { Console.WriteLine("get out"); }
        }
        static void Orfunc()
        {
            char input;


            Console.WriteLine("enter a letter number or symbol");
            input = char.Parse(Console.ReadLine());

            if ((input >= 97 && input <= 122) || (input >= 65 && input <= 90))
            {
                Console.WriteLine("lettr");
            }

            else if (input >= 48 && input <= 57)
            {
                Console.WriteLine("diget");
            }
            else
            {
                Console.WriteLine("symbol");
            }

        }


        static void grade()
        {
            double grade;
            Console.WriteLine("what is your grade");
            grade = double.Parse(Console.ReadLine());
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("invalid input");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("perfect");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("very good");
            }


            else if (grade > 60)

            {
                Console.WriteLine("passed");
            }
            else if (grade > 70)
            {
                Console.WriteLine("you need to work harder");
            }


            else
            {
                Console.WriteLine("stupid nigger you faild");
            }

        }

        static void numtype()
        {
            double num;

            Console.WriteLine("enter number");
            num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("positiv");
                if (num % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }

            }
            else
            {
                Console.WriteLine("negetiv");
            }

        }
        static void kwh()
        {
            double price;
            bool business;
            double usge;

            Console.WriteLine(" are you in business ");
            business = bool.Parse(Console.ReadLine());
            Console.WriteLine("elctricity usage");
            usge = double.Parse(Console.ReadLine());
            if (usge < 300)
            {
                price = usge * 0.5;
            }
            else if (usge < 600)
            {
                price = usge * 0.7;
            }
            else
            {
                price = usge * 1;
            }

            if (business == true)
            {
                price = price + price * 15 / 100;
            }
            else
            {
                price = price + price * 5 / 100;
            }
            Console.WriteLine("your price is:" + price);
        }







    }
}
