using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjForcaTB
{
    class Forca
    {
        private string[] palavras;

        private int pos;

        public int Pos
        {
            get { return pos; }
            set { pos = value; }
        }
        public Forca(string[] palavras, int pos)
        {
            this.palavras = palavras;
            this.pos = pos;
        }
        public Forca(): this(null, 0)
        {

        }
        public void sortear()
        {
            Random sorteio = new Random();
            this.pos = sorteio.Next(palavras.Count());
        }
        public string devolvePalavra(){
            return palavras[Pos];
        }

    }
}
