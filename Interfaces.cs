using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    interface IDictionary
    {
        bool search(int elem);  // true = gefunden
        bool insert(int elem);  // true = hinzugefügt
        bool delete(int elem);  // true = gelöscht
        void print();           // Einfache Ausgabe der Elemente des
                                // Wörterbuches auf die Console,
                                // so dass Inhalt & Struktur
                                // daraus eindeutig erkennbar
    }
    interface IMultiSet : IDictionary { }
    interface IMultiSetSorted : IDictionary { }
    interface ISet : IMultiSet { }
    interface ISetSorted : IMultiSetSorted { }
}
