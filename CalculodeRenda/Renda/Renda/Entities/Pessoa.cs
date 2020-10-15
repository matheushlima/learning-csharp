﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Renda.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        abstract public double Imposto();
        
    }
}
