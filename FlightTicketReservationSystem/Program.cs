using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    internal class Program {
        static void Main(string[] args) {



            //ywbierz kim jetes
           
            Console.WriteLine("Wybierz kim jeets");
            Console.WriteLine("osoba -1");
            Console.WriteLine("firma -2");
            int y;
            do
            {
                y = Convert.ToInt32(Console.ReadLine());

                if (y == 1)
                {
                    Console.WriteLine("Podaj swoje imie:");
                    string name = Console.ReadLine();
                    Console.WriteLine("podaj swoje drugie imie:");
                    string secondName = Console.ReadLine();
                    Console.WriteLine("Podaj swoje nazwsiko:");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Podaj swoj wiek:");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Person person1 = new Person(name, secondName, surname, age);

                }

                if (y == 2)
                {
                    Console.WriteLine("Podaj swoje nazwa:");
                    string name = Console.ReadLine();
                    Console.WriteLine("podaj krs:");
                    string krs = Console.ReadLine();

                    Company company1 = new Company(name, krs);

                }

            } while (y==1 || y ==2);

            // menu
            Console.WriteLine("1- Wyświetl liste obsługiwanych lotnisk");

            Console.WriteLine("2- Kup bilet");
            //osoba czy firma
           
           // skad dokad
           //kiedy
            // wybierz bielt
           
            // czy powielany
         

            Console.WriteLine("3- usun bilet");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    //wyswietlenie listy lotnisk
                    break;

                case 2:
           
                    if(y == 1)
                    {
                        Console.WriteLine("podaj numer telefonu:");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("podaj email: ");
                        string email = Console.ReadLine();

                        Client client1 = new Client(person1, phoneNumber, email);
                    }

                    if (y == 2)
                    {
                        Console.WriteLine("podaj numer telefonu:");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("podaj email: ");
                        string email = Console.ReadLine();

                        Client client1 = new Client(comapny1, phoneNumber, email);
                    }


                    Console.WriteLine("Skad chcesz leciec?");
                    string odlot = Console.ReadLine();
                    //lista lotnisk case

                    Console.WriteLine("Dokad chcesz leciec?");
                    string przylot = Console.ReadLine();

                    Console.WriteLine("Kiedy checesz leciec?");
                    Console.WriteLine("Rok: ");
                    string rok = Console.ReadLine();
                    Console.WriteLine("Miesiac: ");
                    string msc = Console.ReadLine();
                    Console.WriteLine("Dzien: ");
                    string day = Console.ReadLine();

                    DateTime data = new DateTime(rok, msc, day);

                    Console.WriteLine("Jakiej klasy chcesz bilet?");
                    Console.WriteLine("wciśnij 1, aby wybrać klase business.");
                    Console.WriteLine("wciśnij 2, aby wybrać klase economy.");
                    Console.WriteLine("wciśnij 3, aby wybrać klase first.");

                    int z = Convert.ToInt32(Console.ReadLine());

                    switch (z)
                    {
                        case 1: 
                    }



            }
        }
}
