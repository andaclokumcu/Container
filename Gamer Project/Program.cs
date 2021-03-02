using System;

namespace Gamer_Project
{
    class Program
    {
        static void Main(string[] args)
           
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1, 
                BirthYear = 1996, 
                FirstName = "Andaç", 
                LastName = "Lokumcu", 
                IdentityNumber = 1234 });

            Console.WriteLine("Hello World!");
        }
    }
}
