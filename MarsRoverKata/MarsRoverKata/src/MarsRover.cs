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
        private int[,] grid = new int[10, 10];
        private int directionsMaxIndex => directions.Length - 1;
        public string Execute(string commands)
        {
            var x = 0;
            var y = 0;
            var position = 0;

            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'M':
                        _ = IsRoverPositionEast(position)
                            ? IsRoverForwardXAsix(x) ? x++ : x
                            : IsRoverForwardYAsix(y, position) ? y++ : y;

                        if (IsRoverBackward(y, position))
                        {
                            y--;
                        }
                        break;

                    case 'R':
                        position = directionsMaxIndex > position
                                ? position + 1
                                : 0;
                        break;

                    case 'L':
                        position = IsRoverPositionNorth(position)
                            ? directionsMaxIndex
                            : position - 1;
                        break;
                }
            }

            return $"{x}:{y}:{directions[position]}";
        }

        private bool IsAroundTheEndOfGrid(string asix, int number)
        {
            var asixMapper = new Dictionary<string, int>
            {
                { "y", grid.GetUpperBound(0) },
                { "x", grid.GetUpperBound(1) }
            };

            return number != asixMapper[asix] || number == 0;
        }

        private bool IsRoverBackward(int y, int position)
        {
            return IsRoverPositionSouth(position) && y > 0;
        }

        private bool IsRoverForwardXAsix(int x)
        {
            return IsAroundTheEndOfGrid("x", x);
        }

        private bool IsRoverForwardYAsix(int y, int position)
        {
            return IsAroundTheEndOfGrid("y", y) && 
                !IsRoverPositionWest(position) && 
                !IsRoverPositionSouth(position);
        }

        private bool IsRoverPositionEast(int position)
        {
            return directions[position] == "E";
        }

        private bool IsRoverPositionNorth(int position)
        {
            return directions[position] == "N";
        }

        private bool IsRoverPositionSouth(int position)
        {
            return directions[position] == "S";
        }

        private bool IsRoverPositionWest(int position)
        {
            return directions[position] == "W";
        }
    }
}
