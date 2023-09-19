using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx1
{
    internal class Lista
    {
        private NohLista INICIO;
        private NohLista FIM;

        internal NohLista INICIO1 { get => INICIO; set => INICIO = value; }
        internal NohLista FIM1 { get => FIM; set => FIM = value; }

        public Lista()
        {
            INICIO = null;
            FIM = null;
        }

        public bool EstaVazia()
        {
            if (INICIO == null)
            {
                return true;
            }

            return false;
        }

        public void Insere(int n)
        {
            NohLista novoNoh = new NohLista(n);

            if (EstaVazia()) //novoNoh é o primeiro elemento a ser inserido
            {
                INICIO = novoNoh;
                FIM = novoNoh;
            }
            else
            {
                novoNoh.Proximo = INICIO;
                INICIO.Previo = novoNoh;
                INICIO = novoNoh;
            }
        }

        public NohLista EncontraNoh(int n)
        {
            NohLista temp = INICIO;

            while (temp != null)
            {
                if (temp.Info == n)
                    return temp;
                temp = temp.Proximo;
            }


            return null;
        }
        public void Remove(int n) 
        {
            NohLista nohRemove = EncontraNoh(n);

            if (nohRemove == INICIO)
            {
                INICIO = INICIO.Proximo;
                INICIO.Previo = null;
            }
            else if (nohRemove == FIM)
            {
                FIM = FIM.Previo;
                FIM.Proximo = null;
            }
            else
            {
                (nohRemove.Previo).Proximo = nohRemove.Proximo;
                (nohRemove.Proximo).Previo = nohRemove.Previo;
            }
        }

        public int Maior()
        {
            int maior = INICIO.Info;

            NohLista temp = INICIO;
            while (temp != null)
            {
                if (temp.Info > maior)
                    maior = temp.Info;
                temp = temp.Proximo;
            }

            return maior;
        }

        public void Imprime()
        {
            NohLista temporaria = INICIO;
            while (temporaria != null)
            {
                Console.WriteLine(temporaria.Info);
                temporaria = temporaria.Proximo;
            }
        }

























    }
}
