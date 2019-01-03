using Projeto.Domain.Entities.Base;
using Projeto.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public  class Usuario : EntityBase
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}
