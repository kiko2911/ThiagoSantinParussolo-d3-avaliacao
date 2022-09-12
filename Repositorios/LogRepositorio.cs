using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiagoSantinParussolo_d3_avaliacao.Interfaces;
using ThiagoSantinParussolo_d3_avaliacao.Models;

namespace ThiagoSantinParussolo_d3_avaliacao.Repositorios
{
    internal class LogRepositorio
    {
        public void FazerArquivo(Usuario user, string path)
        {
            {
                string folder = path.Split("/")[0];

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }

                using (StreamWriter output = new(path))
                {
                    output.WriteLine(user.Id);
                    output.WriteLine(user.Nome);
                    output.WriteLine(DateTime.Now.ToString("f"));
                }
            }
        }
    }
}
