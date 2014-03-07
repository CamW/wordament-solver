using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordamentSolver
{
    class Tile
    {
        public IEnumerable<char> Letters { get; set; }
        public IEnumerable<Tile> AdjTiles { get; set; }

        public bool FindWord(string word, List<Tile> usedTiles)
        {
            //Can't use same tile multiple times.
            if (usedTiles.Contains(this)) return false;
            //Current tile must match top letter
            if (!Letters.Contains(word[0])) return false;
            //This is last letter and letter is contained in letters collection
            if (word.Length <= 1) return true;
            //Add current Tile to used tiles
            usedTiles.Add(this);
            //Check for next letter
            foreach(Tile adjTile in AdjTiles) {
                if (adjTile.FindWord(word.Substring(1), usedTiles))
                    return true;
            }
            return false;
        }

    }
}
