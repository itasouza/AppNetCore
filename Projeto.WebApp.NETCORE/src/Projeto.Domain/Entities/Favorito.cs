using Projeto.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
   public class Favorito : EntityBase
    {
        public Video Video { get; set; }
        public Usuario Usuario { get; set; }
    }
}
