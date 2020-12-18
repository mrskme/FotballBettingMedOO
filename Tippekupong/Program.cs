using System;

namespace Tippekupong
{
    class Program
    {
        static void Main(string[] args)
        {
            Match match = new Match();
            Match match2 = new Match();
            match.PlaceBet();
            match.PlayMatch();
            Console.WriteLine(match.GetBetResult());

            match2.PlaceBet();
            match2.PlayMatch();
            Console.WriteLine(match2.GetBetResult());
        }
    }
}
