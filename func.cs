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
                    Console.WriteLine("Fertig");
                    //return true;
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
            return false;
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

            if (Library.discoveredWays.Count == 0)
            {
                Library.discoveredWays.Add(node.Key.Substring(1), currentValue);
            }
            else
            {
                foreach (KeyValuePair<string, int> i in Library.discoveredWays)
                {
                    if (i.Key.StartsWith(node.Key.Substring(1)))
                    {
                        if (i.Value > currentValue)
                        {
                            if (Library.temporaryDict.ContainsKey(node.Key.Substring(1)))
                            {
                                Library.temporaryDict[node.Key.Substring(1)] = currentValue;
                            }
                            else
                            {
                                Library.temporaryDict.Add(node.Key.Substring(1), currentValue);
                            }
                        }
                    }
                        //Überprüft ob der Knoten schon im temp-Dict ist, schreibt ggf. den kleineren Wert rein
                    else if (Library.temporaryDict.ContainsKey(node.Key.Substring(1)))
                    {
                        if (currentValue < Library.temporaryDict[node.Key.Substring(1)])
                        {
                            //Library.discoveredWays.Add(node.Key.Substring(1), currentValue);
                            Library.temporaryDict[node.Key.Substring(1)] = currentValue;
                        }
                    }
                    else
                    {
                        Library.temporaryDict.Add(node.Key.Substring(1), currentValue);
                    }
                }
            }
            foreach (KeyValuePair<string, int> i in Library.temporaryDict)
            {
                if (Library.discoveredWays.ContainsKey(i.Key))
                {
                    Library.discoveredWays[i.Key] = i.Value;
                }
                else
                {
                    Library.discoveredWays.Add(i.Key, i.Value);
                }
            }
            Library.temporaryDict.Clear();
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
