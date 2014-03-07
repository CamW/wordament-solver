using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordamentSolver
{
    partial class MainForm : Form
    {
        Stopwatch timer = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
            Solver.InitState(4);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            timer.Reset();
            timer.Start();
            Solver.SolveBoard(GridTextBox.Text, new Action<string[]>(this.SetResults));

        }

        private void SetResults(string[] foundWords)
        {
            timer.Stop();
            ResultsTextBox.Invoke(new MethodInvoker(() =>
            {
                WordsFoundTextBox.Text = foundWords.Length.ToString();
                SolvedInTextbox.Text = timer.ElapsedMilliseconds.ToString() + " ms";
                ResultsTextBox.Text = string.Join("\r\n", foundWords);
                MessageBox.Show("Complete!");
            }));
        }
    }
}
