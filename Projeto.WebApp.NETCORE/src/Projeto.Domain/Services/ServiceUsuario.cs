using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Projeto.Domain.Arguments.Usuario;
using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Services;
using Projeto.Domain.Resources;
using System;

namespace Projeto.Domain.Services
{
    public class ServiceUsuario : Notifiable, IServiceUsuario 
    {
        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarUsuarioRequest", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("AdicionarUsuarioRequest"));
                return null;
            }

            Usuario usuario = new Usuario();
            usuario.Nome.PrimeiroNome = "Itamar";
            usuario.Nome.UltimoNome = "Souza";
            usuario.Email.Endereco = "teste@teste.com.br";
            usuario.Senha = "123456";

            if (usuario.Nome.PrimeiroNome.Length < 3 || usuario.Nome.PrimeiroNome.Length > 50)
            {
                throw new Exception("O primeiro nome é obrigatório e deve conter entre 3 a 50 carecteres");
            }
            if (usuario.Nome.UltimoNome.Length < 3 || usuario.Nome.UltimoNome.Length > 50)
            {
                throw new Exception("O ultimo nome é obrigatório e deve conter entre 3 a 50 carecteres");
            }

            if (usuario.Email.Endereco.IndexOf('@') < 1)
            {
                throw new Exception("Emasil invalido");
            }

            if (usuario.Senha.Length >= 3)
            {
                throw new Exception("Senha deve ter no minimo 3 caracteres");
            }

            AdicionarUsuarioResponse response = new RepositoryUsuario().Salvar(usuario);
            return response;

        }

        public AutenticarUsuarioResponse AtenticarUsuario(AutenticarUsurioRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
