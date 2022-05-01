using System;

namespace BE.Common
{
    /// <summary>
    /// A class to inherit from if you need a timestamps on objects.
    /// </summary>
    /// <typeparam name="T">Type for identifing the Object in DB.</typeparam>
    public abstract class AuditableEntity<T>: Entity<T>
    {
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; set; }

        public AuditableEntity(T id): base(id)
        {
            UpdatedAt = CreatedAt = DateTime.UtcNow;
        }
    }
}
