using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx1
{
    internal class NohLista
    {
        private int info;
        private NohLista previo;
        private NohLista proximo;

        public NohLista()
        { }

        public NohLista(int info)
        {
            this.info = info;
            previo = null;
            proximo = null;
        }

        public int Info { get => info; set => info = value; }
        internal NohLista Previo { get => previo; set => previo = value; }
        internal NohLista Proximo { get => proximo; set => proximo = value; }

    }
}
