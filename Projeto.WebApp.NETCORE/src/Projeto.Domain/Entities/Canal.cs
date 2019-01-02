using System;

namespace Projeto.Domain.Entities
{
    public class Canal
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UrlLogo { get; set; }
        public Usuario Usuario { get; set; }

    }
}
