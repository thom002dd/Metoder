using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
           // Average(numbers);


            List<int> number2 = new List<int> { 1, 6, 2, 8, 9 };

            List<int> numbers = new List<int> {1,6,7,8,3,5,3,2,9,0,34,57,2346,458,634,9001 };

            Lister(numbers);

            TrueOrFalse(9);

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Input the 2 numbers you want calculated, seperated by Enter key");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());

            int calculated = Plus(tal1, tal2);
            double calculatedDiv = Division(tal1, tal2);
            double calculatedRaised = Raised(tal2, tal1);

            Console.WriteLine("Number 1 + Number 2 = " + calculated);
            Console.WriteLine("Number 1 / Number 2 = : " + calculatedDiv);
            Console.WriteLine("Second number goes into first number " + calculatedRaised + " times.");

            Console.ReadKey();
        }

        public static int Plus(int tal1, int tal2)
        {
            return tal1 + tal2;
        }
        public static int Division(int tal1, int tal2)
        {
            return tal1 / tal2;
        }
        public static double Raised(int tal1, int tal2)
        {
            return tal2 / tal1;
        }
        public static void Lister(List<int> numbers)
        {
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine("Highest number in the list is. " + numbers[0]);
        }
        public static Boolean TrueOrFalse(List<int> numbers2, int x)
        {
            for (int i = 0; i < numbers2.Count; i++)
            {
                bool trueOrFalse = true;

                return numbers2[i] == x;
            }
            return false;
        }
    //    public static int Average(List<int> numbers)
    //    {
    //        for (int i = 0; i < numbers.Count; i++)
    //        {

    //        }

    //        int total = numbers.Sum();
    //        int average2 = total / 16;

    //        return;
    //    }
    }
}   