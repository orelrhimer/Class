using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            password();



        }

        static void Myfanc1()
        {
            bool isRain;
            bool teacherfree;
            bool principalapproved;
            int parentscount;
            bool cango;

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

        static void ifelse()
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
        static void temp()
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

        static void password()
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
    }
}


