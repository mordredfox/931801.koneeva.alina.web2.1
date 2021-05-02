using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web1.Services
{
    
    public interface ICalc
    {
        int Randomize();
    }
    public class SimpleCalc : ICalc
    {
        Random rand = new Random();
        public int Randomize()
        {
            return rand.Next(0, 10);
        }
    }
}
