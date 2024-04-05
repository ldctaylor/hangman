using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Player
    {
       internal string _name;

        internal Player(string name)
        {
            if (name == null)
                _name = "Anon";
            else _name = name;
        }
    }
}
