using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartesiaBinaryTree
{
    class FunksioneTePemesBinare
    {
        public int thellesia(Nyja nyje)
        {
            if (nyje == null)
                return 0;
            return Math.Max(thellesia(nyje.majte), thellesia(nyje.djathte))+1;
        }
    }
}
