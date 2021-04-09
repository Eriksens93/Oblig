using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig2
{
    class Rook : Piece
    {
        public override bool Move(string fromPosition, string toPosition)
        {
            
                return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];

        }

        public Rook() : base("TRN")
        {
            
        }
    }
}
