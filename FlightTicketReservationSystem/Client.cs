using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FlightTicketReservationSystem {
    internal abstract class Client {
        protected int clientId;
        protected string phoneNumber;
        protected string email;
        protected List<Ticket> tickets = new List<Ticket>();

        public Client(int clientId, string phoneNumber, string email)
        {
            this.clientId = clientId;
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

        public abstract string clientData { get; }
    }

    class Person : Client
    {
        private string firstName;
        private string secondName;
        private string lastName;
        private int age;

        public Person(int clientId,  string phoneNumber, string email, string firstName, string secondName, string lastName, int age) : base(clientId, phoneNumber, email)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.age = age;
        }
        public override string clientData { get { return $"{clientId}: {firstName} {secondName}"; } }
    }

    class Company : Client
    {
        private string name;
        private string krs;

        public Company(int clientId, string phoneNumber, string email, string name, string krs) : base(clientId, phoneNumber, email)
        {
            this.name = name;
            this.krs = krs;
        }

        public override string clientData { get { return $"{clientId}: {name} - {krs}"; } }
    }
}
