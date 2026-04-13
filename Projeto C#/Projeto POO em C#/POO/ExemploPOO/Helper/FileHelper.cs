using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var diretorios = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in diretorios)
            {
                Console.WriteLine(retorno);
            }

        }
        public void ListarArquivos(string caminho)
        {
            var arquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in arquivos)
            {
                Console.WriteLine(retorno);
            }
        }
    }
}