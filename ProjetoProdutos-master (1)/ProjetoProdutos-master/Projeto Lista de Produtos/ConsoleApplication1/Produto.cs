using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Produto
    {
        //private int cod;
        //private string desc;
        //private int qtd;
        //private double preco;
        public Produto()
        {
            this.cod = -1;
            this.desc = "";
            this.qtd = 0;
            this.preco = 0;
        }

        public Produto(int a, string b, int c, double d)
        {
            this.cod = a;
            this.desc = b;
            this.qtd = c;
            this.preco = d;
        }

        public int cod { get /*{ return this.cod; }*/; set /*{ this.cod = value; }*/; }
        public string desc { get /*{ return this.desc; }*/; set /*{ this.desc = value; }*/; }
        public int qtd { get /*{ return this.qtd; } */ ; set /*{ this.qtd = value; }*/; }
        public double preco { get /*{ return this.preco; } */; set /*{ this.preco = value; }*/; }

        public double Custo() { return this.qtd * this.preco; }

        public override bool Equals(object obj)
        {
            return this.cod == ((Produto)obj).cod;
        }

    }
    }
