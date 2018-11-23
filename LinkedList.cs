using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework
{
    abstract class LinkedListBase
    {
        public int LastItem = 0; //Länge des Arrays für Binäre Suche
        public ListElement start;
        public ListElement LastSearchItem; //speichern des letzten gesuchten Elements
        public ListElement LastSearchItemPrev; //Vorgänger zu letztem gesuchtem Element

        public class ListElement
        {
            public int number;
            public ListElement next;

            public ListElement(int number)
            {
                this.number = number;
                next = null;
            }
        }
        
        public void print()
        {
            ListElement CurrentNode = start;
            while (CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.number);
                CurrentNode = CurrentNode.next;
            }
        }
    }
    class MultiSetSortedLinkedList : LinkedListBase, IMultiSetSorted
    {
        public bool search(int elem)
        {
            
            return true;
        }
        public bool insert(int elem)
        {
            ListElement newElement = new ListElement(elem);
            if (LastItem == 0)
            {
                start = newElement;
            }
            else
            {
                search(elem);
                LastSearchItemPrev.next = newElement; //Der Nachfolger des Vorgängers des Letzten Suchelements ist das neue Element
                newElement.next = LastSearchItem;  //Der Nachfolger des neuen Elements wird das Letzte Suchelement
            }
            return true;
        }
        public bool delete(int elem)
        {
            return true;
        }
    }
    class MultiSetUnsortedLinkedList : LinkedListBase, IMultiSet
    {
        public bool search(int elem)
        {
            ListElement CurrentNode = start.next;
            ListElement CurrentNodePrev = start;
            if (start == null)
            {
                return false;
            }

            if (start.number == elem)
            {
                LastSearchItem = start;
                return true;
            }
            else
            {
                while (CurrentNode.next != null)
                {
                    if (CurrentNode.number == elem) //Löschen aus Mitte funktioniert (erstes Elem nicht)
                    {
                        LastSearchItem = CurrentNode;
                        LastSearchItemPrev = CurrentNodePrev;
                        return true;
                    }
                    else
                    {
                        CurrentNode = CurrentNode.next;
                        CurrentNodePrev = CurrentNodePrev.next;
                    }
                }
            }            
            return false;
        }
        
        public bool insert(int elem)
        {
            ListElement newElement = new ListElement(elem);
            if (start == null)
            {
                start = newElement;
            }
            else
            {
                newElement.next = start;
                start = newElement;
            }
            return true;
        }
        
        public bool delete(int elem)
        {
            
            if (search(elem))
            {
                LastSearchItemPrev.next = LastSearchItem.next;
            }
            return true;
        }
    }
    class SetSortedLinkedList : MultiSetSortedLinkedList, ISetSorted { }
    class SetUnsortedLinkedList : MultiSetUnsortedLinkedList, ISet { }
}
