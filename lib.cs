using System.Collections.Generic;

namespace Dijkstra
{
    class Library
    {

        public static int previousValue { get; set; }

        public static int shortestPath { get; set; }

        public static Dictionary<string, int> discoveredWays = new Dictionary<string, int>
        {
        };

        public static Dictionary<string, int> unvisitedWays = new Dictionary<string, int>
        {
            {"AB", 6}, {"AD", 7}, {"BC", 4},
            {"BE", 4}, {"CF", 6}, {"CI", 8},
            {"DG", 5}, {"EJ", 5}, {"FK", 5},
            {"GH", 5}, {"GI", 7}, {"HL", 5},
            {"IM", 5}, {"JK", 7}, {"JT", 4},
            {"KU", 9}, {"LM", 6}, {"MN", 5},
            {"NO", 7}, {"OQ", 5}, {"PQ", 8},
            {"PU", 2}, {"QX", 7}, {"RT", 8},
            {"RY", 10}, {"RZ", 4},{"SW", 2}, 
            {"SX", 4}, {"TV", 7}, {"WY", 9},
            {"XY", 11}
        };

        public static Dictionary<string, int> waysAndValues = new Dictionary<string, int>
        {
            {"AB", 6}, {"AD", 7}, {"BC", 4},
            {"BE", 4}, {"CF", 6}, {"CI", 8},
            {"DG", 5}, {"EJ", 5}, {"FK", 5},
            {"GH", 5}, {"GI", 7}, {"HL", 5},
            {"IM", 5}, {"JK", 7}, {"JT", 4},
            {"KU", 9}, {"LM", 6}, {"MN", 5},
            {"NO", 7}, {"OQ", 5}, {"PQ", 8},
            {"PU", 2}, {"QX", 7}, {"RT", 8},
            {"RY", 10}, {"RZ", 4},{"SW", 2}, 
            {"SX", 4}, {"TV", 7}, {"WY", 9},
            {"XY", 11}
        };
    }
        /*public static void Ways()
        {
            Dictionary<string, int> ways = new Dictionary<string, int>();
            ways.Add("AB", 6);
            ways.Add("AD", 7);
            ways.Add("BC", 4);
            ways.Add("BE", 4);
            ways.Add("CF", 6);
            ways.Add("CI", 8);
            ways.Add("DG", 5);
            ways.Add("EJ", 5);
            ways.Add("FK", 5);
            ways.Add("GH", 5);
            ways.Add("GI", 7);
            ways.Add("HL", 5);
            ways.Add("IM", 5);
            ways.Add("JK", 7);
            ways.Add("JT", 4);
            ways.Add("KU", 9);
            ways.Add("LM", 6);
            ways.Add("MN", 5);
            ways.Add("NO", 7);
            ways.Add("OQ", 5);
            ways.Add("PQ", 8);
            ways.Add("PU", 2);
            ways.Add("QX", 7);
            ways.Add("RT", 8);
            ways.Add("RY", 10);
            ways.Add("RZ", 4);
            ways.Add("SW", 2);
            ways.Add("SX", 4);
            ways.Add("TV", 7);
            ways.Add("WY", 9);
            ways.Add("XY", 11);
            int test = 1;
            NumberOfWays = ways.Count();

            public static int GetValue(string node){
                if (.test) == 1{

                }
            }

        } */
}

