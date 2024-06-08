﻿using System;
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
                            ? grid.GetUpperBound(1) > x ? x++ : x
                            : grid.GetUpperBound(0) > y ? y++ : y;
                        break;

                    case 'R':
                        position++;
                        if (directions.Length - 1 < position)
                        {
                            position = 0;
                        }
                        break;
                }
            }

            return $"{x}:{y}:{directions[position]}";
        }

        private bool IsRoverPositionEast(int position)
        {
            return directions[position] == "E";
        }
    }
}
