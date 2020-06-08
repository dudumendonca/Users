using System;

namespace UserDomain.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = 0;
        }

        public int Id { get; set; }
    }
}

