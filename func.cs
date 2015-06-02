﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return true;
            }

            for (int i = 0; i < neighbours.Length; i++)
            {
                //Rekursion
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
                    Library.discoveredWays.Add(i.Key, i.Value);
                    neighbours[neighbourCount] = i.Key.Substring(1);
                    neighbourCount++;
                }
            }
            /* for (int i = 0; i < Library.NumberOfWays; i++)
            {
                if (Library.names[i].StartsWith(node))
                {
                    neighbours[neighbourCount] = Library.names[i].Substring(1);
                    neighbourCount++;
                }
            }  */
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
                    return true;
                }
            }
            return false;
        }
    }
}
