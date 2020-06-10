using System;
using System.Numerics;

namespace UserDomain.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
           
        }

        public long Id { get; set; }
    }
}

