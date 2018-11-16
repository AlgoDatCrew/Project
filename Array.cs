using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    abstract class ArrayBase
    {
        public void print() { }
    }
    class MultiSetSortedArray : ArrayBase, IMultiSetSorted
    {
        public bool search(int elem)
        {
            return true;
        }
        public bool insert(int elem)
        {
            return true;
        }
        public bool delete(int elem)
        {
            return true;
        }
    }
    class MultiSetUnsortedArray : ArrayBase, IMultiSet
    {
        public bool search(int elem)
        {
            return true;
        }
        public bool insert(int elem)
        {
            return true;
        }
        public bool delete(int elem)
        {
            return true;
        }
    }
    class SetSortedArray : MultiSetSortedArray, ISetSorted { }
    class SetUnsortedArray : MultiSetUnsortedArray, ISet { }
}
