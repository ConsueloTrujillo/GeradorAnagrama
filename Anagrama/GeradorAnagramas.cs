using System.Collections.Generic;

namespace Anagrama
{
    public class GeradorAnagramas
    {
        private List<string> Dicionario { get; set; } = new List<string>();
        private List<string> PalavrasEncontradas { get; set; } = new List<string>();

        public GeradorAnagramas(List<string> dicionario)
        {
            Dicionario = dicionario;
        }

        public List<string> GerarAnagramas(string palavraBase)
        {
            VerificarAnagramas("", palavraBase);
            return PalavrasEncontradas;
        }

        private void VerificarAnagramas(string prefixo, string palavra)
        {
            if (palavra.Length <= 1)
            {
                var palavraFinal = prefixo.ToUpper() + palavra.ToUpper();

                if (Dicionario.Contains(palavraFinal) && !PalavrasEncontradas.Contains(palavraFinal))
                    PalavrasEncontradas.Add(palavraFinal);
            }
            else
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    var cursor = palavra.Substring(i, 1);
                    var antes = palavra.Substring(0, i);
                    var depois = palavra.Substring(i + 1);
                    VerificarAnagramas(prefixo + cursor, antes + depois);
                }
            }
        }
    }
}
