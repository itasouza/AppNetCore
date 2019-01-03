using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Arguments.Usuario
{
    public class AutenticarUsurioRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
