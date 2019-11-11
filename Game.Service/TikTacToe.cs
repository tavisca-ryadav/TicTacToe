using System;

namespace Game.Service
{
    public class TikTacToe
    {
        public static char[,] board = new char[3, 3] { { ' ', ' ', ' ' },
        { ' ',' ',' '},
        { ' ',' ',' '} };

        public static bool gameOver = false;

        public static bool CheckPlayerWin(char symbol)
        {
            for(int i = 0; i < 3; i++)
            {
                if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
                    return true;

                if (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol)
                    return true;
            }
            if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
                return true;

            if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
                return true;

            return false;
        }

    }
}
