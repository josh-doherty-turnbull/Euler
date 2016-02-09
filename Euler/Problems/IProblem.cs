using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    interface IProblem
    {
        string ProblemName { get; }

        int ProblemNumber { get; }

        string ProblemUrl { get; }

        string ProblemDescription { get; }

        Task<string> SolveAsync();
    }
}
