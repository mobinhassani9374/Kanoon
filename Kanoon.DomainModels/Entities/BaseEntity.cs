using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Entities
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
