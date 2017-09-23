using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan2.Bai7
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Console.WriteLine("Player vs COM");
            playerVsCom();
            Console.WriteLine("Player vs Player");
            playerVsPlayer();
        }
        public enum GameState
        {
            Win,
            Lose,
            Draw,
        }
        public void playerVsCom()
        {
            Random rand = new Random();
            int player = createMenu("Player: ");
            int COM = rand.Next(0, 3);
            switch (COM)
            {
                case 0:
                    Console.WriteLine("COM>\tRock");
                    break;
                case 1:
                    Console.WriteLine("COM>\tPaper");
                    break;
                case 2:
                    Console.WriteLine("COM>\tSessior");
                    break;
            }

            switch (isPlayerWin(player, COM))
            {
                case GameState.Win:
                    Console.WriteLine("You Win");
                    break;
                case GameState.Draw:
                    Console.WriteLine("Draw!");
                    break;
                case GameState.Lose:
                    Console.WriteLine("You Lose");
                    break;
            }
        }
        public void playerVsPlayer()
        {
            int player1 = createMenu("Player 1:");
            int player2 = createMenu("Player 2:");
            int[] player = { player1, player2 };
            for (int i = 0; i < player.Length; i++)
            {
                switch (player[i])
                {
                    case 0:
                        Console.WriteLine("player" + (i + 1) + ">\tRock");
                        break;
                    case 1:
                        Console.WriteLine("player" + (i + 1) + ">\tPaper");
                        break;
                    case 2:
                        Console.WriteLine("player" + (i + 1) + ">\tSessior");
                        break;
                }
            }
            switch (isPlayerWin(player1, player2))
            {
                case GameState.Win:
                    Console.WriteLine("player1 Win");
                    break;
                case GameState.Draw:
                    Console.WriteLine("Draw!");
                    break;
                case GameState.Lose:
                    Console.WriteLine("player2 Win");
                    break;
            }

        }
      
        public GameState isPlayerWin(int player, int COM)
        {
            if (player == 2 && COM == 0)
                return GameState.Lose;
            if (player == 0 && COM == 2)
                return GameState.Win;
            if (player > COM)
                return GameState.Win;
            if (player < COM)
                return GameState.Lose;
            return GameState.Draw;
        }
        public int createMenu(string caption)
        {
            int choose = 0;
            bool exit = false;
            string[] menuText = { "Rock", "Paper", "Sessior" };
            while (!exit)
            {
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.DownArrow:
                        choose++;
                        break;
                    case ConsoleKey.UpArrow:
                        choose--;
                        break;
                    case ConsoleKey.Enter:
                        exit = true;
                        break;
                }
                Console.Clear();
                if (choose == 3)
                    choose = 0;
                if (choose == -1)
                    choose = 2;
                Console.WriteLine(caption);
                for(int i = 0; i < menuText.Length; i++)
                {
                    if (i == choose)
                    {
                        Console.Write("Select>");
                    }
                    Console.WriteLine("\t" + menuText[i]);
                }
                
            }
            return choose;
        }

    }
}
