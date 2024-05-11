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
                    if (position == 1)
                    {
                        x++;
                    } 
                    else
                    {
                        y++;
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
                    position = 3;
                }
            }
            
            return $"{x}:{y}:{directions[position]}";
        }
    }
}
