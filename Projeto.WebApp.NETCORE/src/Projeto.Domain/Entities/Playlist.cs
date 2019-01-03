using Projeto.Domain.Entities.Base;
using Projeto.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class PlayList : EntityBase
    {
        public Usuario Usuario { get; set; }

        //EmAnalise, Aprovado, Recusado
        public EnumStatus Status { get; set; }
    }
}
