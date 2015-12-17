using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TETRISMAZAFAKA
{
    class Statistic:IStatic
    {
        int DifficultofGame(int difficult)
        {
            return difficult++;
        }
        int CountScore(int score)
        {
            return score = score + 10;
        }

    }
}
