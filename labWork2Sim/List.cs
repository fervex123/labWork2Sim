using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace labWork2Sim
{

    public class SingleLinkedList
    {
        private Node first;
        public SingleLinkedList()
        {
            first = null;
        }
        public void DisplayAll(DataGridView dgv)
        {
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("ColNum", "№");
                dgv.Columns.Add("ColPassenger", "Пассажир");
                dgv.Columns.Add("ColFlight", "Рейс");
                dgv.Columns.Add("ColDest", "Назначение");
                dgv.Columns.Add("ColDate", "Дата вылета");

                dgv.Columns["ColNum"].Width = 50;
                dgv.Columns["ColPassenger"].Width = 150;
                dgv.Columns["ColFlight"].Width = 100;
                dgv.Columns["ColDest"].Width = 120;
                dgv.Columns["ColDate"].Width = 120;
            }

            Node current = first;
            int index = 1;

            if (current == null)
            {
                dgv.Rows.Add("", "Список пуст", "", "", "");
                

            }

            else
            {
                while (current != null)
                {
                    dgv.Rows.Add(
                    index.ToString(),
                    current.PassengerName,
                    current.FlightNumber,
                    current.Destination,
                    current.DepartureDate.ToString("dd.MM.yyyy"));
                    current = current.Link;
                    index++;
                }
            }
            
        }
        public void DisplayByFlightAndDate(DataGridView dgv, string flightNumber, DateTime date)
        {
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("ColNum", "№");
                dgv.Columns.Add("ColPassenger", "Пассажир");
                dgv.Columns.Add("ColFlight", "Рейс");
                dgv.Columns.Add("ColDest", "Назначение");
                dgv.Columns.Add("ColDate", "Дата вылета");
            }

            Node current = first;
            int index = 1;
            bool found = false;

            while (current != null)
            {
                if (current.FlightNumber == flightNumber &&
                    current.DepartureDate.Date == date.Date)
                {
                    dgv.Rows.Add(
                        index.ToString(),
                        current.PassengerName,
                        current.FlightNumber,
                        current.Destination,
                        current.DepartureDate.ToString("dd.MM.yyyy")
                    );
                    found = true;
                }
                index++;
                current = current.Link;
            }

            if (!found)
            {
                dgv.Rows.Add("Заявки не найдены", "", "", "");
            }
        }
        public bool DisplayByPassenger(DataGridView dgv, string passengerName)
        {
            bool flag = false;
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("ColNum", "№");
                dgv.Columns.Add("ColPassenger", "Пассажир");
                dgv.Columns.Add("ColFlight", "Рейс");
                dgv.Columns.Add("ColDest", "Назначение");
                dgv.Columns.Add("ColDate", "Дата вылета");
            }

            Node current = first;
            int index = 1;

            while (current != null)
            {
                if (current.PassengerName.Equals(passengerName, StringComparison.OrdinalIgnoreCase))
                {
                    dgv.Rows.Add(
                        index.ToString(),
                        current.PassengerName,
                        current.FlightNumber,
                        current.Destination,
                        current.DepartureDate.ToString("dd.MM.yyyy")

                    );
                    flag= true;
                }
                index++;
                current = current.Link;
            }

            dgv.Rows.Add("Пассажир не найден", "", "", "");
            return false;
        }
        public void AddToBeginning(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            Node newNode = new Node(destination, flightNumber, passengerName, departureDate);
            newNode.Link = first;
            first = newNode;
        }
        public void AddToEnd(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            Node newNode = new Node(destination, flightNumber, passengerName, departureDate);
            if (first == null)
            {
                first = newNode;
            }
            else
            {
                Node current = first;
                while (current.Link != null)
                    current = current.Link;
                current.Link = newNode;
            }
        }
        public bool AddAtPosition(int position, string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            bool flag = false;

            if (position >= 1)
            {
                if (position == 1)
                {
                    AddToBeginning(destination, flightNumber, passengerName, departureDate);
                    flag = true;
                }
                else if (first != null)
                {
                    Node current = first;

                    for (int i = 1; current != null && i < position - 1; i++)
                    {
                        current = current.Link;
                    }

                    if (current != null)
                    {
                        Node newNode = new Node(destination, flightNumber, passengerName, departureDate);
                        newNode.Link = current.Link;
                        current.Link = newNode;
                        flag = true;
                    }
                }
            }

            return flag;
        }



        public bool RemoveFromBeginning()
        {
            bool flag = true;
            if (first == null) flag= false;
            else
            {
                first = first.Link;
            }
           
            return flag;
        }

        public bool RemoveFromEnd()
        {
            bool flag = true;
            if (first == null) flag= false;

            if (first.Link == null)
            {
                first = null;
                flag= true;
            }
            else
            {
                Node current = first;
                while (current.Link.Link != null)
                current = current.Link;

                current.Link = null;
            }
            
            return flag;
        }

        public bool RemoveAtPosition(int position)
        {
            bool flag = false;

            if (position >= 1 && first != null)
            {
                if (position == 1)
                {
                    first = first.Link;
                    flag = true;
                }
                else
                {
                    Node current = first;
                    int index = 1;

                    while (current != null && index < position - 1)
                    {
                        current = current.Link;
                        index++;
                    }

                    if (current != null && current.Link != null)
                    {
                        current.Link = current.Link.Link;
                        flag = true;
                    }
                }
            }

            return flag;
        }





        public void Destroy()
        {
            first = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }

    }



}

