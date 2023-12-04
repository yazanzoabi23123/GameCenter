using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFirstLinkedList
{
    internal class MyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public void Add(T value)
        {
            //ניצור נוד חדש עם אותו ערך
            Node<T> newNode = new Node<T>(value);
            //אם הרשימה ריקה -> נשים את הנוד הזה בראש הרשימה
            if (Head == null)
            {
                Head = newNode;
            }
            //אם לא -> נרוץ עד סוף הרשימה ונמקם את הנוד שלנו בסוף הרשימה
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void PrintList()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
        public bool Remove(T value)
        {
            Node<T> current = Head; //pointer to beggining of the list
            Node<T> previous = null; //sign that we in the first Node
            while (current != null) //run until the list ends
            {
                if (current.Value.Equals(value)) //check if equal
                {
                    if (previous == null) //check if the value to remove is the first value
                    {
                        Head = Head.Next; //remove the first value
                    }
                    previous.Next = current.Next; //move the pointer of the previous to the next of current
                    return true;
                }
                previous = current; //move the previous forward //The order of this 2 lines is IMPORTANT
                current = current.Next; //move the current forward 
            }
            return false;
        }


        public bool Search(T value)
        {
            Node<T> current = Head; 
            while (current != null) 
            {
                if (current.Value.Equals(value)) 
                {
                    return true;
                }
                current = current.Next; 
            }
            return false;
        }
        public void RemoveAll()
        {
            Node<T> current = Head;
            Node<T> previous = null;
            while (current != null)
            {
                previous = current;
                current = current.Next;
                previous = null;
            }

        }
    }
}
