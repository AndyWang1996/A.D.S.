using System;
using Trees.Model;

namespace Trees.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalTree nt = new NormalTree();
            nt.set(1,2);
            nt.show();

            BRTree brt = new BRTree();
            brt.set(1,2);
            brt.show();
        }
    }
}
