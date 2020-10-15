using System;
using System.Collections.Generic;
using System.Text;

namespace Renda.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            double imp = 0.0;

            if(RendaAnual < 20000.00)
            {
                if(GastosSaude > 0)
                {
                    imp = (RendaAnual * 0.15) - (GastosSaude * 0.50);
                }
                else { imp = RendaAnual * 0.15; }
            }
            else {
                if (GastosSaude > 0)
                {
                    imp = (RendaAnual * 0.25) - (GastosSaude * 0.50);
                }
                else { imp = RendaAnual * 0.25; }
            }

            return imp;
        }
    }
}
