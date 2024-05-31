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
        private int position = 0;
        private int x = 0;
        private int y = 0;
        
        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'M':
                        _ = IsRoverPositionNorth()
                            ? y++
                            : x++;
                        break;

                    case 'R':
                        position = IsRoverPositionWest()
                            ? 0
                            : position+=1;
                        break;

                    case 'L':
                        position = IsRoverPositionNorth()
                            ? directions.Length - 1
                            : position-=1;
                        break;
                }
            }
            
            return $"{x}:{y}:{directions[position]}";
        }

        private bool IsRoverPositionNorth()
        {
            return directions[position] == "N";
        }

        private bool IsRoverPositionWest()
        {
            return directions[position] == "W";
        }
    }
}
