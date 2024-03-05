using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            //int a = 10;
            //int b = 6;

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Penambahan " + a +" + " + b + " = " + penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}" , a , b, pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}" , a , b, perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}" , a , b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
            
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b) 
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
