using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    abstract class BaseProblem : IProblem
    {
        public abstract string ProblemName { get; }
        public abstract int ProblemNumber { get; }
        public abstract string ProblemDescription { get; }
        
        public string ProblemUrl
        {
            get { return "https://projecteuler.net/problem=" + ProblemNumber.ToString(); }
        }

        public async Task<string> SolveAsync()
        {
            return await Task.Run(() => Solve());
        }

        protected abstract string Solve();
    }
}
