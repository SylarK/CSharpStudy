using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class TestandoExpressoes
    {
        public string regex1()
        {
            //string padrao1 = "[0-9]{4}[-][0-9]{4}";
            //string padrao2 = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao2 = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao3 = "[0-9]{4,5}-?[0-9]{4}";
            string textoTeste = "Meu número é 9986-9956";
            //Regex.IsMatch(textoTeste, padrao);
            //Match resultado = Regex.Match(textoTeste, padrao);
            Console.WriteLine();

            return null;
        }
    }
}
