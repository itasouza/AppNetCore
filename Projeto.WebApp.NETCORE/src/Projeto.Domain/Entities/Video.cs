using Projeto.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Video : EntityBase
    {

        public Canal Canal { get; set; }
        public PlayList PlayList { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public int OrdemNaPlayList { get; set; }
        public string IDVideoYoutube { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public string Status { get; set; }

    }
}
