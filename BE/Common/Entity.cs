using BE.Enums;

namespace BE.Common
{
    /// <summary>
    /// A base class to inherit from for unison purposes.
    /// </summary>
    /// <typeparam name="T"> Type for Identifying the Object in the DB.</typeparam>
    public abstract class Entity<T>
    {
        public T Id { get; private set; }
        public string Name { get; private set; }
        public int size { get; private set; }
        //public Materials[] materials { get;  set; }


    public Entity(T id)
        {
            Id = id;
        }
    }
}
