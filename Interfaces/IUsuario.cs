using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiagoSantinParussolo_d3_avaliacao.Models;

namespace ThiagoSantinParussolo_d3_avaliacao.Interfaces
{
    public interface IUsuario
    {
        List<Usuario> GetUsuarios();

        void PegaDados(Usuario user);
    }
}
