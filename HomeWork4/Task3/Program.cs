using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of your football team: ");
            string yourTeam = Console.ReadLine();
            Console.WriteLine("Please enter the games that your team has earnd: ");
            Console.WriteLine("How many games have they won?");
            int win;
            string winInput = Console.ReadLine();
            bool checkInput = int.TryParse(winInput, out win);
            while (!checkInput || win < 0)
            {
                Console.WriteLine("Please add a valid number!");
                Console.WriteLine("How many games have they won?");
                winInput = Console.ReadLine();
                checkInput = int.TryParse(winInput, out win);
            }
            Console.WriteLine("How many games were draw?");
            int draw;
            string drawInput = Console.ReadLine();
            bool checkInput2 = int.TryParse(drawInput, out draw);
            while (!checkInput2 || draw < 0)
            {
                Console.WriteLine("Please add a valid number!");
                Console.WriteLine("How many games were draw?");
                drawInput = Console.ReadLine();
                checkInput2 = int.TryParse(drawInput, out draw);
            }
            Console.WriteLine("How many games have they lost?");
            int lose;
            string loseInput = Console.ReadLine();
            bool checkInput3 = int.TryParse(loseInput, out lose);
            while (!checkInput3 || lose < 0)
            {
                Console.WriteLine("Please add a valid number!");
                Console.WriteLine("How many games have they lost?");
                loseInput = Console.ReadLine();
                checkInput3 = int.TryParse(loseInput, out lose);
            }
           
            string yourTotalPts = TotalTeamPts(yourTeam, win, draw, lose);

            Console.WriteLine(yourTotalPts);
            
            


        }

        public static string TotalTeamPts(string yourTeam, int win, int draw, int lose)
        {
            int wins = win * 3;
            int draws = draw * 1;
            int losses = lose * 0;
            int totalPoints = wins + draws + losses;
            string result = $"The {yourTeam} have a total of {totalPoints} Pts this season, with {win} wins, {draw} draws and {lose} lost games!";
            return result;
        }
    }
}
