using System;
using System.Collections.Generic;
using System.Text;

namespace Tippekupong
{
    class Match
    { 
        private int _homeGoals;
        private int _awayGoals;
        private bool _matchIsRunning;
        private string _bet;

        public Match()
        {
            _matchIsRunning = true;
        }

        public void PlaceBet()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            _bet = Console.ReadLine();
        }

        public void PlayMatch()
        {
            while (_matchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") StopMatch();
                if (command == "H") AddGoal(true);
                else if (command == "B") AddGoal(false);
                Console.WriteLine(GetScore());
            }
        }
        public void StopMatch()
        {
            _matchIsRunning = false;
        }
        public void AddGoal(bool isHomeTeam)
        {
            var addGoal = isHomeTeam ? _homeGoals++ : _awayGoals++;
        }

        public string GetScore()
        {
            return $"Stillingen er {_homeGoals}-{_awayGoals}.";
        }

        public string GetBetResult()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            var isBetCorrect = _bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            return $"Du tippet {isBetCorrectText}";
        }
    }
}
