using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TETRISMAZAFAKA
{
    interface IFigure
    {
        string NextFigure(int indexoffigure);
        void DrawingOfFigure(string Figure);
        void MotionOfFigure();
        void TurnFigure();
        public void drop();
        public void turn();
    }
}
