using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    abstract class HashTabBase
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
        public void print()
        {
        }
    }
    class HashTabSepChain : HashTabBase, ISet { }
    class HashTabQuadProb : HashTabBase, ISet { }
}
