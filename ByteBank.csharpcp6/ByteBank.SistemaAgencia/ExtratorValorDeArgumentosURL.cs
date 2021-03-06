using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }
        private readonly string _argumentos;

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');

            _argumentos = URL.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        public string getValor(string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indeEComercial = resultado.IndexOf('&');

            if(indeEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indeEComercial);
        }
    }
}
