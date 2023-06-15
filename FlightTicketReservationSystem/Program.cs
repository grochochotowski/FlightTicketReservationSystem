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

            Console.WriteLine("Choose who are you :");
            Console.WriteLine("1- Admin");
            Console.WriteLine("2- Client");

            int x = Convert.ToInt32(Console.ReadLine());

            int clientId;

            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("you are working as Admin");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Menu");
                        Console.WriteLine("pick one of the following number");
                        Console.WriteLine("Choose number 1 if you want do go to Airports tab");
                        Console.WriteLine("Choose number 2 if you want do go to Airplanes tab");
                        Console.WriteLine("Choose number 3 if you want do go to Route tab");
                        Console.WriteLine("Choose number 4 if you want do go to Flights tab");

                        int x = Convert.ToInt32(Console.ReadLine());

                        switch (x)
                        {
                            case 1:
                                Console.WriteLine("Airports");
                                Console.WriteLine("1 - go back");
                                Console.WriteLine("2 - add new airport");
                                Console.WriteLine("============================To delete a airport input its number============================");

                                List<Airport> airports = system.getAirports();
                                int coun = 3;
                                foreach (Airport airport in airports)
                                {
                                    Console.WriteLine($"{coun}: {airport.data}");
                                    coun++;
                                }

                                int y = Convert.ToInt32(Console.ReadLine());
                                switch (y)
                                {
                                    case 1:

                                        ; break;
                                    case 2:
                                        system.addAirport();
                                        break;
                                    case 3:
                                        System.deleteAirport();
                                        break;
                                }
                                break;

                            case 2:
                                Console.WriteLine("Planes");
                                Console.WriteLine("1 - go back");
                                Console.WriteLine("2 - add new plane");
                                Console.WriteLine("============================To delete a plane input its number============================");
                                List<Plane> planes = system.getPlanes();
                                int count = 3;
                                foreach (Plane plane in planes)
                                {
                                    Console.WriteLine($"{count}: {plane.data}");
                                    count++;
                                }

                                int z = Convert.ToInt32(Console.ReadLine());
                                switch (z)
                                {
                                    case 1:

                                        break;
                                    case 2:
                                        system.addPlane();
                                        break;
                                    default:
                                        system.deletePlane();
                                        break;
                                }
                                break;

                            case 3:
                                Console.WriteLine("Routes");
                                Console.WriteLine("1 - go back");
                                Console.WriteLine("2 - add new route");
                                Console.WriteLine("============================To delete a route input its number============================");
                                List<Route> routes = system.getRoutes();
                                int countt = 3;
                                foreach (Route route in routes)
                                {
                                    Console.WriteLine($"{countt}: {route.data}");
                                    countt++;
                                }

                                int a = Convert.ToInt32(Console.ReadLine());
                                switch (a)
                                {
                                    case 1:

                                        break;
                                    case 2:
                                        system.addRoute();
                                        break;
                                    default:
                                        system.deleteRoute();
                                        break;
                                }
                                break;

                            case 4:
                                Console.WriteLine("Flights");
                                Console.WriteLine("1 - go back");
                                Console.WriteLine("2 - add new flight");
                                Console.WriteLine("============================To delete a flight input its number============================");
                                List<Flight> flights = system.getFlights();
                                int counttt = 3;
                                foreach (Flight flight in flights)
                                {
                                    Console.WriteLine($"{counttt}: {flight.data}");
                                    counttt++;
                                }

                                int b = Convert.ToInt32(Console.ReadLine());
                                switch (b)
                                {
                                    case 1:

                                        break;
                                    case 2:
                                        system.addFlight();
                                        break;
                                    default:
                                        system.deleteFlight();
                                        break;
                                }
                                break;
                        }
                    }
                    break;

                case 2:
                    {

                        List<Clinet> clients = system.getClient;

                        Console.WriteLine("choose one option:");
                        Console.WriteLine("1- create a person account");
                        Console.WriteLine("2- create a company account");
                        Console.WriteLine("3- login as person:");
                        Console.WriteLine("4- login as company");

                        int y = Convert.ToInt32(Console.ReadLine());

                        switch (y)
                        {


                            case 1:
                                {
                                    clientId = clients.Count;
                                    Console.WriteLine("Your name: ");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Your second name: ");
                                    string secondName = Console.ReadLine();
                                    Console.WriteLine("Your surname: ");
                                    string surname = Console.ReadLine();
                                    Console.WriteLine("Your age: ");
                                    int age = Convert.ToInt32(Console.ReadLine());


                                    Person person1 = new Person(clientId, name, secondName, surname, age);

                                }
                                break;
                            case 2:
                                {
                                    clientId = clients.Count;
                                    Console.WriteLine("Your name: ");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Your KRS number: ");
                                    int krs = Convert.ToInt32(Console.ReadLine());

                                    Company company1 = new Company(clientId, name, krs);

                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("============================Choose an account to log in============================");


                                    foreach (Person clinet in clients)
                                    {
                                        Console.WriteLine($"{clientData}");

                                    }

                                    Console.WriteLine("choose your account by clinet id");
                                    int acctiveAccount = Convert.ToInt32(Console.ReadLine());

                                    foreach (Company client in clients)
                                    {
                                        if (client.Id == activeAccount)
                                        {
                                            Console.WriteLine($"Client with ID {activeAccount} found.");
                                            found = true;
                                            break;
                                        }
                                    }

                                    if (!found)
                                    {
                                        Console.WriteLine($"Client with ID {activeAccount} not found.");
                                    }


                                    ///wybierz co cchez zrobiv


                                    System system;
                                    //Ticket reservation
                                    switch (choice)
                                    {
                                        case 1:

                                            List<Airport> airports = system.getAirports();
                                            //choosing departure airport
                                            Airport departureAirport;
                                            Console.WriteLine("Choose a departure Airport:");
                                            int count = 1;
                                            foreach (Airport airport in airports)
                                            {
                                                Console.WriteLine($"{count}: {airport.Type} - {airport.Code}");
                                                count++;
                                            }
                                            int departureChoice = Convert.ToInt32(Console.ReadLine());
                                            departureAirport = airports[departureChoice];
                                            Console.Clear();
                                            //choosing arrival airport
                                            Airport arrivalAirport;
                                            Console.WriteLine("Choose a departure Airport:");
                                            count = 1;
                                            foreach (Airport airport in airports)
                                            {
                                                Console.WriteLine($"{count}: {airport.Type} - {airport.Code}");
                                                count++;
                                            }
                                            int arrivalChoice = Convert.ToInt32(Console.ReadLine());
                                            arrivalAirport = airports[arrivalChoice];
                                            Console.Clear();

                                            //searching for route

                                            Route selectedRoute;
                                            List<Route> routes = system.getRoutes();
                                            Route matchingRoute = routes.Find(route =>
                                                route.departureAirport == departureAirport && route.arrivalAirport == arrivalAirport);
                                            if (matchingRoute != null)
                                            {
                                                selectedRoute = matchingRoute;
                                            }
                                            else
                                            {
                                                system.addRoute(Airport departureAirport, Airport arrivalAirport);
                                                selectedRoute = routes.Find(route =>
                                                    route.departureAirport == departureAirport && route.arrivalAirport == arrivalAirport);
                                            }

                                            //searching for flights
                                            Console.WriteLine($"Flights from {departureChoice} to {arrivalChoice}\n=================================================");
                                            Flight selectedFLight;
                                            List<Flight> flights = system.getFlights();
                                            List<Flight> foundFlights = flights.Find(flight =>
                                                flight.route.departureAirport == departureChoice && flight.route.arrivalAirport == arrivalAirport);
                                            if (foundFlights != null)
                                            {
                                                Console.WriteLine($"Avaliable flights from {departureAirport} to {arrivalAirport}:\n=================================================");
                                                int count = 1;
                                                foreach (flight in foundFlights)
                                                {
                                                    Console.WriteLine($"{count}: {flight.departureDate} - {flight.arrivalDate} | {flight.duration}");
                                                    count++;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"We are sorry, there are not any flights from {departureChoice} to {arrivalChoice} at the moment.\n" +
                                                    $"  Would you like to sumbit, a flight request? [write \"yes\" to submit]");
                                                string answer = Console.ReadLine();
                                                if (answer != "yes") Console.WriteLine("Your request has been submited.");
                                            }


                                            break;
                                        case 2:
                                            break;
                                        case 3:
                                            break;
                                    }
                                }
                        }
                                break;



                            case 4:
                                {
                                    Console.WriteLine("============================Choose an account to log in============================");


                                    foreach (Company clinet in clients)
                                    {
                                        Console.WriteLine($"{clientData}");

                                    }


                                    Console.WriteLine("choose your account by clinet id");
                                    int acctiveAccount = Convert.ToInt32(Console.ReadLine());

                                    foreach (Company client in clients)
                                    {
                                        if (client.Id == activeAccount)
                                        {
                                            Console.WriteLine($"Client with ID {activeAccount} found.");
                                            found = true;
                                            break;
                                        }
                                    }

                                    if (!found)
                                    {
                                        Console.WriteLine($"Client with ID {activeAccount} not found.");
                                    }

                        System system;
                        //Ticket reservation
                        switch (choice)
                        {
                            case 1:

                                List<Airport> airports = system.getAirports();
                                //choosing departure airport
                                Airport departureAirport;
                                Console.WriteLine("Choose a departure Airport:");
                                int count = 1;
                                foreach (Airport airport in airports)
                                {
                                    Console.WriteLine($"{count}: {airport.Type} - {airport.Code}");
                                    count++;
                                }
                                int departureChoice = Convert.ToInt32(Console.ReadLine());
                                departureAirport = airports[departureChoice];
                                Console.Clear();
                                //choosing arrival airport
                                Airport arrivalAirport;
                                Console.WriteLine("Choose a departure Airport:");
                                count = 1;
                                foreach (Airport airport in airports)
                                {
                                    Console.WriteLine($"{count}: {airport.Type} - {airport.Code}");
                                    count++;
                                }
                                int arrivalChoice = Convert.ToInt32(Console.ReadLine());
                                arrivalAirport = airports[arrivalChoice];
                                Console.Clear();

                                //searching for route

                                Route selectedRoute;
                                List<Route> routes = system.getRoutes();
                                Route matchingRoute = routes.Find(route =>
                                    route.departureAirport == departureAirport && route.arrivalAirport == arrivalAirport);
                                if (matchingRoute != null)
                                {
                                    selectedRoute = matchingRoute;
                                }
                                else
                                {
                                    system.addRoute(Airport departureAirport, Airport arrivalAirport);
                                    selectedRoute = routes.Find(route =>
                                        route.departureAirport == departureAirport && route.arrivalAirport == arrivalAirport);
                                }

                                //searching for flights
                                Console.WriteLine($"Flights from {departureChoice} to {arrivalChoice}\n=================================================");
                                Flight selectedFLight;
                                List<Flight> flights = system.getFlights();
                                List<Flight> foundFlights = flights.Find(flight =>
                                    flight.route.departureAirport == departureChoice && flight.route.arrivalAirport == arrivalAirport);
                                if (foundFlights != null)
                                {
                                    Console.WriteLine($"Avaliable flights from {departureAirport} to {arrivalAirport}:\n=================================================");
                                    int count = 1;
                                    foreach (flight in foundFlights)
                                    {
                                        Console.WriteLine($"{count}: {flight.departureDate} - {flight.arrivalDate} | {flight.duration}");
                                        count++;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"We are sorry, there are not any flights from {departureChoice} to {arrivalChoice} at the moment.\n" +
                                        $"  Would you like to sumbit, a flight request? [write \"yes\" to submit]");
                                    string answer = Console.ReadLine();
                                    if (answer != "yes") Console.WriteLine("Your request has been submited.");
                                }


                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                        }
                    }
            }


                                break;

                            default:
                                Console.WriteLine("select corrected option!");
                                break;
                        }

                    }
                    break;
            }
        

        
        }
}
