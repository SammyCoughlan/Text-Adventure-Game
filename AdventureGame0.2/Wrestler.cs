using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Wrestler
    {
        public int Str;
        public int Dex;
        public bool Winner;
        public string Name;

        public Wrestler(string name, int str, int dex, bool win)
        {
            Str = str;
            Dex = dex;
            Winner = win;
            Name = name;
        }


    }
}
