using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Anagrama
{
    public static class LeitorDicionario
    {
        const string ArquivoDicionario = "Dicionario/palavras.txt";

        public static List<string> LerDicionario()
        {
            return File.ReadAllLines(ArquivoDicionario).ToList();
        }
    }
}
