using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Game.Models;
using Game.Service;

namespace Game.Controllers
{
    public class GameController : ApiController
    {

        // GET: api/Game
        public char[,] Get()
        {
            return TikTacToe.board; 
        }

        // POST: api/Game
        public string Post([FromBody] Move move)
        {
            int x = move.X;
            int y = move.Y;
            char symbol = 'X';
            string status="Invalid Move";

            if (move.Player == 1)
                symbol = 'O';

            if (TikTacToe.gameOver == true)
                return "Game over";

            if (TikTacToe.board[x, y] == ' ')
            {
                TikTacToe.board[x, y] = symbol;
                status = "valid Move";
            }
            if (TikTacToe.CheckPlayerWin('O'))
            {
                TikTacToe.gameOver = true;
                return "Player 1 Win";
            }

            if (TikTacToe.CheckPlayerWin('X'))
            {
                TikTacToe.gameOver = true;
                return "Player 2 win";
            }

            return status;
        }
    }
}
