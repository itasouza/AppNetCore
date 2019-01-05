using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Projeto.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;


            new AddNotifications<Email>(this)
                  .IfNotEmail(x => x.Endereco, MSG.X0_INVALIDO.ToFormat("E-mail não é válido", 1, 50));

        }

        public string Endereco { get; private set; }

    }
}
