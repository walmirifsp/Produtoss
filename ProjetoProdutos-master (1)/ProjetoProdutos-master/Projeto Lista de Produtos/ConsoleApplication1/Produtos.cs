using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Produtos
    {
        List<Produto> listaProdutos = new List<Produto>();
  //      Produto p = new Produto();

        public List<Produto> ListaProdutos { get { return listaProdutos; } set { listaProdutos = value; } }

        public Produtos() { this.listaProdutos = new List<Produto>(); }

        public void Adicionar(Produto p)
        {
            this.listaProdutos.Add(p);
        }

        public Produto Pesquisar(Produto p)
        {
            foreach(Produto elemento in this.listaProdutos) {
                if (elemento.Equals(p))
                    return elemento;
            }
            return new Produto();
        }


        public bool Remover(Produto p)
        {
            Produto resultado = this.Pesquisar(p);
            if (resultado.cod < 0)
                return false;
            else { 
                this.listaProdutos.Remove(resultado);
                return true;
            }
        }

        public double custoTotal()
        {
            double custo = 0;
            foreach(Produto elemento in this.ListaProdutos)
            {
                custo += elemento.Custo();
            }
            return custo;
        }

        public bool PesquisarAdc(Produto p) // pesquisar antes de adicionar
        {
            foreach(Produto resultado in this.listaProdutos)
            {
                if (resultado.Equals(p))
                    return false;                       
            }
            return true;
        }


    }//fim class
}
