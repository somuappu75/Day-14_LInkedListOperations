using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_LInkedListOperations
{
    class Operations
    {

        public Node head;
        //Creating a method to insert last 
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list " + new_node.data);
        }
        //Insert Top
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted the list in front " + new_node.data);
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.data = new_data;//assign data element
            new_node.next = null;//assign null to next of new node
            //check linkedlist empty 
            if (head == null)
            {
                head = new_node;

            }
            else
            {
                //traverse to last node
                Node temp = new Node(new_data);
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;

            }



        }

        //Displaying nodes
        public void Display()
        {
            Console.WriteLine("------------------Displaying Nodes---------");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
