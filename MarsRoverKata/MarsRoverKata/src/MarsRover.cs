using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata.src
{
    public class MarsRover
    {
        private string[] directions = new string[] { "N", "E", "S", "W" };
        
        public string Execute(string commands)
        {
            var position = 0;
            var x = 0;
            var y = 0;

            foreach (var command in commands)
            {
                if (command == 'M' && position == 0)
                {
                    y++;
                }
                if (command == 'M' && position == 1)
                {
                    x++;
                }
                if (command == 'R')
                {
                    position++;
                    if (directions.Length - 1 < position)
                    {
                        position = 0;
                    }
                }
                if (command == 'L')
                {
                    position = directions.Length - 1;
                }
            }
            
            return $"{x}:{y}:{directions[position]}";
        }
    }
}
