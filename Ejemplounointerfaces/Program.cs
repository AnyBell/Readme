using System;

namespace Ejemplounointerfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //User newUser2 = new User();
            Console.writeLine("Ingrese nombre de usuario:");
            string name = Console.ReadLine();

            User newUser = new User(name);
            // newUser.SetName(name);
            Console.WriteLine("Ingrese su apellido");
            newUser.SetLastName(Console.ReadLine());
            
            Consol.writeLine(newUser.SetFullName());
        }
    }
}
