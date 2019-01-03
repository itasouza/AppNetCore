

using System;

namespace Projeto.Domain.Entities.Base
{
   public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }
    }
}
