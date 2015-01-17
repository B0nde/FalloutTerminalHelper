using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalloutTerminalHelper
{
    public class Entry
    {
        public int NumRight { get; private set; }
        public string Word { get; private set; }
        public List<int> Fits { get; private set; } 

        public Entry(string word, int numRight)
        {
            NumRight = numRight;
            Word = word;

            Fits = new List<int>();
            Fits.Clear();
        }
    }
}
