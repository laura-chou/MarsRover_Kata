using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata.src
{
    public class MarsRover
    {
        public string Execute(string commands)
        {
            var charArr = commands.ToCharArray();
            var x = 0;
            var y = 0;
            var position = "N";
            
            foreach (char c in charArr)
            {
                if (c == 'M')
                {
                    y++;
                }
            }
            
            return $"{x}:{y}:{position}";
        }
    }
}
