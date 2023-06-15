using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    internal class Client {
        protected string phoneNumber;
        protected string email;
        protected List<Ticket> tickets = new List<Ticket>();
        protected Person person;
        protected Company company;

        public Client(Person person,  string phoneNumber, string email)
        {   
            this.person = person;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public Client(Company comapny, string phoneNumber, string email)
        {
            this.company = company;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void addTicket(Ticket ticket)
        {
            tickets.Add(ticket);

        }
        public void removeTicket(Ticket ticket)
        {
            tickets.Remove(ticket);
        }
        public List<Ticket> getTickets()
        {
            return tickets;
        }
    }

    class Person : Client
    {
        private string firstName;
        private string SecondName;
        private string lastNmae;
        private int age;
        private string surname;

        public Person(string phoneNumber, string email, string surname, int age) : base(phoneNumber, email)
        {
            this.surname = surname;
            this.age = age;
        }

        public Person(string firstName, string SecondName, string lastName,  string phoneNumber, string email) : base(phoneNumber, email)   
        { 
            this.firstName = firstName;
            this.SecondName = SecondName;
            this.lastNmae = lastName;
        }
    }

    class Company : Client
    {
        private string name;
        private string krs;

        public Company(string phoneNumber, string email) : base(phoneNumber, email)
        {
        }

        public Company(string name, string krs, string phoneNumber, string email) : base(phoneNumber, email) 
        {
            this.name = name;
            this.krs = krs;
        }
    }
}
