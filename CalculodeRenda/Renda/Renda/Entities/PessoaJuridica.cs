using System;
using System.Collections.Generic;
using System.Text;

namespace Renda.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double renda, int numFuncionarios) : base(nome, renda)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double Imposto()
        {
            double imp = RendaAnual * 0.16;

            if(NumFuncionarios > 10)
            {
                imp = RendaAnual * 0.14;
            }

            return imp;
        }
    }
}
