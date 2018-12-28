using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public EntityStateOption EntityState { get; set; }

        // Read only
        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();
    }
}
