using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    internal class IdNotExistException : Exception
    {
        private int id;

        public IdNotExistException()
        {
        }

        public IdNotExistException(string message) : base(message)
        {
        }

        public IdNotExistException(string message, int id) : base(message)
        {
            this.id = id;
        }

        public IdNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IdNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
