using Projeto.Domain.Arguments.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Interfaces.Services
{
    public interface IServiceUsuario
    {
        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);
        AutenticarUsuarioResponse AtenticarUsuario(AutenticarUsurioRequest request);
    }
}
