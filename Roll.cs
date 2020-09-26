using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GreedKata
{
    public class Roll
    {
        public int[] Dice { get; set; } = new int[5];

        public int CountOfDie(int die)
        {
            return Dice.Count(d => d == die);
        }
    }
}
