using System;
using System.Globalization;

namespace ExerFix03
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double SomaNotas()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Resultado()
        {
            double nota = Nota3 + Nota1 + Nota2;

            if(nota > 60.0)
            {
                return "Aprovado";
            } else { nota = 60.00 - nota;  
                    return "Reprovado\nFaltaram " + nota.ToString("F2",CultureInfo.InvariantCulture) + " Pontos"; }
        }
    }
}
