using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordamentSolver
{
    class WordSearchContext
    {
        public WordSearchContext(string word, Action<string, bool> completeCallback)
        {
            this.Word = word;
            this.CompleteCallback = completeCallback;
        }

        public string Word { get; private set; }
        public Action<string, bool> CompleteCallback { get; private set; }
    }
}
