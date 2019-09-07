using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Entities.Base
{
    public interface IEntity
    {
        bool Active { get; set; }
        DateTime CreatedOn { get; set; }
        Guid CreatedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
        Guid? ModifiedBy { get; set; }
    }
    public interface IEntity<T> : IEntity
    {
        T Id { get; set; }
    }
}
