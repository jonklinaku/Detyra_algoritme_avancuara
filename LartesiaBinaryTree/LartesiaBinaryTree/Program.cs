using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartesiaBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Nyja rrenja = new Nyja(5);
            rrenja.majte = new Nyja(3);
            rrenja.djathte = new Nyja(8);
            rrenja.majte.majte = new Nyja(1);
            rrenja.majte.djathte = new Nyja(4);
            rrenja.djathte.majte = new Nyja(6);
            rrenja.djathte.djathte = new Nyja(13);
            //rrenja.djathte.djathte.djathte = new Nyja(17);
            FunksioneTePemesBinare ftpb = new FunksioneTePemesBinare();
            Console.WriteLine("Lartesia e pemes binare eshte: "+ftpb.thellesia(rrenja));
            Console.WriteLine("Ju lutem shtypni cfare do tasti...");
            Console.ReadKey();
        }
    }
}
