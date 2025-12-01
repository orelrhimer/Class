using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
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
            loop7();
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

        static void loop()
        {
            int num;
            Console.WriteLine("write a number!");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("nagger");
            }
            Console.WriteLine(num);
        }
        static void loop2()
        {
            int num;
            Console.WriteLine("write a number!");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i + " nisan the nigger");
            }
            Console.WriteLine(num);
        }
        static void loop3()
        {
            int res = 1;
            Console.WriteLine("write a number!");
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                res = res * i;
            }
            Console.WriteLine(res);
        }
        static void loop4()
        {
            int sum = 0;
            int steps;
            int day;
            int over10k = 0;
            Console.WriteLine("how many days did you walked");
            day = int.Parse(Console.ReadLine());
            for (int i = 1; i <= day; i++)
            {
                Console.WriteLine(" tell " + day + " times how many steps did you take for evry day ");
                steps = int.Parse(Console.ReadLine());
                if (steps >= 10000)
                {
                    over10k++;
                }

                sum = sum + steps;
                Console.WriteLine("you walked" + over10k + "over 10k steps");
                Console.WriteLine(sum);
            }
        }
        static void loop5()
        {
            int student;
            int totalgrade = 0;
            int grade = 0;
            int pass = 0;
            int max = 0;
            int avreggrade = 0;
            Console.Write("how many student you have: ");
            student = int.Parse(Console.ReadLine());

            for (int i = 1; i < student; i++)
            {
                Console.WriteLine("student grade");
                grade = int.Parse(Console.ReadLine());
                totalgrade += grade;
                if (grade > 55)
                {
                    pass++;
                }
                max = Math.Max(max, grade);
            }
            avreggrade = totalgrade / student;


            Console.WriteLine("your avrege grade is " + avreggrade);
            Console.WriteLine(pass + " stdant passed");
            Console.WriteLine("max grade is " + max);

        }
        static void loop6()
        {
            int item;
            int total = 0;
            int price = 0;
            int pass = 0;
            int min = 0;
            int avregprice = 0;
            Console.Write("how many item you have: ");
            item = int.Parse(Console.ReadLine());

            for (int i = 0; i < item; i++)
            {
                Console.Write("what the price of every item: ");
                price = int.Parse(Console.ReadLine());
                total += price;
                if (price > 100)
                {
                    pass++;
                }
                min = Math.Min(min, price);
            }
            avregprice = total + item;


            Console.WriteLine("your price is " + avregprice + "$");
            Console.WriteLine(pass + " above 100$");
            Console.WriteLine("the lowest price " + min);

        }
        static void loop7()
        {
            int min = 0;
            int presnt;
            int above80 = 0;
            bool lower20 = false;
            Console.WriteLine("write yor buttary % for evry hour for 24h"); 
            for (int i = 1; i <= 24; i++)
            {
                Console.Write("thid hour my buttry is: ");
                presnt = int.Parse(Console.ReadLine());
                if (presnt < 20)
                {
                    lower20 = true;
                }

                if (presnt > 80)
                {
                    above80++;
                }
                min = Math.Min(min, presnt);
            }
            Console.WriteLine("the fact that thers an hour that " + lower20);
            Console.WriteLine("ther is" + above80 + );





        }
    }
