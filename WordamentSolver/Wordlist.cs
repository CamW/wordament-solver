using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordamentSolver
{
    class Wordlist
    {
        const int MIN_WORD_SIZE = 3;

        public string[] FullWordList { get; private set; }

        public Wordlist(string fullWordList)
        {
            this.FullWordList = fullWordList.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < this.FullWordList.Length; i++ )
            {
                if (this.FullWordList[i].Contains(' '))
                {
                    this.FullWordList[i] = this.FullWordList[i].Substring(0, this.FullWordList[i].IndexOf(' '));
                }
            }
        }

        private Wordlist(IEnumerable<string> fullWordList)
        {
            this.FullWordList = fullWordList.ToArray();
        }

        public Wordlist LimitWordsByLetterList(IEnumerable<char> letterList)
        {
            return new Wordlist(BuildWordArrayForLetterList(letterList));
        }

        private IEnumerable<string> BuildWordArrayForLetterList(IEnumerable<char> letterList) {

            foreach (string word in FullWordList)
            {
                bool keepWord = true;
                if (word.Length < MIN_WORD_SIZE || word.Length > letterList.Count())
                    continue;
                foreach (char wordChar in word.ToCharArray())
                {
                    if (!letterList.Contains(wordChar))
                    {
                        keepWord = false;
                        break;
                    }
                }
                if (keepWord)
                    yield return word;
            }
        }
    }
}
