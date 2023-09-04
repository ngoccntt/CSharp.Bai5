using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intA, intB, intC;
            
            double ketqua;
            Console.WriteLine(" ------------ CHUONG TRINH GIAI PHUONG TRINH BAC 2 ------------ ");
            Console.WriteLine(" ------------------------- ax^2 + bx + c =0 ------------------------- ");
            Console.Write("Nhap a: ");
            intA = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "Nhap b: ");
            intB = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "Nhap c: ");
            intC = Convert.ToInt32(Console.ReadLine());
            
            else
            {
                ketqua = (double)Math.Pow(2,3) - 4 * intA * intC;
                Console.WriteLine(" Phuong trinh co 1 nghiem duy nhat x = {0}", ketqua);
            }
            Console.ReadKey();
        }
    }
}
if ()
            {
                Console.WriteLine(" Phuong trinh vo nghiem");
            }
            else if ()
            {
                Console.WriteLine(" Phuong trinh co nghiem kep");
            }
            else if ()
            {
                Console.WriteLine(" Phuong trinh co 2 nghiem phan biet");
            }