using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WordamentSolver
{
    public static class Solver
    {
        const string WORD_LIST_PATH = @"english-words.txt";
        const int WORKER_THREAD_COUNT = 1;

        static Board MyBoard = null;
        static Wordlist FullWordList = null;
        static Wordlist CurrentWordList = null;
        static int CompletedWords = 0;
        static int ExpectedWords = 0;
        static List<string> FoundWords = null;
        static Action<string[]> CompletedCallback = null;

        public static void InitState(short boardSize)
        {
            MyBoard = new Board(boardSize);
            FullWordList = new Wordlist(File.ReadAllText(WORD_LIST_PATH));
        }

        public static void SolveBoard(string boardState, Action<string[]> callback)
        {
            //Init Board and Wordlist
            char[] letterList = string.Join("", boardState.Split(new string[] { ",", "\r\n"}, StringSplitOptions.RemoveEmptyEntries)).ToCharArray();
            CurrentWordList = FullWordList.LimitWordsByLetterList(letterList);
            MyBoard.SetBoardState(boardState);

            //Init Solve Cycle Members
            CompletedCallback = callback;
            CompletedWords = 0;
            ExpectedWords = CurrentWordList.FullWordList.Length;
            FoundWords = new List<string>();
            
            QueueWorkTasks();

        }

        private static void QueueWorkTasks()
        {
            WaitCallback findWordCallback = new WaitCallback(MyBoard.FindWord);
            ThreadPool.SetMaxThreads(WORKER_THREAD_COUNT, 0);
            foreach (string word in CurrentWordList.FullWordList)
            {
                WordSearchContext wsc = new WordSearchContext(word, new Action<string,bool>(WordSearchResult));
                ThreadPool.QueueUserWorkItem(findWordCallback, wsc);
            }
        }

        private static void WordSearchResult(string word, bool found)
        {
            lock (FoundWords)
            {
                CompletedWords++;

                if (found) FoundWords.Add(word);

                if ((CompletedWords == ExpectedWords) && (CompletedCallback != null))
                {
                    CompletedCallback(FoundWords.ToArray());
                }
            }
        }
    }
}
