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
        private int position = 0;
        private int x = 0;
        private int y = 0;
        
        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                if (command == 'M')
                {
                    if (IsRoverPositionNorth())
                    {
                        y++;
                    }
                    else
                    {
                        x++;
                    }
                }

                if (command == 'R')
                {
                    if (IsRoverPositionWest())
                    {
                        position = 0;
                    } 
                    else
                    {
                        position++;
                    }
                }
                if (command == 'L')
                {
                    if (IsRoverPositionNorth())
                    {
                        position = directions.Length - 1;
                    }
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
