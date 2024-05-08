using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTeamsUI.Исключения
{

    [Serializable]
    public class BoxEmptyException : ApplicationException
    {
        public BoxEmptyException() { }
        public BoxEmptyException(string message) : base(message) { }
        public BoxEmptyException(string message, Exception inner) : base(message, inner) { }
        protected BoxEmptyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
