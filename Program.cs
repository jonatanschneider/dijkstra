using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string startnode, endnode;
            Console.WriteLine("Geben Sie den Startpunkt ein");
            startnode = Console.ReadLine();
            Console.WriteLine("Geben Sie den Endpunkt ein");
            endnode = Console.ReadLine();
            Library.previousValue = 0;

            func.FindWay(startnode, endnode);



        }
    }
}
