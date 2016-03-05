using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3.Models
{
    class Move
    {
        public static void SnakeToRight()
        {
            Game.snake.MoveSnake(1, 0);  
        }
        public static void SnakeToLeft()
        {
            Game.snake.MoveSnake(-1, 0);
        }
        public static void SnakeToUp()
        {
            Game.snake.MoveSnake(0, -1);
        }
        public static void SnakeToDown()
        {
            Game.snake.MoveSnake(0, 1);
        }
    }
}
