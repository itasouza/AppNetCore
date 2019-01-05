using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Projeto.Domain.Arguments.Usuario;
using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Services;
using Projeto.Domain.Resources;
using Projeto.Domain.ValueObjects;
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

            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
          


            Email email = new Email(request.Email);
            AddNotifications(email);


           // Usuario usuario = new Usuario(nome, request.Email.ToString(), request.Senha);
            AddNotifications(usuario);




            //AdicionarUsuarioResponse response = new RepositoryUsuario().Salvar(usuario);
            // return response;

            if (this.IsInvalid() == true)
            {
                return null;
            }


            return new AdicionarUsuarioResponse(Guid.NewGuid());

        }

        public AutenticarUsuarioResponse AtenticarUsuario(AutenticarUsurioRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
