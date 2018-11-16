using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary idict = null;

            Console.Write("Entscheiden Sie sich zunächst für einen abstrakten Datentyp ihrer Wahl:\n\n1: Unsortierte Menge\n2: Sortierte Menge\n3: Unsortierte Multimenge\n4: Sortierte Multimenge\n\nEingabe: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nEntscheiden Sie sich nun für einen konkreten Datentyp:\n");

            if (input == 1)
            {
                Console.Write("1: Unsortiertes Array\n2: Unsortierte verkettete Liste\n\nEingabe: ");
                input = Convert.ToInt32(Console.ReadLine());
                if(input == 1)
                {
                    idict = new SetUnsortedArray();
                }
                else if(input == 2)
                {
                    idict = new SetUnsortedLinkedList();
                }
            }
            else if(input == 2)
            {
                Console.Write("1: Sortiertes Array\n2: Sortierte verkettete Liste\n3: Binärer Suchbaum\n4: Ausgeglichener Baum\n5: Treap\n\nEingabe: ");
                input = Convert.ToInt32(Console.ReadLine());
                if(input == 1)
                {
                    idict = new SetSortedArray();
                }
                else if(input == 2)
                {
                    idict = new SetSortedLinkedList();
                }
                else if(input == 3)
                {
                    idict = new BinSearchTree();
                }
                else if(input == 4)
                {
                    idict = new AVLTree();
                }
                else if(input == 5)
                {
                    idict = new Treap();
                }
            }
            else if(input == 3)
            {
                Console.Write("1: Unsortiertes Array mit Mehrfacheinträgen\n2: Unsortierte verkettete Liste mit Mehrfacheinträgen\n\nEingabe: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    idict = new MultiSetUnsortedArray();
                }
                else if(input == 2)
                {
                    idict = new MultiSetUnsortedLinkedList();
                }
            }
            else if(input == 4)
            {
                Console.Write("1: Sortiertes Array mit Mehrfacheinträgen\n2: Sortierte verkettete Liste mit Mehrfacheinträgen\n\nEingabe: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    idict = new MultiSetSortedArray();
                }
                else if (input == 2)
                {
                    idict = new MultiSetSortedLinkedList();
                }
            }

            Console.Write("\n\nWählen Sie eine Aktion aus:\n\n1: Datenstruktur anzeigen\n2: Element hinzufügen\n3: Element suchen\n4: Element löschen\n\nEingabe: ");
            input = Convert.ToInt32(Console.ReadLine());

            if(input == 1)
            {
                idict.print();
            }
            else if(input > 1 && input < 5)
            {
                Console.Write("\n\nGeben Sie eine positive ganze Zahl ein: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (input == 2)
                {
                    //idict.insert(number);
                    idict.insert(3);
                    idict.insert(4);
                    idict.insert(5);
                    idict.insert(2);
                    idict.print();
                    idict.delete(2);
                    Console.WriteLine();
                    idict.print();
                }
                else if (input == 3)
                {
                    idict.search(number);
                }
                else if (input == 4)
                {
                    idict.delete(number);
                }
            }
        }
    }
}
