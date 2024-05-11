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
            var charArr = commands.ToCharArray();
            var x = 0;
            var y = 0;
            var position = 0;
            
            foreach (char c in charArr)
            {
                if (c == 'M')
                {
                    if (x != 9 && position == 1)
                    {
                        x++;
                    } else
                    {
                        if (y != 9)
                        {
                            y++;
                        }
                    }
                }
                if (c == 'R')
                {
                    if (position + 1 == directions.Length)
                    {
                       position = 0;
                    }
                    else
                    {
                       position++;
                    }
                }
                if (c == 'L')
                {
                    if (position == 0)
                    {
                        position = 3;
                    }
                    else
                    {
                        position--;
                    }
                }
            }
            
            return $"{x}:{y}:{directions[position]}";
        }
    }
}
