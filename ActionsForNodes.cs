using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class ActionsForNodes
    {

        public static void ChooseCorrectMethodForNodes(KeyValuePair<string, int> node, KeyValuePair<string, int> i)
        {
            int currentValue = Library.previousValue + node.Value;

            if (i.Key.StartsWith(node.Key.Substring(1)))
            {
                if (currentValue < i.Value)
                {
                    WriteSmallerWayInDictionary(node, currentValue);
                }
            }
            else if (Library.temporaryDict.ContainsKey(node.Key.Substring(1)))
            {
                if (currentValue < Library.temporaryDict[node.Key.Substring(1)])
                {
                    RefreshExistingWay(node, currentValue);
                }
            }
            else
            {
                AddWayToDictionary(node, currentValue);
            }

        }

        public static void WriteSmallerWayInDictionary(KeyValuePair<string, int> node, int currentValue)
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

        public static void RefreshExistingWay(KeyValuePair<string, int> node, int currentValue)
        {
            Library.temporaryDict[node.Key.Substring(1)] = currentValue;
        }

        public static void AddWayToDictionary(KeyValuePair<string, int> node, int currentValue)
        {
            Library.temporaryDict.Add(node.Key.Substring(1), currentValue);
        }

        public static void WriteCurrentValuesInDictionary()
        {
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
    }
}
