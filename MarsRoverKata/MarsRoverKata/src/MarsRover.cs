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
            }
            
            return $"{x}:{y}:{directions[position]}";
        }
    }
}
