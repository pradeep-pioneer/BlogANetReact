using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Entities.Base
{
    public abstract class Entity : IEntity
    {
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }

    public abstract class Entity<T> : Entity, IEntity<T>
    {
        public T Id { get; set; }
    }
}
