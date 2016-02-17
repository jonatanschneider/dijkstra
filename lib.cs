using System.Collections.Generic;

namespace Dijkstra
{
    class Library
    {
        public static int previousValue { get; set; }

        public static int shortestPath { get; set; }

        public static Dictionary<string, int> discoveredWays = new Dictionary<string, int> { };

        public static Dictionary<string, int> temporaryDict = new Dictionary<string, int> { };

        public static Dictionary<string, int> unvisitedWays = new Dictionary<string, int>
        {
            {"AB", 6}, {"AD", 7}, 
            {"BC", 4}, {"BE", 4}, {"BA", 6},
            {"CF", 6}, {"CI", 8}, {"CB", 4},
            {"DG", 5}, {"DA", 7},
            {"EJ", 5}, {"EB", 4},
            {"FK", 5}, {"FC", 6},
            {"GH", 5}, {"GI", 7}, {"GD", 5}, 
            {"HL", 5}, {"HG", 5},
            {"IM", 5}, {"IG", 7}, {"IC", 6},
            {"JK", 7}, {"JT", 4}, {"JE", 5},
            {"KU", 9}, {"KJ", 7}, {"KF", 5},
            {"LM", 6}, {"LH", 5},
            {"MN", 5}, {"MI", 5}, {"ML", 6},
            {"NO", 7}, {"NM", 5},
            {"OQ", 5}, {"ON", 7},
            {"PQ", 8}, {"PU", 2},
            {"QX", 7}, {"QP", 8}, {"QO", 5},
            {"RT", 8}, {"RY", 10}, {"RZ", 4},
            {"SW", 2}, {"SX", 4},
            {"TJ", 4}, {"TV", 7}, {"TR", 8},
            {"UP", 2}, {"UK", 9},
            {"VT", 7},
            {"WY", 9}, {"WS", 2},
            {"XY", 11},{"XS", 4}, {"XQ", 7},
            {"YR", 10},{"YX",11}, {"YW", 9},
            {"ZR", 4}
        };

        public static Dictionary<string, int> waysAndValues = new Dictionary<string, int>
        {
            {"AB", 6}, {"AD", 7}, 
            {"BC", 4}, {"BE", 4}, {"BA", 6},
            {"CF", 6}, {"CI", 8}, {"CB", 4},
            {"DG", 5}, {"DA", 7},
            {"EJ", 5}, {"EB", 4},
            {"FK", 5}, {"FC", 6},
            {"GH", 5}, {"GI", 7}, {"GD", 5}, 
            {"HL", 5}, {"HG", 5},
            {"IM", 5}, {"IG", 7}, {"IC", 6},
            {"JK", 7}, {"JT", 4}, {"JE", 5},
            {"KU", 9}, {"KJ", 7}, {"KF", 5},
            {"LM", 6}, {"LH", 5},
            {"MN", 5}, {"MI", 5}, {"ML", 6},
            {"NO", 7}, {"NM", 5},
            {"OQ", 5}, {"ON", 7},
            {"PQ", 8}, {"PU", 2},
            {"QX", 7}, {"QP", 8}, {"QO", 5},
            {"RT", 8}, {"RY", 10}, {"RZ", 4},
            {"SW", 2}, {"SX", 4},
            {"TJ", 4}, {"TV", 7}, {"TR", 8},
            {"UP", 2}, {"UK", 9},
            {"VT", 7},
            {"WY", 9}, {"WS", 2},
            {"XY", 11},{"XS", 4}, {"XQ", 7},
            {"YR", 10},{"YX",11}, {"YW", 9},
            {"ZR", 4}
>>>>>>> BetterMethods
        };
    }
}

