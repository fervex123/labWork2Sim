using System;
using System.Collections.Generic;
using System.Text;

namespace labWork2Sim
{
    public class CycleDoubleLinkedList
    {
        public DoubleNode head; // ссылка на головной узел (заглушка)

        public CycleDoubleLinkedList()
        {
            head = new DoubleNode();
            head.Next = head;
            head.Prev = head;
        }

        // Вывод всех заявок в DataGridView
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
           
            if (head.Next == head)
            {
                dgv.Rows.Add("", "Список пуст", "", "", "");

            }
            else
            {
                DoubleNode current = head.Next;
                int index = 1;

                while (current != head)
                {
                    dgv.Rows.Add(
                    index.ToString(),
                    current.PassengerName,
                    current.FlightNumber,
                    current.Destination,
                    current.DepartureDate.ToString("dd.MM.yyyy"));
                    current = current.Next;
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

            if (head.Next == head)
            {
                dgv.Rows.Add("", "Список пуст", "", "", "");
                return;
            }

            DoubleNode current = head.Next;
            int index = 1;
            bool found = false;

            while (current != head)
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
                current = current.Next;
                index++;
            }

            if (!found)
            {
                dgv.Rows.Add("", "Заявки не найдены", "", "", "");
            }
        }
        public bool DisplayByPassenger(DataGridView dgv, string passengerName)
        {
            bool result = false;

            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("ColNum", "№");
                dgv.Columns.Add("ColPassenger", "Пассажир");
                dgv.Columns.Add("ColFlight", "Рейс");
                dgv.Columns.Add("ColDest", "Назначение");
                dgv.Columns.Add("ColDate", "Дата вылета");
            }

            if (head.Next == head)
            {
                dgv.Rows.Add("", "Список пуст", "", "", "");
                result = false;
            }
            else
            {
                DoubleNode current = head.Next;
                int index = 1;
                bool found = false;

                while (current != head)
                {
                    if (current.PassengerName == passengerName)
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
                    current = current.Next;
                    index++;
                }

                if (!found)
                {
                    dgv.Rows.Add("", "Пассажир не найден", "", "", "");
                    result = false;
                }
                else
                {
                    result = true;
                }
            }

            return result;
        }

        public void AddToBeginning(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            DoubleNode newNode = new DoubleNode(destination, flightNumber, passengerName, departureDate);
            newNode.Next = head.Next;
            newNode.Prev = head;
            head.Next.Prev = newNode;
            head.Next = newNode;
        }

        public void AddToEnd(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            DoubleNode newNode = new DoubleNode(destination, flightNumber, passengerName, departureDate);
            newNode.Next = head;
            newNode.Prev = head.Prev;
            head.Prev.Next = newNode;
            head.Prev = newNode;
        }

        public bool AddAtPosition(int position, string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            bool result = false;

            if (position >= 1)
            {
                if (position == 1)
                {
                    AddToBeginning(destination, flightNumber, passengerName, departureDate);
                    result = true;
                }
                else if (head.Next != head)
                {
                    DoubleNode current = head.Next;
                    int index = 1;

                    while (current != head && index < position - 1)
                    {
                        current = current.Next;
                        index++;
                    }

                    if (current != head)
                    {
                        DoubleNode newNode = new DoubleNode(destination, flightNumber, passengerName, departureDate);
                        newNode.Next = current.Next;
                        newNode.Prev = current;
                        current.Next.Prev = newNode;
                        current.Next = newNode;
                        result = true;
                    }
                }
            }

            return result;
        }

        public bool RemoveFromBeginning()
        {
            bool result = false;

            if (head.Next != head)
            {
                head.Next = head.Next.Next;
                head.Next.Prev = head;
                result = true;
            }

            return result;
        }

        public bool RemoveFromEnd()
        {
            bool result = false;

            if (head.Next != head)
            {
                if (head.Next == head.Prev) 
                {
                    head.Next = head;
                    head.Prev = head;
                    result = true;
                }
                else
                {
                    head.Prev = head.Prev.Prev;
                    head.Prev.Next = head;
                    result = true;
                }
            }

            return result;
        }

        public bool RemoveAtPosition(int position)
        {
            bool result = false;

            if (position >= 1 && head.Next != head)
            {
                if (position == 1)
                {
                    result = RemoveFromBeginning();
                }
                else
                {
                    DoubleNode current = head.Next;
                    int index = 1;

                    while (current != head && index < position)
                    {
                        current = current.Next;
                        index++;
                    }

                    if (current != head)
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                        result = true;
                    }
                }
            }

            return result;
        }

        public DoubleNode GetNodeAtPosition(int position)
        {
            DoubleNode result = null;

            if (position >= 1 && head.Next != head)
            {
                DoubleNode current = head.Next;
                int index = 1;

                while (current != head && index < position)
                {
                    current = current.Next;
                    index++;
                }

                if (current != head)
                {
                    result = current;
                }
            }

            return result;
        }

        public bool ModifyAtPosition(int position, string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            bool result = false;
            DoubleNode node = GetNodeAtPosition(position);

            if (node != null)
            {
                node.Destination = destination;
                node.FlightNumber = flightNumber;
                node.PassengerName = passengerName;
                node.DepartureDate = departureDate;
                result = true;
            }

            return result;
        }

        
        public void Clear()
        {
            head.Next = head;
            head.Prev = head;
        }

        public void Destroy()
        {
            head.Next = null;
            head.Prev = null;
        }

        public int GetCount()
        {
            int count = 0;

            if (head.Next != head)
            {
                DoubleNode current = head.Next;

                while (current != head)
                {
                    count++;
                    current = current.Next;
                }
            }

            return count;
        }
    }
 }

