using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        //internal --> modificador de acesso para que a classe seja visível apenas no projeto interno (Bytebank.Modelos).
        public bool CompararSenhas(string senhaverdadeira, string senhaTentativa)
        {
            return senhaverdadeira == senhaTentativa;
        }
    }
}
