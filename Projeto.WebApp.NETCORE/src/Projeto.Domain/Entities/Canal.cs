using Projeto.Domain.Entities.Base;
using System;

namespace Projeto.Domain.Entities
{
    public class Canal: EntityBase
    {
        public string Nome { get; set; }
        public string UrlLogo { get; set; }
        public Usuario Usuario { get; set; }

    }
}
