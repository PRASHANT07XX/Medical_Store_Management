using Medical_Store_Management.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_Management
{
    internal class Program
    {
        public void Display()
        {
            Console.WriteLine( "                 Wellcome");
            Console.WriteLine(".........Medical Store Management...........");
        }
        public void opestion()
        {
            Console.WriteLine("1. Registration");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter Your Choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch) {
                case 1:
                    Console.WriteLine("1. Registration");
                    break;
                case 2:
                    Console.WriteLine("2. Login");
                    
                    break;
                case 3:
                    Console.WriteLine("3. Exit");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        static void Main(string[] args)
        {
       
            Program obj = new Program();                    
            medical obj1 = new medical(); 
            obj.opestion();
            obj.Display();
            obj1.Registration();
            obj1.login();
            Console.ReadKey();
        }
    }
}
