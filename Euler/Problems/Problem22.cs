using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Euler.Problems
{
    class Problem22 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.

What is the total of all the name scores in the file?";
            }
        }

        public override string ProblemName
        {
            get
            {
                return @"Names scores";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 22;
            }
        }

        protected override string Solve()
        {
            
            string Allnames = File.ReadAllText(@"C:\Users\JDT\Desktop\Euler files\P22\p022_names.txt");
            Allnames = Allnames.Replace("\"", "");
            IEnumerable<string> names = Allnames.Split(',');
            names = names.OrderBy(o => o);

            int i = 1;
            long finalAnswer = 0;
            foreach (string item in names)
            {
                finalAnswer += totalScore(item) * i;
                

                i++;

            }

            return finalAnswer.ToString();
        }


        private static Dictionary<Char, int> charScores = new Dictionary<Char, int>
        {
            {'A',1},
            {'B',2},
            {'C',3},
            {'D',4},
            {'E',5},
            {'F',6},
            {'G',7},
            {'H',8},
            {'I',9},
            {'J',10},
            {'K',11},
            {'L',12},
            {'M',13},
            {'N',14},
            {'O',15},
            {'P',16},
            {'Q',17},
            {'R',18},
            {'S',19},
            {'T',20},
            {'U',21},
            {'V',22},
            {'W',23},
            {'X',24},
            {'Y',25},
            {'Z',26} };

        private int totalScore(string name)
        {
            int tempScore = 0;
            foreach (char item in name.ToCharArray())
            {
                tempScore += charScores[item];
                    
            }
            return tempScore;
        }

    }
}
