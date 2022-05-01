using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    
    [Serializable]
    public class IdAlreadyExistException : Exception
    {
        private int id;

        public IdAlreadyExistException()
        {
        }

        public IdAlreadyExistException(string message) : base(message)
        {
        }

        public IdAlreadyExistException(string message, int id) : base(message)
        {
            this.id = id;
        }

        public IdAlreadyExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IdAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
