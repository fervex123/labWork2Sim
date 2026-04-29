using System;
using System.Collections.Generic;
using System.Text;

namespace labWork2Sim
{
    public class DoubleNode
    {

        private string destination;      
        private string flightNumber;     
        private string passengerName;    
        private DateTime departureDate;  
        private DoubleNode next;
        private DoubleNode prev;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        public string PassengerName
        {
            get { return passengerName; }
            set { passengerName = value; }
        }

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        public DoubleNode Next
        {
            get { return next; }
            set { next = value; }
        }

        public DoubleNode Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public DoubleNode()
        {
            destination = "";
            flightNumber = "";
            passengerName = "";
            departureDate = DateTime.Today;
            next = null;
            prev = null;
        }

        public DoubleNode(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            this.destination = destination;
            this.flightNumber = flightNumber;
            this.passengerName = passengerName;
            this.departureDate = departureDate;
            next = null;
            prev = null;
        }

        public DoubleNode(string destination, string flightNumber, string passengerName, DateTime departureDate,
                         DoubleNode next, DoubleNode prev)
        {
            this.destination = destination;
            this.flightNumber = flightNumber;
            this.passengerName = passengerName;
            this.departureDate = departureDate;
            this.next = next;
            this.prev = prev;
        }
    }
}

