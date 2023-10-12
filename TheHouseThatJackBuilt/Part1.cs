using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHouseThatJackBuilt
{
    internal class Part1
    {
        public ImmutableList<string>? Poem { get; private set; }

        public ImmutableList<string> AddPart(ImmutableList<string> poem)
        {
            return Poem = poem.Add("Дом, который построил Джек.");
        }
    }
}
