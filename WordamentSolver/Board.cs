using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordamentSolver
{
    class Board
    {
        private Tile[,] tilesOnBoard = null;
        private int BoardSize { get; set; }

        public Board(short boardSize) {
            tilesOnBoard = new Tile[boardSize,boardSize];
            this.BoardSize = boardSize;
            //Create
            for (int x = 0; x < boardSize; x++){
                for (int y = 0; y < boardSize ; y ++){
                    tilesOnBoard[x, y] = new Tile();
                }
            }
            
            //Set Adjacent tiles
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    BuildAndSetAdjacentTileListForPos(x, y);
                }
            }
            
        }

        public void SetBoardState(string boardState)
        {
            string[] tileValArray = boardState.Split(new string[] { ",", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            short boardSize = (short)Math.Sqrt(tileValArray.Length);
            if (tileValArray.Length != tilesOnBoard.Length) throw new ArgumentException("Board state size does not match created size!");

            for (int i = 0; i < tileValArray.Length; i++)
            {
                tilesOnBoard[i % this.BoardSize, i / boardSize].Letters = tileValArray[i].ToCharArray();
            }

        }

        public void FindWord(object state)
        {
            WordSearchContext wsc = (WordSearchContext)state;
            string word = wsc.Word;
            foreach (Tile startTile in tilesOnBoard)
            {
                if (startTile.FindWord(word, new List<Tile>()))
                {
                    wsc.CompleteCallback(word, true);
                    return;
                }
            }
            wsc.CompleteCallback(word, false);
        }

        private void BuildAndSetAdjacentTileListForPos(int x, int y)
        {
            List<Tile> AdjTileSet = new List<Tile>();
            for (int xa = x - 1; xa <= x + 1; xa++)
            {
                for (int ya = y - 1; ya <= y + 1; ya++)
                {
                    if (ya >= 0 && xa >= 0 && ya < BoardSize && xa < BoardSize && (ya != y || xa != x))
                    {
                        AdjTileSet.Add(tilesOnBoard[xa, ya]);
                    }
                }
            }
            tilesOnBoard[x, y].AdjTiles = AdjTileSet.ToArray();
        }

    }
}