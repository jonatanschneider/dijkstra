using System;
using System.Collections.Generic;

namespace Dijkstra
{
    class func
    {
        public static bool FindWay(string startnode, string endnode)
        {
            while (Library.unvisitedWays.Count != 0)
            {
                string[] neighbours = FindNeighbours(startnode);

                bool destinationReached = IsDestinationReached(endnode, neighbours);

                if (destinationReached)
                {
                    Console.WriteLine("Der kürzeste Weg zu {0} ist {1} Einheiten lang",endnode, Library.shortestPath);
                    Console.ReadLine();
                    return true;
                }
                for (int i = 0; i < neighbours.Length; i++)
                {
                    Library.previousValue = Library.discoveredWays[neighbours[i]];
                    destinationReached = FindWay(neighbours[i], endnode);

                    if (destinationReached)
                    {
                        return destinationReached;
                    }
                }
                return destinationReached;
            }
            int shortestPath = Library.discoveredWays[endnode];
            Console.WriteLine(shortestPath);
            Console.ReadLine();
            return false;
        }

        public static string[] FindNeighbours(string node)
        {
            string[] neighbours = new string[65];

            int neighbourCount = 0;

            foreach (KeyValuePair<string, int> i in Library.waysAndValues)
            {
                if (i.Key.StartsWith(node))
                {
                    MarkNodeAsVisited(i);
                    neighbours[neighbourCount] = i.Key.Substring(1);
                    neighbourCount++;
                }
            }
            string[] result = new string[neighbourCount];

            //Verkleinert das Ergebnis-Arry auf die minimal Größe
            if (neighbourCount > 0)
            {
                for (int i = 0; i < neighbourCount; i++)
                {
                    result[i] = neighbours[i];
                }
            }
            return result;
        }

        public static void MarkNodeAsVisited(KeyValuePair<string, int> node)
        {
            Library.unvisitedWays.Remove(node.Key);

            int currentValue = Library.previousValue + node.Value;

            if (Library.discoveredWays.Count == 0)
            {
                Library.discoveredWays.Add(node.Key.Substring(1), currentValue);
            }

            foreach (KeyValuePair<string, int> i in Library.discoveredWays)
            {
                ActionsForNodes.ChooseCorrectMethodForNode(node, i);

            }
            ActionsForNodes.WriteTempValuesInDictionary();
        }

        public static bool IsDestinationReached(string endnode, string[] points)
        {
            if (points.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] == endnode)
                {
                    Library.shortestPath = Library.discoveredWays[points[i]];
                    return true;
                }
            }
            return false;
        }
    }
}
