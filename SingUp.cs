using Medical_Store_Management.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_Management
{

    internal class medical
    {
        Medical_storeEntities2 dob = new Medical_storeEntities2();
        //Sing or Create
        
        public void Registration()
        {
            string UName;
            String Pass;
            String Eml;

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Enter UserName...");
            UName = Console.ReadLine();
            Console.WriteLine("Enter Password...");
            Pass = Console.ReadLine();
            Console.WriteLine("Enter Email...");
            Eml = Console.ReadLine();

            models.Registration lg = new models.Registration();
            lg.UserName = UName;
            lg.Password = Pass;
            lg.Email = Eml;
            lg.IsActive = 1;


            dob.Registrations.Add(lg);
            int a = dob.SaveChanges();

            if (a > 0)
            {
                Console.WriteLine("Registration Successfully.....");
            }
            else
            {
                Console.WriteLine("Unable Registration !!!!!");
            }
        }
      public void login()
        {
            Medical_storeEntities2 db = new Medical_storeEntities2();
            string UName;
            String Pass;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Enter UserName...");
            UName = Console.ReadLine();
            Console.WriteLine("Enter Password...");
            Pass = Console.ReadLine();
            var data = db.Logins.Where(x => x.UsarName == UName && x.Password == Pass).FirstOrDefault();
            if (data != null)
            {
                Console.WriteLine("Login Successfully.....");
            }
            else
            {
                Console.WriteLine("Unable Login !!!!!");
            }
        }
    }
}
