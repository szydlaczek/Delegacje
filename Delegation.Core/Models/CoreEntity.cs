using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation.Core.Models
{
    public abstract class CoreEntity
    {
        protected CoreEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;
        }

        public string Id { get; private set; }
        public DateTime CreatedDate { get; }
        public DateTime? DeletedDate { get; private set; }

        public void Delete()
        {
            if (DeletedDate.HasValue)
                return;

            DeletedDate = DateTime.Now;
        }
    }
}
