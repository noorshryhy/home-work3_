using System;
using System.Collections.Generic;

namespace home_work3_LinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SinglyLinkedList
    {
        private Node head;

        // Insert at the beginning
        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        // Insert at the end
        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Insert at a specific position
        public void InsertAtPosition(int data, int position)
        {
            if (position < 0) throw new ArgumentException("Position cannot be negative");

            Node newNode = new Node(data);

            if (position == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node current = head;
            for (int i = 0; current != null && i < position - 1; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                throw new ArgumentException("Position is out of range");
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        // Remove from the beginning
        public void RemoveFromBeginning()
        {
            if (head == null) return;
            head = head.Next;
        }

        // Remove from the end
        public void RemoveFromEnd()
        {
            if (head == null) return;

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

        // Display the list
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }

            Console.WriteLine("null");
        }
    class Program
    {
        static void Main(string[] args)
        {



                SinglyLinkedList list = new SinglyLinkedList();
                list.InsertAtBeginning(1);
                list.InsertAtEnd(2);
                list.InsertAtPosition(3, 1);
                list.Display();

                list.RemoveFromBeginning();
                list.Display();

                list.RemoveFromEnd();
                list.Display();
            }
        }
    } }
    

