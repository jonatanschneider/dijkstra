using System;
using System.Collections.Generic;

namespace Dijkstra
{
    class func
    {
        public static bool FindWay(string startnode, string endnode)
        {
            string[] neighbours = FindNeighbours(startnode);

            bool destinationReached = IsDestinationReached(endnode, neighbours);

            if (destinationReached)
            {
                Console.WriteLine("Fertig");
                Console.WriteLine(Library.shortestPath);
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


        /// <summary>
        /// Sucht alle Nachbarn eines Knotens und schreibt sie in ein Array
        /// </summary>
        /// <param name="node">Knoten von dem Nachbarn gesucht werden</param>
        /// <returns>Array mit den Nachbarn</returns>
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

            if (neighbourCount > 0)
            {
                //Schreibt das Ergebnis in das "result" Array
                //und verkleinert das Array so auf die minimale Zahl
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

            //kann nicht funktionieren da discoveredWays noch keine Werte hat
            //und somit die foreach Schleife nichts tut
            foreach (KeyValuePair<string, int> i in Library.discoveredWays)
            {
                if (i.Key.StartsWith(node.Key.Substring(1)))
                {
                    if (i.Value < node.Value)
                    {
                        Library.discoveredWays[node.Key] = i.Value;
                    }
                }
                else
                {
                    Library.discoveredWays.Add(node.Key.Substring(1), currentValue);
                }
            }

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
